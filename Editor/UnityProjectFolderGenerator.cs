using UnityEngine;
using UnityEditor;
using System.IO;

public class UnityProjectFolderGenerator : EditorWindow
{
    [MenuItem("Tools/Setup Project Folders")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(UnityProjectFolderGenerator), false, "Project Folder Setup");
    }


    private void OnGUI()
    {
        GUILayout.Label("Unity Project Folder Setup", EditorStyles.boldLabel);
        GUILayout.Space(10);

        GUILayout.Label("This will create a standard Unity project folder structure.", EditorStyles.wordWrappedLabel);
        GUILayout.Space(10);

        if (GUILayout.Button("Create Project Folders", GUILayout.Height(30)))
        {
            CreateProjectFolderStructure();
        }

        GUILayout.Space(10);
        GUILayout.Label("Existing folders will be ignored.", EditorStyles.miniLabel);
    }

    private static void CreateProjectFolderStructure()
    {
        string[] folders = new string[]
        {
            // Core folders
            "Application/Scripts",
            "Application/Scripts/Editor",
            "Application/Scripts/Runtime",
            "Application/Scripts/Tests",

            // Asset folders
            "Application/Art",
            "Application/Art/2D",
            "Application/Art/3D",
            "Application/Art/Materials",
            "Application/Art/Textures",
            "Application/Art/Sprites",

            // Audio folders
            "Application/Audio",
            "Application/Audio/Music",
            "Application/Audio/SFX",
            "Application/Audio/Voice",
            "Application/Audio/Mixers",

            // Animation folders
            "Application/Animations",
            "Application/Animations/Controllers",
            "Application/Animations/Clips",

            // Scene folders
            "Application/Scenes",
            "Application/Scenes/Levels",
            "Application/Scenes/Menus",
            "Application/Scenes/Test",

            // Prefab folders
            "Application/Prefabs",
            "Application/Prefabs/UI",
            "Application/Prefabs/Gameplay",
            "Application/Prefabs/Environment",
            "Application/Prefabs/Effects",

            // ScriptableObjects
            "Application/ScriptableObjects",
            "Application/ScriptableObjects/Data",
            "Application/ScriptableObjects/Settings",
            "Application/ScriptableObjects/Events",

            // Fonts and UI
            "Application/Fonts",
            "Application/UI",

            // Shaders and Effects
            "Application/Shaders",
            "Application/Effects",
            "Application/Effects/Particles",
            "Application/Effects/PostProcessing",

            // Resources and Streaming Assets
            "Application/Resources",
            "Application/StreamingAssets",

            // Documentation
            "Application/Documentation",

            // Third Party
            "Application/ThirdParty",
            "Application/ThirdParty/Plugins",
            "Application/ThirdParty/Assets",

            // Build and Settings
            "Application/Settings",
            "Application/Build",

            // Project specific folders
            "Application/Data",
            "Application/Localization"
        };

        int createdCount = 0;
        int existingCount = 0;

        foreach (string folder in folders)
        {
            string fullPath = Path.Combine(Application.dataPath, folder);

            if (!Directory.Exists(fullPath))
            {
                Directory.CreateDirectory(fullPath);
                createdCount++;
                Debug.Log($"Created folder: {folder}");
            }
            else
            {
                existingCount++;
            }
        }

        AssetDatabase.Refresh();

        Debug.Log($"Folder setup complete! Created: {createdCount}, Already existed: {existingCount}");

        EditorUtility.DisplayDialog(
            "Project Folders Created",
            $"Successfully created {createdCount} new folders.\n{existingCount} folders already existed.",
            "OK"
        );
    }
}
