using UnityEngine;

namespace Assets
{
    public class StandUpAnimation : AnimationController
    {
        protected override int numberButton { get; set; } = 0;
        public override void PlayAnimation()
        {
            base.PlayAnimation();
            if (ClickArrow.NumberPressedButton != Information.IndexCurrentArrows || Information.IsArrowOnFrame == false) return;
            animator.Play("Salsa");
            Information.IsArrowOnFrame = false;
        }
    }
}
