using Assets.Scripts.SO;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Behaviours
{
    public class Behaviour : MonoBehaviour
    {
        [SerializeField]
        private List<BehaviourSO> behaviours;

        public void SubscribeAllBehaviours()
        {
            foreach (var item in behaviours)
            {
                item?.ChangeBehaviour(transform);
            }
        }
    }
}