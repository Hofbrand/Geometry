using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.MVC
{
    public class GeometryObjectModel : MonoBehaviour, IModel
    {
        private Color CubeColor;
        private int clickCount = 0;
        private IController controller;

        private void Start()
        {
            controller = GetComponent<Controller>();
        }

        public int ClickCount
        {
            get { return clickCount; }
            set
            {
                clickCount = value;
                controller.OnClick();
            }
        }

        // Start is called before the first frame update
    }
}