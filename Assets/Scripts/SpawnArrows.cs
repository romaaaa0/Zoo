using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public class SpawnArrows : MonoBehaviour
    {
        public List<GameObject> arrows = new List<GameObject>();
        private void Update()
        {
            if (!Information.IsArrowActive)
            {
                Information.IndexCurrentArrows = Random.Range(0, 4);
                var arrow = arrows[Information.IndexCurrentArrows];
                var positionArrow = arrow.transform.position;
                arrow.transform.position = new Vector3(5, positionArrow.y, positionArrow.z);
                arrow.SetActive(true);
                Information.Arrow = arrow;
                Information.IsArrowActive = true;
            }
        }
    }
}
