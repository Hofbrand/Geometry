using Assets.Scripts.MVC;
using Assets.Scripts.SO;
using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Assets.Scripts.Behaviours
{
    [CreateAssetMenu(fileName = "Change color", menuName = "Behaviours/ Change color")]
    public class ChangeColor : BehaviourSO
    {
        private Color colorToChange;

        public override void ChangeBehaviour(Transform objTransform, float delay)
        {
            _update = Observable.EveryUpdate()
                .Where(_ => OnClick())
                .Subscribe(x =>
                {
                    objTransform.gameObject.GetComponent<Renderer>().material.color = colorToChange;
                });
        }

        private bool OnClick()
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 100.0f))
                {
                    GeometryObjectModel model = hit.transform.GetComponent<GeometryObjectModel>();
                    model.ClickCount += 1;
                    foreach (var item in ResourcesStorage.ClickColorsData.ClicksData)
                    {
                        if (hit.transform.tag.Equals(item.ObjectType) && model.ClickCount >= item.MinClicksCount && model.ClickCount <= item.MaxClicksCount)
                        {
                            colorToChange = item.color;
                            return true;
                        }
                    }
                }
                return false;
            }
            return false;
        }

        private IDisposable _update;

        private void OnDestroy()
        {
            _update.Dispose();
        }
    }
}