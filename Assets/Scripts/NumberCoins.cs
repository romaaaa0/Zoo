using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class NumberCoins : MonoBehaviour
    {
        [SerializeField] private Text numberCoinsText;
        private int numberCoins;
        private void Update()
        {
            if(numberCoins != PlayerPrefs.GetInt("Coins"))
            {
                numberCoinsText.text = PlayerPrefs.GetInt("Coins").ToString();
                numberCoins = PlayerPrefs.GetInt("Coins");
            }
        }
    }
}
