using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Car_Dealership_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose \"Add\" to add a car to the catalog" +
            "\nChoose \"List\" to list all cars in the catalog." +
            "\nChoose \"Quit\" to quit.");
            
            Console.Write("Your choice is: ");
            string choose = Console.ReadLine();
            while (!(choose == "Add" || choose == "List" || choose == "Quit"))
            {
                Console.Write("Please choose between \"Add\", \"List\" or \"Quit\": ");
                choose = Console.ReadLine();
            }
            CarDealerShip ob = new CarDealerShip();
            while (true)
            {
               
                if (choose == "Add")
                {
                    ob.Add();
                    Console.Write("Enter command: ");
                    choose = Console.ReadLine();
                    while (!(choose == "Add" || choose == "List" || choose == "Quit"))
                    {
                        Console.Write("Please choose between \"Add\", \"List\" or \"Quit\": ");
                        choose = Console.ReadLine();
                    }
                }
                if (choose == "List")
                {
                    ob.List();
                    Console.Write("Enter command: ");
                    choose = Console.ReadLine();
                    while (!(choose == "Add" || choose == "List" || choose == "Quit"))
                    {
                        Console.Write("Please choose between \"Add\", \"List\" or \"Quit\": ");
                        choose = Console.ReadLine();
                    }
                }
                if (choose == "Quit")
                {
                    ob.Quit();
                    Console.ReadLine();
                    return;
                }
            }
        }      
    }
}
