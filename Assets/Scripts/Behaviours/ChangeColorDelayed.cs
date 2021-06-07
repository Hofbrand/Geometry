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
        private IDisposable _update;

        public override void ChangeBehaviour(Transform objTransform)
        {
            _update = Observable.Interval(TimeSpan.FromSeconds(ResourcesStorage.Data.ObservableTime)).Subscribe(x =>
            {
                try
                {
                    objTransform.gameObject.GetComponent<Renderer>().material.color = UnityEngine.Random.ColorHSV();
                }
                catch
                {
                    Debug.Log("Can't find object");
                }
            });
        }

        private void OnDestroy()
        {
            _update.Dispose();
        }
    }
}