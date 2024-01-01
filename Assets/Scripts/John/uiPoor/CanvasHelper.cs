using System.Collections.Generic;
using UnityEngine;

namespace Codes.John.uiPoor
{
    public class CanvasHelper : MonoBehaviour
    {
        private bool isSequenceCompleted;
        private int currentIndex;
        private int totalElements;

        [SerializeField] private List<CanvasElement> canvasElements;

        public void ActivateNextCanvasElement()
        {
            if (currentIndex < totalElements)
            {
                canvasElements[currentIndex].Activate();
                currentIndex++;
            }
            else
            {
                if (isSequenceCompleted)
                    return;

                FindObjectOfType<UIManager>().CompleteSequence();
                isSequenceCompleted = true;
            }
        }

        public static void FadeCanvasGroup(GameObject canvasObject, bool fadeIn)
        {
            canvasObject.SetActive(true);
            CanvasGroup canvasGroup = canvasObject.GetComponent<CanvasGroup>();
            float targetAlpha = fadeIn ? 1f : 0f;
            canvasObject.SetActive(false);
        }
    }

    [System.Serializable]
    public class CanvasElement
    {
        [SerializeField] private CanvasElementReference canvasElementReference;

        public void Activate()
        {
            canvasElementReference.ShowAndScale();
        }
    }
}