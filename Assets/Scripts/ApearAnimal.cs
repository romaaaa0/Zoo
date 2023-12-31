using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public class ApearAnimal : MonoBehaviour
    {
        [SerializeField] private List<GameObject> animals;
        private void Awake()
        {
            animals[PlayerPrefs.GetInt("Animal")].SetActive(true);
        }
    }
}
