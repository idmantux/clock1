using System;
using System.Collections.Generic;
using System.Text;

namespace clock1
{
    class IOoperation
    {
        public IOoperation()
        {
            Init();
        }
        public void Init()
        {
            int hours;
            int minutes;
            try
            {
                Console.WriteLine("Enter Hours");
                hours = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter minutes");
                minutes = Convert.ToInt32(Console.ReadLine());
                if (hours > 12 || hours < 1 || minutes > 60 || minutes < 0)
                {
                    Console.WriteLine("Hours must be in range from 1 to 12, minutes from 0 to 60!");
                    System.Threading.Thread.Sleep(2000);
                    Console.Clear();
                    Init();
                }
                Clock clock = new Clock();
                clock.SetTime(hours, minutes);
                Console.WriteLine("The Angle is: " + clock.GetAngle());
            }
            catch (FormatException)
            {
                Console.WriteLine("Hours and minutes must be in number format!");
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                Init();

            }
        }
    }
}
