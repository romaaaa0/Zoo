using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public class Main : MonoBehaviour
    {
        [SerializeField] private GameObject lostScreen;
        [SerializeField] private List<GameObject> hearts;
        [SerializeField] private AudioSource takeDamageSound;
        private float speedArrows = 1;
        private MoveArrow moveArrows;
        private LostGame lostGame;
        private int maxSpeedArrows = 10;
        private int minSpeedArrows = 1;
        private Animator animator;
        private void Awake()
        {
            Information.ResetValue();
        }
        private void Start()
        {
            animator = GameObject.FindWithTag("Player").GetComponent<Animator>();
            moveArrows = new MoveArrow();
            lostGame = new LostGame(lostScreen, hearts, animator, takeDamageSound);
            
        }
        private void Update()
        {
            if (Information.IsGameLost || !Information.IsArrowActive || Information.IsPause) return;
            speedArrows += Time.deltaTime / 4;
            speedArrows = Mathf.Clamp(speedArrows, minSpeedArrows, maxSpeedArrows);
            moveArrows.Move(speedArrows);
            lostGame.Lost();
        }
    }
}
