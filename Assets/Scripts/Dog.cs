using UnityEngine;

namespace Assets
{
    public class Dog : MonoBehaviour, IAnimal
    {
        public int Number { get; set; } = 2;
    }
}
