using UnityEngine;
using UnityEngine.UI;

namespace Assets
{
    public class SelectButton : MonoBehaviour
    {
        [SerializeField] private Button selectButton;
        private void Update()
        {
            selectButton.onClick.RemoveAllListeners();
            selectButton.onClick.AddListener(Select);
        }
        private void Select()
        {
            var numberAnimal = GetComponent<IAnimal>().Number;
            print(gameObject.name);
            print(numberAnimal);
            PlayerPrefs.SetInt("Animal", numberAnimal);
            Scene.Menu();
        }
    }
}
