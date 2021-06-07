using Assets.Scripts.SO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class ResourcesStorage : MonoBehaviour
    {
        public static GameData Data;
        public static GeometryObjectData ClickColorsData;

        private void Awake()
        {
            Data = Resources.Load<GameData>("Game Data");
            ClickColorsData = Resources.Load<GeometryObjectData>("Geometry object Data");
        }
    }
}