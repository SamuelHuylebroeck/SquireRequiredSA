using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Configuration
{
    public static class SpeedController
    {
        private static float speedScale = 0.1f;
        private static float turnSpeedScale = 2f;

        public static float GetSpeed(float normalizedSpeed)
        {
            return speedScale * normalizedSpeed;
        }

        public static float GetTurnSpeed(float normalizedTurningSpeed)
        {
            return turnSpeedScale * normalizedTurningSpeed;
        }

    }
}
