using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairingTheTiles
{
    class RepairingTheTiles
    {
        static void Main(string[] args)
        {

            int sideLenghtPlayground = int.Parse(Console.ReadLine());

            double tileWidth = double.Parse(Console.ReadLine());
            double tileLenght =double.Parse(Console.ReadLine());

            int benchWidth = int.Parse(Console.ReadLine());
            int benchLenght = int.Parse(Console.ReadLine());


            int wholePlayground = sideLenghtPlayground * sideLenghtPlayground;
            int playgoundNobench = wholePlayground - (benchWidth * benchLenght);
            double wholeTile = tileLenght * tileWidth;
            double neededTile = playgoundNobench / wholeTile;
            double neededTime = neededTile * 0.2;

            Console.WriteLine(neededTile);
            Console.WriteLine(neededTime);


        }
    }
}
