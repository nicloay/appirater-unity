# appirater-unity

Unity ios rate us plugin.

This plugin use 
* [appirater](https://github.com/arashpayan/appirater) iOS plugin for backend
* [xcodeapi](https://bitbucket.org/Unity-Technologies/xcodeapi) editor tools to modify xcode project to include localization files and StoreKit.framework framework.


Starting from 10.3 version this plugin will show native dialogue, prior that version it's a manual popup which support most of the languages.

|prior to 10.3 version | 10.3+ versions|
|:----:|:----:|
|![9 3_popup](https://user-images.githubusercontent.com/1671030/33431973-9b12e428-d5d6-11e7-8f53-b4adc395666e.png)|![10 3_popup](https://user-images.githubusercontent.com/1671030/33430710-c9c114a2-d5d1-11e7-84b3-666b905ed19c.png)|

How to use it
=============

Download and import [latest release](https://github.com/nicloay/appirater-unity/releases/tag/1.0) in to your project

On application start you must call following method
```
Appirater.Init(AppId, DaysUntilPrompt, UsesUntilPrompt,
				SignificantEventsUntilPrompt, TimeBeforeReminding, Debug)
```

And on significant event call
```
Appirater.DidSignificantEvent
```

for more details please read origina [appirater documentation](https://github.com/arashpayan/appirater)

Move plugin to another location
===========

If you move plugin to another location like

from `Appirater/iOS` to `3DParty/Appirater/iOS` 

you must change **PluginHome** value at `PostProcess.cs` script also.

Appendix
========
project built on Unity 5.6.3 version

if you have any questions please use [official forum](https://forum.unity.com/threads/rate-us-ios-plugin-bsed-on-appirater-supportthread.506893/)

thanks to [zeyangl](https://github.com/zeyangl) for great [example](https://github.com/zeyangl/UnityAppNameLocalizationForIOS) how to use xcodeapi
