# DyrwynQuenched

Removes the fire particle animation from the **Dyrwyn** sword in Valheim.
The blade's emissive glow and point light are preserved — the sword still looks hot, just without the animated flames.

## Requirements

- [BepInExPack Valheim](https://thunderstore.io/c/valheim/p/denikson/BepInExPack_Valheim/) 5.4.2202+

## Installation

### r2modman / Thunderstore Mod Manager (recommended)
Install via the mod manager — dependencies are handled automatically.

### Manual
1. Install BepInExPack Valheim.
2. Copy `DyrwynQuenched.dll` to `<Valheim>/BepInEx/plugins/DyrwynQuenched/`.
3. Launch the game.

## Building from source

```
# Set your Valheim install path
dotnet build DyrwynQuenched/DyrwynQuenched.csproj -p:ValheimDir="C:\...\Valheim"
```

Output: `DyrwynQuenched/bin/DyrwynQuenched.dll`
