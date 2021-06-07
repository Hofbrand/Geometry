using Assets.Scripts.Controllers;
using UnityEngine;

namespace Assets.Scripts.Models
{
    public class GeometryObjectModel : MonoBehaviour, IGeometryObjectModel
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
                try
                {
                    controller.OnClick();
                }
                catch
                {
                    Debug.Log("Controller issue");
                }
            }
        }
    }
}