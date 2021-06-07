using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.MVC
{
    public class Controller : MonoBehaviour, IController
    {
        private IView view;
        private IModel model;

        private void Start()
        {
            view = GetComponent<View>();
            model = GetComponent<GeometryObjectModel>();
        }

        public void OnClick()
        {
            view.RenderCount(model.ClickCount);
        }
    }
}