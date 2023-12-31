using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class GoToMenu : MonoBehaviour
    {
        private Button buttonGoToMenu;
        private void Start()
        {
            buttonGoToMenu = GetComponent<Button>();
            buttonGoToMenu.onClick.AddListener(GoToMenuButton);
        }
        private void GoToMenuButton()
        {
            Information.IsPause = false;
            Scene.Menu();
        }
    }
}
