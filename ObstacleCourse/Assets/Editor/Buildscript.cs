using UnityEditor;

public class BuildScript {
    public static void Build() {
        string[] scenes = { "Assets/Scenes/SampleScene.unity" }; // Update path
        BuildPipeline.BuildPlayer(scenes, "/Builds/ObstacleCourse/Game.exe", BuildTarget.StandaloneWindows64, BuildOptions.None);
    }
}
