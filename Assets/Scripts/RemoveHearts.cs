using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public class RemoveHearts
    {
        public void Remove(List<GameObject> heart)
        {
            Information.NumberHearts--;
            heart[Information.NumberHearts].SetActive(false);
        }
    }
}
