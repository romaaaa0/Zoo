using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class CloseTutorial : MonoBehaviour
    {
        [SerializeField] private GameObject tutorial;
        private void Start()
        {
            var button = GetComponent<Button>();
            button.onClick.AddListener(Close);
        }
        public void Close()
        {
            tutorial.SetActive(false);
        }
    }
}
