using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public static class ClickArrow
    {
        public static int NumberPressedButton { get; set; }
        private static int remuneration = 10;
        public static void Click(List<GameObject> heart, AudioSource coinSound, AudioSource failSound, Animator playerAnimator)
        {
            if (Information.IsPause) return;
            if (Information.IsArrowOnFrame && NumberPressedButton == Information.IndexCurrentArrows)
            {
                new RemoveArrows().Remove(Information.Arrow);
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + remuneration);
                coinSound.Play();
            }
            else
            {
                new RemoveHearts().Remove(heart);
                failSound.Play();
                playerAnimator.Play("TakeDamage");
            }
        }
    }
}
