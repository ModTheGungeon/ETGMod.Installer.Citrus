# DEPRECATED
Originally used to workaround legal problems with de4dot being licensed under GIT and the installer under MIT - now serves no purpose as Gungeon isn't obfuscated anymore.  
Left here as it may be useful again at a later date.

ModTheGungeon Installer (Citrus)
===================
So... copying some files and running a .bat / .sh is not your thing?
It's dangerous out there - take this!  

This is just an installing utility for [ModTheGungeon](https://modthegungeon.github.io/), a mod for the game "Enter The Gungeon".

For issues with the installer, select the log box, CTRL+A, CTRL+C, create an issue here.

For issues with ModTheGungeon, f.e. crashes, go the EtG.exe folder, then EtG_Data, upload output_log.txt, create an issue [in this repo](https://github.com/ModTheGungeon/ETGMod).

Uses [MonoMod](https://github.com/0x0ade/MonoMod), Mono.Cecil and a binary blob repository as submodules and de4dot (in said repository) as dependency. Clone recursively!

This is the citrus flavour of ETGMod.Installer, being an extended version using de4dot as the deobfuscator through the extension layer.
