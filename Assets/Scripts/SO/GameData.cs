using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Game Data", menuName = "Data/Game data")]
public class GameData : ScriptableObject
{
    [SerializeField]
    private int observableTime;

    public int ObservableTime { get => observableTime; set => observableTime = value; }
}