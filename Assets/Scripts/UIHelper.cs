using System;
using UnityEngine;

namespace Assets
{
    public class UIHelper : MonoBehaviour
    {
        public void OnDisableObj()
        {
            gameObject.SetActive(false);
        }
    }
}