using UnityEngine;

namespace Assets.Scripts.SO
{
    public abstract class BehaviourSO : ScriptableObject
    {
        public abstract void ChangeBehaviour(Transform objTransform);
    }
}