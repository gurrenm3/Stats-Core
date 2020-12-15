# Stats-Core
An API for Subnautica that lets you easily modify Player and Item stats

### How to use it with your mods?
Download the latest release or clone/build the project yourself. Then reference the Stats-Core.dll in your mod and add `using Stats_Core. Extensions;` to the top of the class file that you want to use it in. That's it! You've now got all the power of Stats Core at your finger tips. The API focuses on extension methods. So in your patches if you want to modify Player stats, just use the player `instance`. 

Ex: `Player.main.AddMaxThirst(amount);`. Stats core will do all the heavy lifting for you and patch the 5 or 6 methods required to change Max Thrist properly.


### What can it currently do?
Currently, Stats Core lets you modify most of the important player stats. Max Health, Max Food, Max Water, Lung Capacity, etc. It also adds custom-made stats like Health Regen and Dehydration damage (now separate from Starve damage). All of these things have been tested and patched correctly so you no longer have to patch countless methods yourself just to accomplish one thing.

### Why use Stats Core over modding stats yourself?
You certainly can do it yourself, but are you sure you patched everything? Is everything consistent, easy to use, and bug free? It might be, but isn't it easier to let someone else do all the work for you? Since the only purpose of Stats Core is changing stats, it's focused on doing that correctly and consistently, with the easiest implementation possible. Additionally, Stats Core is designed with many mods in mind. That means your mods are more likely to be compatible with other "stat modifying mods".
