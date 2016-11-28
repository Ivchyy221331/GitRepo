using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sleepingTom
{
    class SleepingTom
    {
        static void Main(string[] args)
        {

            int sleepDays = int.Parse(Console.ReadLine());
            int sleepDaysPlay = sleepDays * 127;

            int workDays = 365 - sleepDays;
            int workDaysPlay = workDays * 63;

            int playDaysSum = workDaysPlay + sleepDaysPlay;
            int playDaysDiff = 30000 - playDaysSum;
            double playDaysDiffInHours = Math.Abs(playDaysDiff / 60);

            double playDaysDiffInMinutes = Math.Abs(playDaysDiff % 60);


            if (30000 > playDaysSum)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", playDaysDiffInHours, playDaysDiffInMinutes);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", playDaysDiffInHours, playDaysDiffInMinutes);
            }
            

        }
    }
}
