using Assets.Scripts.SO;
using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Assets.Scripts.Behaviours
{
    [CreateAssetMenu(fileName = "Change color delayed", menuName = "Behaviours/ Change color with delay")]
    public class ChangeColorDelayed : BehaviourSO
    {
        public override void ChangeBehaviour(Transform objTransform, float delay)
        {
            _update = Observable.Interval(TimeSpan.FromSeconds(delay)).Subscribe(x =>
            {
                objTransform.gameObject.GetComponent<Renderer>().material.color = UnityEngine.Random.ColorHSV();
            });
        }

        private IDisposable _update;

        private void OnDestroy()
        {
            _update.Dispose();
        }
    }
}