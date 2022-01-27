using System;

namespace ReizTech
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Read input values and throw exceptions if the values are incorrect
                Console.WriteLine("INPUT");
                Console.WriteLine("Please input the hour value (must be integer [0-23]):");
                int hour = Convert.ToInt32(Console.ReadLine());
                if (hour < 0 || hour > 23)
                {
                    throw new FormatException();
                }
                Console.WriteLine("Please input the minute value (must be integer [0-59]):");
                int minutes = Convert.ToInt32(Console.ReadLine());
                if (minutes < 0 || minutes > 59)
                {
                    throw new FormatException();
                }

                // Create new time object
                Time time = new Time(hour, minutes);

                // Show inital values
                Console.WriteLine();
                Console.WriteLine("OUTPUT");
                Console.WriteLine("Hour: {0} Minutes: {1}", time.Hour, time.Minutes);

                // Run methods to find or set values
                time.CalculateMinuteAngle();
                time.CalculateHourAngle();
                double lesserAngle = time.CalculateLesserAngle();

                // Show calculated values
                Console.WriteLine("Hour angle: {0} Minute angle: {1}", time.HourAngle, time.MinuteAngle);
                Console.WriteLine("Lesser angle: {0}", lesserAngle);
            }
            // Exception management
            catch (OverflowException overflowEx)
            {
                Console.WriteLine("The entered value created an overflow.");
                Console.WriteLine("Details: {0}", overflowEx);
                return;
            }
            catch (FormatException formatEx)
            {
                Console.WriteLine("The input format is incorrect.");
                Console.WriteLine("For the hour value: enter an integer value between 0 and 23;");
                Console.WriteLine("For the minute value: enter an integer value between 0 and 59;");
                Console.WriteLine("Details: {0}", formatEx);
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("System error.");
                Console.WriteLine("Details: {0}", ex);
                return;
            }
        }
    }
}
