using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Geometry Object Data", menuName = "Data/Geometry Objects DATA")]
public class GeometryObjectData : ScriptableObject
{
    [SerializeField]
    public List<ClickColorData> ClicksData;
}