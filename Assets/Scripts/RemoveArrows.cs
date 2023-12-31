using UnityEngine;

namespace Assets
{
    public class RemoveArrows
    {
        public void Remove(GameObject arrow)
        {
            Information.IsArrowActive = false;
            arrow.SetActive(false);
        }
    }
}
