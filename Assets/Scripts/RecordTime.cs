using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class RecordTime : MonoBehaviour
    {
        private Text timeText;
        private float time;
        private void Start()
        {
            timeText = GetComponent<Text>();
        }
        private void Update()
        {
            if(Information.IsGameLost && time > PlayerPrefs.GetFloat("Time"))
            {
                PlayerPrefs.SetFloat("Time", time);
            }
            if (!Information.IsGameLost && !Information.IsPause)
            {
                time += Time.deltaTime;
                timeText.text = Mathf.Round(time).ToString();
            }
        }
    }
}
