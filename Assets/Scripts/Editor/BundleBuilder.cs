using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BundleBuilder : Editor
{
    [SerializeField]
    private string path;

    [MenuItem("Assets/Build AssetBundles")]
    private static void BuildAssetBundles()
    {
        BuildPipeline.BuildAssetBundles(@"Assets\AssetBundles", BuildAssetBundleOptions.ChunkBasedCompression, BuildTarget.StandaloneWindows);
    }
}