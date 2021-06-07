using Assets.Scripts.SO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behaviour : MonoBehaviour
{
    [SerializeField]
    private List<BehaviourSO> behaviours;

    public void BehaviourON(int delay)
    {
        foreach (var item in behaviours)
        {
            item?.ChangeBehaviour(transform, delay);
        }
    }
}