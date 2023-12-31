using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class ResumeGame : MonoBehaviour
    {
        [SerializeField] private GameObject pauseScreen;
        private Button buttonResume;
        private void Start()
        {
            buttonResume = GetComponent<Button>();
            buttonResume.onClick.AddListener(Resume);
        }
        private void Resume()
        {
            Information.IsPause = false;
            pauseScreen.SetActive(false);
        }
    }
}
