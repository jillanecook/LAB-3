using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    class Program
    {
        static void Main(string[] args)
        {
            do

            {
                int S, C, N;

                Console.WriteLine("Learn your squares and cubes!");
                Console.WriteLine("Enter an Integer: ");
                N = int.Parse(Console.ReadLine());
                S = N * N;
                C = N * N * N;

                Console.WriteLine(S + " = squared");

                Console.WriteLine(C + " = cubed");
            }
            while (Continue() == true);

        }
        public static Boolean Continue()
            {
                Boolean run;
                Console.WriteLine("Continue? Y/N");
                String answer = Console.ReadLine();

            if ((answer == "Y") || (answer == "y"))
            {
                run = true;
            }
            else if ((answer == "N") || (answer == "n"))
            {
                run = false;
                Console.WriteLine("Good Bye!");
            }
            else
            {
                Console.WriteLine("Does not compute!");
                run = Continue();

            }
                return run;
                }
            
    }
}
