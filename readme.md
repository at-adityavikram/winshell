# Winshell
Note: This version now obsolete and no longer updated. The latest version was renamed to 'Alberio', and is available at https://github.com/at-adityavikram/albireo

<p align="center">
  <img src="WinShell/Resources/dark.jpg" width="900">
</p>

My attempt at a shell/ux replacement for windows... IN VB!!
May provide a windows 10-esqe ux to older windows versions.

#### Note: At this point, it is basically just a working start menu, nothing too much other than that

## What's New:

###  - The app now follows the System Accent Color.
###  - Fluent-like blurring behind the app.  
<p align="center">
  <img src="WinShell/Resources/blur.jpg" width="400">
</p>

###  - Can now pin and unpin tiles.
<p align="center">
  <img src="WinShell/Resources/menu.jpg" width="300"> &nbsp;&nbsp;&nbsp; <img src="WinShell/Resources/menu2.jpg" width="400">
</p>

###  - Added a Light theme, automatically switches based on system theme
<p align="center">
  <img src="WinShell/Resources/light.jpg" width="600">
</p>
This is incomplete, so there are still some regions and controls with the wrong color


###  - Minor UI Tweaks
 - Now shows proper start menu behaviour - like closing when deactivated.

 - Bugfixes, 
Some experimental Fatures added. to enable them, you need to change the flags accordingly in WinShell.exe.config

### Bugs
  - It may take around 15 seconds to load all apps if there are too many apps.
  - Tiles may jitter when right clicked
  - Light theme is incomplete
  - Search may work slower than expected when searching in a large number of apps

### Acknowlwdgements
 The design of the start menu is based to some extent on a design by Michael West on twitter. I decided to make a working win32 version,
 taking up the challenge of making decently good looking apps in VB just for fun. Suggestions/help/feedback is welcome.
