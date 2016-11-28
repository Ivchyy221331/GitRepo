using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetweenNumbers
{
    class BetweenNumbers
    {
        static void Main(string[] args)
        {

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            string operators = Console.ReadLine();
            double sum;

            if (operators == "+")
            {
                sum = firstNumber + secondNumber;
                if (sum % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", firstNumber, operators, secondNumber, sum);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", firstNumber, operators, secondNumber, sum);
                }
            }
            else if (operators == "-")
            {
                sum = firstNumber - secondNumber;
                if (sum % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", firstNumber, operators, secondNumber, sum);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", firstNumber, operators, secondNumber, sum);
                }
            }
            else if (operators == "*")
            {
                sum = firstNumber * secondNumber;
                if (sum % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", firstNumber, operators, secondNumber, sum);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", firstNumber, operators, secondNumber, sum);
                }
            }
            else if (operators == "/" && secondNumber != 0)
            {
                sum = (double)firstNumber / secondNumber;
                if (sum % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", firstNumber, operators, secondNumber, sum);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3}", firstNumber, operators, secondNumber, sum);
                }
            }
            else if (operators == "%" && secondNumber != 0)
            {
                sum = (double)firstNumber % secondNumber;
                if (sum % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", firstNumber, operators, secondNumber, sum);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3}", firstNumber, operators, secondNumber, sum);
                }
            }
            else if (secondNumber == 0 && operators == "/")
            {
                Console.WriteLine("Cannot divide {0} by zero", firstNumber);
            }
            else if (secondNumber == 0 && operators == "%")
            {
                Console.WriteLine("Cannot divide {0} by zero", firstNumber);
            }

        }
    }
}
