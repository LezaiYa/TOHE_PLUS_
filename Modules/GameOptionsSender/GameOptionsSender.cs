using AmongUs.GameOptions;
using Hazel;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using InnerNet;
using System.Collections.Generic;

namespace TOHE.Modules;

public abstract class GameOptionsSender
{
    #region Static
    public readonly static List<GameOptionsSender> AllSenders = new(15) { new NormalGameOptionsSender() };

    public static void SendAllGameOptions()
    {
        AllSenders.RemoveAll(s => !s.AmValid());
        for (int i = 0; i < AllSenders.Count; i++)
        {
            GameOptionsSender sender = AllSenders[i];
            if (sender.IsDirty) sender.SendGameOptions();
            sender.IsDirty = false;
        }
    }
    #endregion

    public abstract IGameOptions BasedGameOptions { get; }
    public abstract bool IsDirty { get; protected set; }


    public virtual void SendGameOptions()
    {
        var opt = BuildGameOptions();

        // option => byte[]
        MessageWriter writer = MessageWriter.Get(SendOption.None);
        writer.Write(opt.Version);
        writer.StartMessage(0);
        writer.Write((byte)opt.GameMode);
        if (opt.TryCast<NormalGameOptionsV07>(out var normalOpt))
            NormalGameOptionsV07.Serialize(writer, normalOpt);
        else if (opt.TryCast<HideNSeekGameOptionsV07>(out var hnsOpt))
            HideNSeekGameOptionsV07.Serialize(writer, hnsOpt);
        else
        {
            writer.Recycle();
            Logger.Error("オプションのキャストに失敗しました", this.ToString());
        }
        writer.EndMessage();

        // 配列化&送信
        var byteArray = new Il2CppStructArray<byte>(writer.Length - 1);
        // MessageWriter.ToByteArray
        Buffer.BlockCopy(writer.Buffer.Cast<Array>(), 1, byteArray.Cast<Array>(), 0, writer.Length - 1);

        SendOptionsArray(byteArray);
        writer.Recycle();
    }
    public virtual void SendOptionsArray(Il2CppStructArray<byte> optionArray)
    {
        for (byte i = 0; i < GameManager.Instance.LogicComponents.Count; i++)
        {
            if (GameManager.Instance.LogicComponents[i].TryCast<LogicOptions>(out _))
            {
                SendOptionsArray(optionArray, i, -1);
            }
        }
    }
    protected virtual void SendOptionsArray(Il2CppStructArray<byte> optionArray, byte LogicOptionsIndex, int targetClientId)
    {
        var writer = MessageWriter.Get(SendOption.Reliable);

        writer.StartMessage(targetClientId == -1 ? Tags.GameData : Tags.GameDataTo);
        {
            writer.Write(AmongUsClient.Instance.GameId);
            if (targetClientId != -1) writer.WritePacked(targetClientId);
            writer.StartMessage(1);
            {
                writer.WritePacked(GameManager.Instance.NetId);
                writer.StartMessage(LogicOptionsIndex);
                {
                    writer.WriteBytesAndSize(optionArray);
                }
                writer.EndMessage();
            }
            writer.EndMessage();
        }
        writer.EndMessage();

        AmongUsClient.Instance.SendOrDisconnect(writer);
        writer.Recycle();
    }
    public abstract IGameOptions BuildGameOptions();

    public virtual bool AmValid() => true;
}