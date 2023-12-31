using System;
using UnityEngine;

namespace Assets
{
    public static class Information
    {
        public static int NumberHearts { get; set; } = 3;
        public static int IndexCurrentArrows { get; set; }
        public static GameObject Arrow { get; set; }
        public static bool IsArrowActive { get; set; }
        public static bool IsGameLost { get; set; }
        public static bool IsPause { get; set; }
        public static bool IsArrowOnFrame { get; set; }
        public static void ResetValue()
        {
            NumberHearts = 3;
            IsArrowActive = false;
            IsGameLost = false;
            IsPause = false;
            Arrow = null;
        }
    }
}
