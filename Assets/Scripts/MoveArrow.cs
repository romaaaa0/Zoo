using UnityEngine;

namespace Assets
{
    public class MoveArrow
    {
        public void Move(float speed)
        {
            Information.Arrow.transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}
