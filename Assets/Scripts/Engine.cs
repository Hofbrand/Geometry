using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class Engine : MonoBehaviour
    {
        [SerializeField]
        private bool objectCreated = false;

        [SerializeField]
        private LoadAssetBundles loadAssets;

        private GameObject prefab;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0) && !objectCreated)
            {
                prefab = loadAssets.InstantiateObjectFromBundle();

                if (prefab)
                {
                    objectCreated = true;
                    prefab.GetComponent<Behaviour>().BehaviourON(ResourcesStorage.Data.ObservableTime);
                }
            }
        }
    }
}