using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class BuyButton : MonoBehaviour
    {
        [SerializeField] private int price;
        [SerializeField] private Text priceText;
        [SerializeField] private Button buyButton;
        [SerializeField] private Button selectButton;

        [SerializeField] private GameObject priceObject;
        [Space] [SerializeField] private UINotEnoughMoney _uiNotEnoughMoney;

        private void Start()
        {
            priceText.text = price.ToString();
        }

        private void Update()
        {
            buyButton.onClick.RemoveAllListeners();
            buyButton.onClick.AddListener(Buy);
        }

        private void Buy()
        {
            if (PlayerPrefs.GetInt("Coins") >= price)
            {
                PlayerPrefs.SetInt(gameObject.name, 1);
                buyButton.gameObject.SetActive(false);
                selectButton.gameObject.SetActive(true);
                var currentCoins = PlayerPrefs.GetInt("Coins");
                var coins = currentCoins - price;
                PlayerPrefs.SetInt("Coins", coins);
                priceObject.SetActive(false);
            }
            else
            {
                _uiNotEnoughMoney.Show(price - PlayerPrefs.GetInt("Coins"));
            }
        }
    }
}