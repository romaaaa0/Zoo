using UnityEngine;

namespace Assets
{
    public class LieDownAnimation : AnimationController
    {
        protected override int numberButton { get; set; } = 1;
        public override void PlayAnimation()
        {
            base.PlayAnimation();
            if (ClickArrow.NumberPressedButton != Information.IndexCurrentArrows || Information.IsArrowOnFrame == false) return;
            animator.Play("Twerk");
            Information.IsArrowOnFrame = false;
        }
    }
}
