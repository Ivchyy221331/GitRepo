using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {


            int lillyAge = int.Parse(Console.ReadLine());
            double machinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            double birthdaysum = 0;
            double birthdaysumsum = 0;

            int toys = 0;
            int totalToys = 0;

            double totalPrice = 0;

            for (int year = 0; year < lillyAge; year++)
            {
                if (year % 2 == 0)
                {
                    birthdaysum = birthdaysum + 10;
                    birthdaysumsum += birthdaysum;
                    birthdaysumsum -= 1;

                }
                else
                {
                    birthdaysum += 0;
                    toys += 1;
                    totalToys = toys * toyPrice;
                }
            }

            totalPrice = birthdaysumsum + totalToys;

            if (totalPrice >= machinePrice)
            {
                Console.WriteLine("Yes! {0:f2}", Math.Abs(machinePrice - totalPrice));
            }
            else
            {
                Console.WriteLine("No! {0:f2}", Math.Abs(machinePrice - totalPrice));
            }
            
        }
    }
}
