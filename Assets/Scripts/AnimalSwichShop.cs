using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public class AnimalSwichShop : MonoBehaviour
    {
        [SerializeField] private List<GameObject> animals = new List<GameObject>();
        [SerializeField] private GameObject buttonSelect;
        [SerializeField] private GameObject buttonBuy;
        [SerializeField] private GameObject price;
        public int indexAnimal;
        private void Start()
        {
            if (PlayerPrefs.GetInt("Tiger") == 0)
            {
                PlayerPrefs.SetInt("Tiger", 1);
            }
            if(PlayerPrefs.GetInt("Tiger") == 1)
            {
                buttonBuy.SetActive(false);
                buttonSelect.SetActive(true);
            }
        }
        private void IsAnimalBought()
        {
            if (PlayerPrefs.GetInt(animals[indexAnimal].name) == 1)
            {
                buttonBuy.SetActive(false);
                buttonSelect.SetActive(true);
                price.SetActive(false);
            }
            else
            {
                buttonBuy.SetActive(true);
                buttonSelect.SetActive(false);
                price.SetActive(true);
            }
        }
        public void ArrowRight()
        {

            if (indexAnimal == animals.Count - 1)
            {
                animals[0].SetActive(true);
                animals[indexAnimal].SetActive(false);
                indexAnimal = 0;
                IsAnimalBought();
                return;
            }
            animals[indexAnimal].SetActive(false);
            animals[indexAnimal + 1].SetActive(true);
            indexAnimal++;
            IsAnimalBought();
        }
        public void ArrowLeft()
        {
            if (indexAnimal == 0)
            {
                animals[animals.Count - 1].SetActive(true);
                animals[indexAnimal].SetActive(false);
                indexAnimal = animals.Count - 1;
                IsAnimalBought();
                return;
            }
            animals[indexAnimal].SetActive(false);
            animals[indexAnimal - 1].SetActive(true);
            indexAnimal--;
            IsAnimalBought();
        }
    }
}
