using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class RecordTimeMenu : MonoBehaviour
    {
        private Text timeText;
        private void Start()
        {
            timeText = GetComponent<Text>();
            timeText.text = Mathf.Round(PlayerPrefs.GetFloat("Time")).ToString();
        }
    }
}
