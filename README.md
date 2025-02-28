
<h1 align="center">Town of Host Edited Plus</h1>

<br>

<img align="left" alt="Cover" src="Resources/Images/TOHE-BG.jpg" width="50%" height="250" /> 

<p align="right">
  
> ### Regarding this mod
>
> This mod is not affiliated with Among Us or Innersloth LLC, and the content contained therein is not endorsed or otherwise sponsored by Innersloth LLC. Portions of the materials contained herein are the property of Innersloth LLC.
<br>

</p>
<p align="center">
  
<a href="https://toher.dev/" target="_blank"><img src="https://img.shields.io/badge/Website%20-%231DA1F2.svg?&style=for-the-badge&logo=vuedotjs&logoColor=white&color=3aa675"/></a>
<a href="https://discord.gg/m3ayxfumC8" target="_blank"><img src="https://img.shields.io/badge/Discord%20-%231DA1F2.svg?&style=for-the-badge&logo=discord&logoColor=white&color=5662f6"/></a>
<a href="https://github.com/Gurge44/TOHE_PLUS_/releases/latest" target="_blank"><img src="https://img.shields.io/badge/Latest Version%20-%231DA1F2.svg?&style=for-the-badge&logo=github&logoColor=white&color=181717"/></a>

</p>

---

<br>

## Additions, Changes, and improvements compared to TOHRE
- Note: The goal with this branch is to improve the existing stuff over adding new roles. Some of the new stuff listed below are ported into TOHRE by me.
### New gamemode
- A brand new official gamemode, Basic FFA (Free For All)
- This mode makes everyone a killer and the last player alive wins
- Features: Random events, ranks and scoring, random ability gain for every kill, game timer, scoreboard (task list), unique end screen, fully customizable
### Overall improvements
- Gain more ability uses for completing tasks as crewmate roles
- Gain more ability uses for getting kills as impostor roles
- Prevent kills while shifted when no abiltiy uses are left for some roles (Sniper, Twister, Disperser, Hangman, Camouflager, etc.)
- Code cleanup and small performance improvement
- Improved EAC
- Better intro sounds
- Better custom button images
- Better progress text look
- Visualized cooldowns for more roles
- Disabled most shield animations for modded clients for a better experience, and even some for vanilla clients (all cooldowns are still reset properly, this is just a visual improvement)
- Shapeshift and vent cooldowns are now always reset after meetings
- Custom main menu
- Improved strings and their appearance
- More customizable settings; More reasonable default settings
- Starting Kill Cooldown setting
- Better confirm ejections text
- Brand new HUD text
- Better role summary
- Smaller mod version text and smaller credentials text (imo it was annoying that it covered a quarter of the screen)

### Role specific Improvements
#### Crewmates
- Chameleon uses vanilla engineer cooldown
- The target of the Deputy no longer gets a shield animation on top of the Deputy
- Fortune Teller: Setting whether it shows specific roles after completing tasks
- Merchant: Option to sell Balanced add-ons (based on my opinion)
- Mortician: Setting whether it has arrows toward dead bodies
- Oracle: Chance to show incorrect result
- Mechanic: Settings that determine how many uses it takes to fix Lights/Comms and Reactor/O2
- Sheriff: Setting whether to display the shot limit next to the role name
- Tracefinder: Settings that determine the delay in which the arrows show up
- Bodyguard: Setting whether the murderer dies when the bodyguard protects the target
#### Impostors
- Assassin: Kill Cooldown no longer resets when unshifting
- Bounty Hunter: Target's name is displayed in black for the Bounty Hunter; Swap Timer is displayed next to the role name, not on the Shapeshift button => Changed the basis to regular Impostor
- Eraser: Erase by Voting or by Kill Button & What to do when target is neutral
- Hangman: Kill Cooldown after strangling
- Mare (add-on): Can kill at all times, but if lights are not out, the kill cooldown is higher
- Quick Shooter now works correctly
- Serial Killer: Suicide Timer is displayed next to the role name, not on the Shapeshift button => Changed the basis to regular Impostor; Setting whether the Suicide Timer only starts after their first kill
- Swooper: Setting whether it can vent normally when swooping is on cooldown; Swoop Cooldown is visualized next to the role name
- Wildling: Setting whether the role can Shapeshift or not; Setting whether the role can Vent or not
- Underdog: Can kill at all times, but if the number of players alive is higher than the set amount, the kill cooldown is higher
- Miner: Shapeshift Cooldown and Shapeshift Duration setting
- Escapist: Shapeshift Cooldown and Shapeshift Duration setting
- Cleaner: Can only clean bodies if their kill cooldown is up
- Vampire: Kill Cooldown is reset when the bitten target dies
- Capitalist: Can kill normally with the double click method (& + Kill Cooldown setting)
- Killing Machine: Has impostor vision
#### Neutrals
- Medusa: Can only clean bodies if their kill cooldown is up
- Wraith: Setting whether it can vent normally when invis is on cooldown; Invis Cooldown is visualized next to the role name
- Poisoner: Kill Cooldown is reset when the poisoned target dies

