using UnityEngine;

namespace Assets
{
    public class CollisionFrame : MonoBehaviour
    {

        private void OnTriggerEnter(Collider other)
        {
            Information.IsArrowOnFrame = true;
        }
        private void OnTriggerExit(Collider other)
        {
            Information.IsArrowOnFrame = false;
        }
    }
}
