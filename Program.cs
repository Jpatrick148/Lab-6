using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Please enter the amount of sides on the pair of dice");
                int side = int.Parse(Console.ReadLine());
                Console.WriteLine("Ready to roll? Hit enter!");
                Console.ReadLine();

                Console.WriteLine(Dice(side));
                Console.WriteLine(Dice(side));
            }
            while (Continue()==true);

        }
        public static readonly Random rnd = new Random();
        public static int Dice(int i)
        {
            lock (rnd)
            {
                return rnd.Next(1,i+1);
            }              
        }

        public static bool Continue()
        {
         Console.WriteLine("Again? {Y/N}");
            string input = Console.ReadLine().ToLower();
            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else Console.WriteLine("Please Try Again.");
            return Continue();
        }
    }

    class RollMsg
    {
        
    }
}
