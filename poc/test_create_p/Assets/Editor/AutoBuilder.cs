// Simple script that lets you create a new
// scene, create a cube and an empty game object in the scene
// Save the scene and close the editor

using UnityEngine;	
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;

using System;

public static class AutoBuilder {

  //[MenuItem ("Build/BuildWebplayer")]
  static void PerformBuild () {
    string[] scenes = { "Assets/MyNewScene.unity" };
    //EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.WebPlayer);
    BuildPipeline.BuildPlayer(scenes, "WebPlayerBuild", BuildTarget.WebPlayer, BuildOptions.None); 
  }

}	
