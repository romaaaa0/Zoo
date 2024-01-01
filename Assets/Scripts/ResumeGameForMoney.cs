using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class ResumeGameForMoney : MonoBehaviour
    {
        [SerializeField] private GameObject lostScreen;
        [SerializeField] private List<GameObject> heards = new List<GameObject>();
        [Space] [SerializeField] private UINotEnoughMoney _uiNotEnoughMoney;
        private Button buttonResume;

        private void Start()
        {
            buttonResume = GetComponent<Button>();
            buttonResume.onClick.AddListener(ResumeForMoney);
        }

        private void ResumeForMoney()
        {
            if (PlayerPrefs.GetInt("Coins") >= 200)
            {
                Information.IsGameLost = false;
                lostScreen.SetActive(false);
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - 200);
                Information.NumberHearts = 3;
                foreach (var heard in heards)
                    heard.SetActive(true);
            }
            else
            {
                _uiNotEnoughMoney.Show(200 - PlayerPrefs.GetInt("Coins"));
            }
        }
    }
}