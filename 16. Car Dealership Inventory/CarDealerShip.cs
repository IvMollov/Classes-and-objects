using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Car_Dealership_Inventory
{
    public class CarDealerShip
    {
       private string make;
        private string model;
        private int year;
        private double price;
        private ArrayList list;

        public CarDealerShip()
        {
            this.make = null;
            this.model = null;
            this.year = 0;
            this.price = 0;
            this.list = new ArrayList();
        }

        public string Make
        {
            get
            {
                return this.make;
            }
            set
            {
                this.make = value;
            }
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public int Year
        {
            get
            {
                return this.year;
            }
            set
            {
                if (year > 1920)
                {
                    this.year = value;
                }
            }
        }
        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (price > 0)
                {
                    this.price = value;
                }
            }
        }
        public ArrayList LIST
        {
            get
            {
                return this.list;
            }
        }

        public void Add()
        {
            if (list.Count <= 76)
            {
                Console.Write("Enter car make: ");
                string make = Console.ReadLine();
                Console.Write("Enter car model: ");
                string model = Console.ReadLine();

                Console.Write("Enter production year (year > 1920): ");
                int year;
                string yearText = Console.ReadLine();
                while (!int.TryParse(yearText, out year))
                {
                    Console.Write("Enter production year: ");
                    yearText = Console.ReadLine();
                }
                while (year < 1920)
                {
                    Console.Write("Enter production year: ");
                    year = int.Parse(Console.ReadLine());
                }

                Console.Write("Enter sales price: ");
                double price;
                string priceText = Console.ReadLine();
                while (!double.TryParse(priceText, out price))
                {
                    Console.Write("Enter sales price: ");
                    priceText = Console.ReadLine();
                }

                list.Add(make);
                list.Add(model);
                list.Add(year);
                list.Add(price);
            }
            else
            {
                Console.WriteLine("Catalog have limit of 20 cars!");
                return;
            }
        }

        public void List()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("There are no cars in the catalog!");
                return;
            }

            for (int i = 0; i < list.Count; i = i + 4)
            {
                object value1 = list[i];
                object value2 = list[i + 1];
                object value3 = list[i + 2];
                object value4 = list[i + 3];
                Console.WriteLine($"Make: {value1}\nModel: {value2}\nYear: {value3}\nSales price: {value4:C2}");
                Console.WriteLine("==========================================");
            }
        }

        public void Quit()
        {
            Console.WriteLine("Thank you & Good bye!");
        }
    }
}
