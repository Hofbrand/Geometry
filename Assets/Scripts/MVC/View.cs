using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Assets.Scripts.MVC
{
    public class View : MonoBehaviour, IView
    {
        private TextMeshProUGUI counterTextMesh;

        public void Start()
        {
            counterTextMesh = GetComponentInChildren<TextMeshProUGUI>();
            RenderCount(0);
        }

        public void RenderCount(int count)
        {
            counterTextMesh.text = count.ToString();
        }
    }
}