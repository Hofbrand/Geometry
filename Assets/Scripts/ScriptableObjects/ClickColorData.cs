using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.SO
{
    [CreateAssetMenu(fileName = "Click color data", menuName = "click color data")]
    public class ClickColorData : ScriptableObject
    {
        [SerializeField]
        private int minClicksCount;

        [SerializeField]
        private int maxClicksCount;

        [SerializeField]
        private Color color;

        [SerializeField]
        private string objectType;

        public int MinClicksCount { get => minClicksCount; set => minClicksCount = value; }
        public int MaxClicksCount { get => maxClicksCount; set => maxClicksCount = value; }
        public Color Color { get => color; set => color = value; }
        public string ObjectType { get => objectType; set => objectType = value; }
    }
}