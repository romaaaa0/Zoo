using UnityEngine;

namespace Assets
{
    public class RollLeftAnimation : AnimationController
    {
        protected override int numberButton { get; set; } = 2;
        public override void PlayAnimation()
        {
            base.PlayAnimation();
            if (ClickArrow.NumberPressedButton != Information.IndexCurrentArrows || Information.IsArrowOnFrame == false) return;
            animator.Play("Spin");
            Information.IsArrowOnFrame = false;
        }
    }
}
