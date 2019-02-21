using System;

namespace OverloadingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t\t\tAREA CALCULATOR");
            Console.ForegroundColor = ConsoleColor.White;
           
            Console.Write("What area do you wanna calulate?\n1. Triangle\n2. Square\n3. Rectangle\n INPUT: ");
            int areachoice = Convert.ToInt32(Console.ReadLine());
            if (areachoice == 1)
            {
                Console.Write("Enter the base of the triangle: ");
                double tribase = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nEnter the height of the triangle: ");
                double height = Convert.ToDouble(Console.ReadLine());
                var answer = Area(tribase,height);
                Console.WriteLine("{0}", answer);
            }
            else if (areachoice == 2)
            {
                Console.Write("Enter the Breadth of the square: ");
                int length = Convert.ToInt32(Console.ReadLine());
                int answer = Area(length);
                Console.WriteLine("{0}", answer);
            }
            else if(areachoice == 3)
            {
                Console.Write("-");
                int length = Convert.ToInt32(Console.ReadLine());
                Console.Write("-");
                int width = Convert.ToInt32(Console.ReadLine());
                int answer = Area(length,width);
                Console.WriteLine("{0}",answer);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("YOU'VE ENTERED A WRONG TYPE OF INPUT!!!");
            }

            Console.ReadKey();
        }
        static int Area(int length, int width)
        {
            int calculated = length * width;
            return calculated;
        }

        static int Area(int breadth)
        {
            int calculated = breadth * breadth;
            return calculated;
        }
        static double Area(double base1,double height)
        {
            double calculated = (0.5*base1)*(height);
            return calculated;
        }

         
    }
}
