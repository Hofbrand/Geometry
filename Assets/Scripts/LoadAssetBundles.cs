using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class LoadAssetBundles : MonoBehaviour
    {
        private AssetBundle loadedAssetBundle;

        [SerializeField]
        private string path;

        private Shapes shapes;

        private string assetName;

        private void GetPrefabNamesFromJson()
        {
            LoadAssetBundle(path);
            var jsonTextFile = Resources.Load<TextAsset>("data");
            shapes = JsonUtility.FromJson<Shapes>(jsonTextFile.text);
        }

        private void SelectRandomPrefabName()
        {
            System.Random random = new System.Random();
            assetName = shapes.prefabNames[random.Next(shapes.prefabNames.Count)];
        }

        private void LoadAssetBundle(string bundlePath)
        {
            loadedAssetBundle = AssetBundle.LoadFromFile(bundlePath);

            Debug.Log(loadedAssetBundle == null ? "Load failed" : "Load success");
        }

        public GameObject InstantiateObjectFromBundle()
        {
            GetPrefabNamesFromJson();
            SelectRandomPrefabName();
            var prefab = loadedAssetBundle.LoadAsset(assetName);

            if (prefab)
            {
                prefab = Instantiate(prefab);
            }
            else
            {
                Debug.Log("Current bundle doesn't exist: " + assetName);
            }

            return (GameObject)prefab;
        }
    }

    [System.Serializable]
    public class Shapes
    {
        public List<string> prefabNames;
    }
}