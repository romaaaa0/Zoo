using UnityEngine;

namespace Assets
{
    public class RollRightAnimation : AnimationController
    {
        protected override int numberButton { get; set; } = 3;
        public override void PlayAnimation()
        {
            base.PlayAnimation();
            if (ClickArrow.NumberPressedButton != Information.IndexCurrentArrows || Information.IsArrowOnFrame == false) return;
            animator.Play("HipHop");
            Information.IsArrowOnFrame = false;
        }
    }
}
