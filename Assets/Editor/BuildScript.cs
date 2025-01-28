using UnityEditor;
using UnityEngine;

public class BuildScript
{
    static void BuildProject()
    {
        string[] scenes = { "Assets/Scenes/SampleScene.unity" }; // Укажите пути к вашим сценам
        string buildPath = "Builds/StandaloneWindows/MyGame.exe"; // Путь для сборки

        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = scenes,
            locationPathName = buildPath,
            target = BuildTarget.StandaloneWindows64,
            options = BuildOptions.None
        };

        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
    [MenuItem("Build/Build Standalone Windows")]
    static void BuildStandaloneWindows()
    {
        BuildProject();
    }

    [MenuItem("Build/Build From Command Line")]
    static void BuildFromCommandLine()
    {
        BuildProject();
    }
}
