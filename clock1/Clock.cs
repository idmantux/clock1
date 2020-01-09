using System;
using System.Collections.Generic;
using System.Text;

namespace clock1
{
    class Clock
    {
        private int hours;
        private int minutes;

        public void SetTime(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
        }
        public double GetAngle()
        {
            double hposition;
            double mposition;
            double angle;
            hposition = (Convert.ToDouble(hours) * 360) / 12 + (Convert.ToDouble(minutes) * 360) / (12 * 60);
            mposition = (minutes * 360) / 60;
            angle = Math.Abs(hposition - mposition);
            if (angle > 180)
                angle = 360 - angle;
            return angle;

        }
    }
}
