using Assets.Scripts.Models;
using Assets.Scripts.Views;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    public class Controller : MonoBehaviour, IController
    {
        private IView view;
        private IGeometryObjectModel model;

        private void Start()
        {
            view = GetComponent<View>();
            model = GetComponent<GeometryObjectModel>();
        }

        public void OnClick()
        {
            try
            {
                view.RenderCount(model.ClickCount);
            }
            catch
            {
                Debug.Log("Check view or model");
            }
        }
    }
}