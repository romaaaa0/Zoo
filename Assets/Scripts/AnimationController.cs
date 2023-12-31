using System.Collections.Generic;
using UnityEngine;

namespace Assets
{
    public abstract class AnimationController : MonoBehaviour
    {
        [SerializeField] protected List<GameObject> heart;
        [SerializeField] protected AudioSource coinSound;
        [SerializeField] protected AudioSource failSound;
        protected Animator animator;
        protected abstract int numberButton { get; set; }
        private void Start()
        {
            animator = GameObject.FindWithTag("Player").GetComponent<Animator>();
        }
        public virtual void PlayAnimation()
        {
            ClickArrow.NumberPressedButton = numberButton;
            ClickArrow.Click(heart, coinSound, failSound, animator);
        }
    }
}
