# Unity Project Folder Generator

Automatically generates a standard Unity project folder structure with one click. Creates organized folders for scripts, art, audio, animations, scenes, prefabs, and more.

## Features

- **One-Click Setup**: Create a complete project folder structure instantly
- **Comprehensive Structure**: Includes folders for all common Unity asset types
- **Non-Destructive**: Existing folders are preserved and skipped
- **Organized Workflow**: Professional folder hierarchy for better project management

## Installation

### Install via Git URL (Recommended)

1. Open Unity Package Manager: `Window → Package Manager`
2. Click the `+` button in the top-left corner
3. Select `Add package from git URL...`
4. Enter: `https://github.com/FaiyazMdAbdul/unity-project-folder-generator.git`
5. Click `Add`

### Install from Disk

1. Download or clone this repository
2. Open Unity Package Manager: `Window → Package Manager`
3. Click the `+` button in the top-left corner
4. Select `Add package from disk...`
5. Navigate to the package folder and select `package.json`

## Usage

1. In Unity, go to `Tools → Setup Project Folders`
2. A window will appear with a "Create Project Folders" button
3. Click the button to generate the folder structure
4. Check the Console for a summary of created/existing folders

## Folder Structure

The tool creates the following structure under `Assets/Application/`:

```
Application/
├── Scripts/
│   ├── Editor/
│   ├── Runtime/
│   └── Tests/
├── Art/
│   ├── 2D/
│   ├── 3D/
│   ├── Materials/
│   ├── Textures/
│   └── Sprites/
├── Audio/
│   ├── Music/
│   ├── SFX/
│   ├── Voice/
│   └── Mixers/
├── Animations/
│   ├── Controllers/
│   └── Clips/
├── Scenes/
│   ├── Levels/
│   ├── Menus/
│   └── Test/
├── Prefabs/
│   ├── UI/
│   ├── Gameplay/
│   ├── Environment/
│   └── Effects/
├── ScriptableObjects/
│   ├── Data/
│   ├── Settings/
│   └── Events/
├── UI/
├── Fonts/
├── Shaders/
├── Effects/
│   ├── Particles/
│   └── PostProcessing/
├── Resources/
├── StreamingAssets/
├── Documentation/
├── ThirdParty/
│   ├── Plugins/
│   └── Assets/
├── Settings/
├── Build/
├── Data/
└── Localization/
```

## Requirements

- Unity 2017.1 or later

## License

MIT

## Author

[FaiyazMdAbdul](https://github.com/FaiyazMdAbdul)
