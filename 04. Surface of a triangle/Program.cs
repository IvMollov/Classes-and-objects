using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Surface_of_a_triangle
{
    class Program
    {
        public static void Main()
        {

            Console.WriteLine("Choose number \"1\" to find the surface of a triangle by given " +
                            "side and an altitude to it." +
            "\nChoose number \"2\" to find the surface of a triangle by given three sides." +
            "\nChoose number \"3\" to find the surface of a triangle by given two sides and an angle between them.");

            Console.Write("Your choice is: ");
            int choose = int.Parse(Console.ReadLine());
            while (choose < 1 || choose > 3)
            {
                Console.Write("Choose 1, 2 or 3: ");
                choose = int.Parse(Console.ReadLine());
            }

            switch (choose)
            {
                case 1:
                    double surFace = FindSurface();
                    Console.WriteLine("Surface of triangle is: {0:F2}", surFace);
                    break;

                case 2:
                    double surface = AllThreeSides();
                    Console.WriteLine("Surface of triangle is: {0:F2}", surface);
                    break;

                case 3:
                    double surfaceAngle = SidesAndAngle();
                    Console.WriteLine("Surface of triangle is: {0:F2}", surfaceAngle);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
            Console.ReadLine();
        }

        public static double FindSurface()
        {
            Console.WriteLine("Your choice is surface of a triangle by given side and an altitude to it.");
            Console.Write("Enter size of side: ");
            double side = double.Parse(Console.ReadLine());
            Console.Write("Enter an altitude to it: ");
            double altitude = double.Parse(Console.ReadLine());
            double surface = (double)1 / 2 * (side * altitude);

            return surface;
        }

        public static double AllThreeSides()
        {
            Console.WriteLine("Your choice is surface of a triangle by given three sides.");
            Console.Write("Enter side 1: ");
            double sideOne = double.Parse(Console.ReadLine());
            Console.Write("Enter side 2: ");
            double sideTwo = double.Parse(Console.ReadLine());
            Console.Write("Enter side 3: ");
            double sideThree = double.Parse(Console.ReadLine());
            double perimeter = (sideOne + sideTwo + sideThree) / 2;
            double surface = (double)Math.Sqrt(perimeter * (perimeter - sideOne) * (perimeter - sideTwo) * (perimeter - sideThree));

            return surface;
        }

        public static double SidesAndAngle()
        {
            Console.WriteLine("Your choice is surface of a triangle by given two sides and an angle between them.");
            Console.Write("Enter side 1: ");
            double sideA = double.Parse(Console.ReadLine());
            Console.Write("Enter side 2: ");
            double sideB = double.Parse(Console.ReadLine());
            Console.Write("Enter degree: ");
            double degree = double.Parse(Console.ReadLine());
            double angle = Math.PI * degree / 180;
            double surface = (double)1 / 2 * (sideA * sideB * Math.Sin(angle));

            return surface;
        }

    }
}
