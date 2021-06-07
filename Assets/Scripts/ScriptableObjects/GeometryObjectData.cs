using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.SO
{
    [CreateAssetMenu(fileName = "Geometry Object Data", menuName = "Data/Geometry Objects DATA")]
    public class GeometryObjectData : ScriptableObject
    {
        [SerializeField]
        private List<ClickColorData> clicksData;

        public List<ClickColorData> ClicksData { get => clicksData; set => clicksData = value; }
    }
}