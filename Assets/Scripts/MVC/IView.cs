using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.MVC
{
    public interface IView
    {
        void RenderCount(int count);
    }
}