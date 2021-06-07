using TMPro;
using UnityEngine;

namespace Assets.Scripts.Views
{
    public class View : MonoBehaviour, IView
    {
        private TextMeshProUGUI counterTextMesh;

        public void Start()
        {
            try
            {
                counterTextMesh = GetComponentInChildren<TextMeshProUGUI>();
                RenderCount(0);//Reset textMeshPro
            }
            catch
            {
                Debug.Log("TextMeshPro is not exist");
            }
        }

        public void RenderCount(int count)
        {
            counterTextMesh.text = count.ToString();
        }
    }
}