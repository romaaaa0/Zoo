using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public class StartTutorial : MonoBehaviour
    {
        [SerializeField] private List<GameObject> tutorials = new List<GameObject>();
        private void Awake()
        {
            StartCoroutine(ShowTutorial());
        }
        public IEnumerator ShowTutorial()
        {
            if (PlayerPrefs.GetInt("Tutorial") == 0)
            {
                Information.IsPause = true;
                tutorials[0].SetActive(true);
                yield return new WaitForSeconds(3);
                tutorials[0].SetActive(false);
                tutorials[1].SetActive(true);
                yield return new WaitForSeconds(3);
                tutorials[1].SetActive(false);
                tutorials[2].SetActive(true);
                yield return new WaitForSeconds(3);
                tutorials[2].SetActive(false);
                tutorials[3].SetActive(true);
                yield return new WaitForSeconds(3);
                tutorials[3].SetActive(false);
                Information.IsPause = false;
                PlayerPrefs.SetInt("Tutorial", 1);
            }
        }
    }
}
