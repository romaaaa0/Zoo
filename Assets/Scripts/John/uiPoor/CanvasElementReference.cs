using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Codes.John.uiPoor
{
    public class CanvasElementReference : MonoBehaviour
    {
        private Transform textTransform;

        public void ShowAndScale()
        {
            CanvasHelper.FadeCanvasGroup(gameObject, true);
            ScaleElement();
        }

        private void ScaleElement()
        {
            textTransform.localScale = new Vector3(1, 0.8f, 1); ;
        }

        private void Awake()
        {
            textTransform = GetComponentInChildren<TMP_Text>().transform;
            GetComponentInChildren<Button>().onClick.AddListener(DisableCanvas);
        }

        private void DisableCanvas()
        {
            CanvasHelper.FadeCanvasGroup(gameObject, false);
            FindObjectOfType<CanvasHelper>().ActivateNextCanvasElement();
        }
    }
}

