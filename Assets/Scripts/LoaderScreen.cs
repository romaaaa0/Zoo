using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class LoaderScreen : MonoBehaviour
    {
        [SerializeField] private Text percentText;
        private Slider slider;
        private void Start()
        {
            slider = GetComponent<Slider>();
        }
        private void Update()
        {
            slider.value += Time.deltaTime / 2.5f;
            percentText.text = Mathf.Round(slider.value * 100).ToString() + "%";
            if (slider.value >= 1)
                Scene.Menu();
        }
    }
}
