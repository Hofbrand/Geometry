using Assets.Scripts.Models;
using Assets.Scripts.SO;
using System;
using UniRx;
using UnityEngine;

namespace Assets.Scripts.Behaviours
{
    [CreateAssetMenu(fileName = "Change color", menuName = "Behaviours/ Change color")]
    public class ChangeColor : BehaviourSO
    {
        private Color colorToChange;
        private IDisposable _update;

        public override void ChangeBehaviour(Transform objTransform)
        {
            _update = Observable.EveryUpdate()
                .Where(_ => IsClicked() && IsRayHitObject())
                .Subscribe(x =>
                {
                    try
                    {
                        objTransform.gameObject.GetComponent<Renderer>().material.color = colorToChange;
                    }
                    catch (NullReferenceException)
                    {
                        Debug.Log("Can't find object");
                    }
                });
        }

        private bool IsClicked()
        {
            return Input.GetMouseButtonDown(0);
        }

        private bool IsRayHitObject()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, 100.0f))
            {
                GeometryObjectModel model = hit.transform.GetComponent<GeometryObjectModel>();
                model.ClickCount += 1;
                foreach (var item in ResourcesStorage.ClickColorsData.ClicksData)
                {
                    if (hit.transform.CompareTag(item.ObjectType) && model.ClickCount >= item.MinClicksCount && model.ClickCount <= item.MaxClicksCount)
                    {
                        colorToChange = item.Color;
                        return true;
                    }
                }
            }
            return false;
        }

        private void OnDestroy()
        {
            _update.Dispose();
        }
    }
}