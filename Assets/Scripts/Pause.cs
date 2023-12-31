using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class Pause : MonoBehaviour
    {
        [SerializeField] private GameObject pauseScreen;
        private Button buttonPause;
        private void Start()
        {
            buttonPause = GetComponent<Button>();
            buttonPause.onClick.AddListener(PauseGame);
        }
        private void PauseGame()
        {
            pauseScreen.SetActive(true);
            Information.IsPause = true;
        }
    }
}
