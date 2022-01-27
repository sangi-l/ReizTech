using System;

namespace ReizTech
{
    public class Time
    {
        public int Hour { get; set; }
        public int Minutes { get; set; }
        public double HourAngle { get; set; }
        public double MinuteAngle { get; set; }
        public Time(int hour, int minutes)
        {
            Hour = hour;
            Minutes = minutes;
        }
        public void CalculateHourAngle()
        {
            HourAngle = (Hour % 12) * 30 + MinuteAngle / 360 * 30;
        }
        public void CalculateMinuteAngle()
        {
            MinuteAngle = Minutes * 6;
        }
        public double CalculateLesserAngle()
        {
            var c1 = Math.Abs(HourAngle - MinuteAngle);
            var c2 = 360 - c1;

            if (c1 < c2)
            {
                return c1;
            }
            else
            {
                return c2;
            }
        }
    }
}
