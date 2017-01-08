using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _09.Class_Person;

namespace _11.Interface_Payable
{
   
    class Program
    {
        public static void Main()
        {
            double newSalary = 0;
            Console.Write("Enter first name: ");
            string first = Console.ReadLine();
            Console.Write("Enter last name: ");
            string last = Console.ReadLine();
            Console.Write("What is your birth date?: ");
            string textDate = Console.ReadLine();
            Console.WriteLine();
            DateTime birthDate = new DateTime();

            try
            {
                birthDate = Convert.ToDateTime(textDate);   
            }
            catch (Exception)
            {
                Console.WriteLine("{0:d}: This is not correct date!", textDate);
            }
            Person obj = new Person(first, last, birthDate);

            Console.Write("Enter salary: ");
            string text = Console.ReadLine();
            double sal;
            while(!double.TryParse(text, out sal))
            {
                Console.Write("Enter salary: ");
                text = Console.ReadLine();
            }

            Console.Write("Enter mail address: ");
            string address = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(address))
            {
                throw new ArgumentNullException("String input can't be null or whitespace!");
            }

            Employee ob = new Employee(sal, address);

            Console.WriteLine("Choose number \"1\" to 1. Retrieve amount due." +
                                "\nChoose number \"2\" to 2. Add to amount due.");

            Console.Write("Your choice is: ");
            int choose = int.Parse(Console.ReadLine());
            while (choose < 1 || choose > 2)
            {
                Console.Write("Your choice is: ");
                choose = int.Parse(Console.ReadLine());
            }

            if (choose == 1)
            {
                try
                {
                    newSalary = ob.Add(sal);
                    Console.WriteLine("{0} {1}\nBorn on {2:d}" +
                        "\nMailing address: {3}\nBalance: {4}", obj.FirstName, obj.LastName, obj.BirthDate, ob.PaymentAddress(address), newSalary);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            if (choose == 2)
            {
                try
                {
                    newSalary = ob.Retrieve(sal);
                    Console.WriteLine("{0} {1}\nBorn on {2:d}" +
                        "\nMailing address: {3}\nBalance: {4}", obj.FirstName, obj.LastName, obj.BirthDate, ob.PaymentAddress(address), newSalary);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.ReadLine();
        }
    }
}
