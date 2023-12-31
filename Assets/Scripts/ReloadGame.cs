using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class ReloadGame : MonoBehaviour
    {
        private Button buttonReload;
        private void Start()
        {
            buttonReload = GetComponent<Button>();
            buttonReload.onClick.AddListener(Reload);
        }
        private void Reload()
        {
            Information.IsPause = false;
            Scene.Game();
        }
    }
}
