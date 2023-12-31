using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public class LostGame 
    {
        private GameObject lostScreen;
        private List<GameObject> hearts;
        private bool canFunctionWork = true;
        private float timer;
        private float startTime = 1;
        private Animator playerAnimator;
        private AudioSource takeDamageSound;
        public LostGame(GameObject lostScreen, List<GameObject> hearts, Animator playerAnimator, AudioSource takeDamageSound)
        {
            this.lostScreen = lostScreen;
            this.hearts = hearts;
            timer = startTime;
            this.playerAnimator = playerAnimator;
            this.takeDamageSound = takeDamageSound;
        }
        public void Lost()
        {
            if(Information.NumberHearts <= 0)
            {
                lostScreen.SetActive(true);
                Information.IsGameLost = true;
            }
            if (canFunctionWork && Information.Arrow.transform.position.x <= -5)
            {
                new RemoveHearts().Remove(hearts);
                new RemoveArrows().Remove(Information.Arrow);
                playerAnimator.Play("TakeDamage");
                takeDamageSound.Play();
                canFunctionWork = false;
            }
            if (!canFunctionWork)
            {
                timer -= Time.deltaTime;
                if(timer <= 0)
                {
                    canFunctionWork = true;
                    timer = startTime;
                }
            }
        }
    }
}
