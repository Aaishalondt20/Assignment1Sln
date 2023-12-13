using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class MilkSong;
    internal class Lyrics
    {

        public static string Words()
        {

            for (int MilkNumber = 99; MilkNumber > 0; MilkNumber--)

            {
                if (MilkNumber > 1)
                {
                    Console.WriteLine($"{MilkNumber}, bottles of beer on the wall, {MilkNumber}, bottles of beer");

                    if (MilkNumber - 1 == 1)
                    {
                        Console.WriteLine($"Take one pass it around, {MilkNumber}, bottle of beer on the wall.");


                    }

                    else
                    {
                        Console.WriteLine($"Take one pass it around, {MilkNumber}, bottles of beer on the wall.");
                    }

                }

                else if (MilkNumber == 1)
                {
                    Console.WriteLine($"{MilkNumber}, bottle of beer on the wall,{MilkNumber},bottle of beer");

                }
            }
            return "";
        }


    }
}


