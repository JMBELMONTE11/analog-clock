using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalogClock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the hours on the clock (0-11): ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the minutes on the clock (0-59): ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            double hourAngle = 0.5 * (60 * hours + minutes);
            double minuteAngle = 6 * minutes;

            double angle = Math.Abs(hourAngle - minuteAngle);

            if (angle > 180)
            {
                angle = 360 - angle;
            }

            Console.WriteLine("The lesser angle between the hour and minute hands is: " + angle + "degrees");

            Console.ReadLine();

        }
    }
}
