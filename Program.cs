using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            

            bool loop = true;
            while(loop == true)
            {
                Console.WriteLine("Learn your squares and cubes!");
                Console.WriteLine("Enter an integer:");
                int number1 = int.Parse(Console.ReadLine());           


                for(int i = 0; i <= number1; i++)
                {
                    Console.WriteLine(i);
                    
                }

                Console.WriteLine("The square thing should happen here");

                for(int i = 0; i <= number1; i++)
                {
                    
                    Console.WriteLine(SquareThis(i));
                }

                Console.WriteLine("The cube thing should happen here");

                for(int i = 0; i <= number1; i++)
                {
                    Console.WriteLine(CubeThis(i));
                }

                Console.WriteLine("Do you want to continue? Y/N");
                string input = Console.ReadLine();

                if (input == "y" || input == "Y")
                {
                    loop = true;
                }
                if (input == "n" || input == "N")
                {
                    loop = false;
                }


            }
         
           

        }

       

        public static int SquareThis(int x)
        {
            int squareAnswer = x * x;
            return squareAnswer;
        }
        public static int CubeThis(int x)
        {
            int cubeAnswer = x * x * x;
            return cubeAnswer;
        }
    }
}