### Now, some new roles as well
- Lighter (Crewmate)
- Demolitionist (Crewmate)
- Ventguard (Crewmate)
- Express (Crewmate)
- Witness (Crewmate)
- Alchemist (Crewmate)
- Task Manager (Crewmate)
- Speedrunner (Crewmate)
- Ignitor (Crewmate)
- Security Guard (Crewmate)
- Romantic (Neutral)
- Werewolf (Neutral)
- Imitator (Neutral)
- Head Hunter (Neutral)
- Vengeance (Neutral)
- Eclipse (Neutral)
- Pyromaniac (Neutral)
- Undertaker (Impostor)
- Deadly Quota (Impostor-only Add-on)

## Note:
- You can use parts of the code in here, but if you do, you'll have to credit me (Gurge44) or the mod by mentioning its name (TOHE+) and providing a link to this github page.
- Do not try to build the source code. It will give you errors. This is intentional, so copying the mod is not so easy. To play the mod, use the given dll in the release section.

<br>

## Credit to these mods and their developers for the code and help:
### :star: [TOHE](https://github.com/KARPED1EM/TownOfHostEdited) :
> 
> - Our repo is forked from TOHE
> 
### :star: [TOH](https://github.com/tukasa0001/TownOfHost) :
> 
> - Our repo is based initially on TOH
> 
### :star: [TOHY](https://github.com/Yumenopai/TownOfHost_Y) :
> 
> - Many role ideas
> - Provided roles: AntiAdminer, CursedWolf, Workaholic, Greedier, DarkHide
> - Reference: Modify game announcement
> 
### :star: [TOH:TOR](https://github.com/music-discussion/TownOfHost-TheOtherRoles) :
> 
> - Many role ideas
> - Reference: Exile Confirm
> - Reference: Split RPC Pack
> 
### :star: [SNR](https://github.com/ykundesu/SuperNewRoles) :
> 
> - Reference: Credentials menu
> - Reference: Switch Horse Mode
> - Reference: Search Mod Game
> - Reference: Custom Button
>
### :star: [TOP](https://github.com/tugaru1975/TownOfPlus) :
> 
> - Reference: Zoom
> 
### :star: [RHR](https://github.com/sansaaaaai/Revolutionary-host-roles) :
> 
> - Reference: Modify settings menu
> 

### :star: [TOH+](https://github.com/SkullCreeper/TownOfHostPlus) :
>
> - Provided roles: Marshall, Poisoner, Necroview, Sidekick
>

### :star: [PL](https://github.com/ImaMapleTree/Lotus) :
>
> - Ideas for some roles
> - Reference: Customize Main Menu
> - Reference: Auto Play Again
> - Reference: Some TabIcons
>

### :star: [Stellar Roles](https://github.com/Mr-Fluuff/StellarRolesAU) :
>
> - Many role ideas (this mod is seriously amazing)
> - Reference: Some custom button images
> 

### :star: [TOHEX](https://github.com/TOHEX-Official/TownOfHostEdited-Xi) :
>
> - Provided role: Swapper
> 
