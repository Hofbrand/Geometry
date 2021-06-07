using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Click color data", menuName = "click color data")]
public class ClickColorData : ScriptableObject
{
    [SerializeField]
    public int MinClicksCount;

    [SerializeField]
    public int MaxClicksCount;

    [SerializeField]
    public Color color;

    [SerializeField]
    public string ObjectType;
}