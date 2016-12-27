using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _09.Class_Person;

namespace _11.Interface_Payable
{
    public interface Payable
    {
        double Retrieve(double amount);
        double Add(double sum);
        string PaymentAddress(string paymentAddress);

    }

    class Employee : Person, Payable
    {
        double salary;
        string mailingAddress;

        public double Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                if (value > 0)
                {
                    this.salary = value;
                }
            }
        }
        public Employee(double salary, string mailingAddress)
        {
            this.salary = salary;
            try
            {
                this.mailingAddress = mailingAddress;
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public string MailingAddress
        {
            get
            {
                return this.mailingAddress;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    try
                {
                        this.mailingAddress = value;
                    }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public double Retrieve(double salary)
        {
            Console.Write("Enter the amount you want to withdraw from your account: ");
            string text = Console.ReadLine();
            double newAmount;
            while (!double.TryParse(text, out newAmount))
            {
                Console.Write("Enter the amount you want to withdraw from your account: ");
                text = Console.ReadLine();
            }
            salary -= newAmount;

            return salary;
        }
        public double Add(double salary)
        {   
            Console.Write("Enter the amount you want to add to your account: ");
            string text = Console.ReadLine();
            double newAmount;
            while (!double.TryParse(text, out newAmount))
            {
                Console.Write("Enter the amount you want to add: ");
                text = Console.ReadLine();
            }
            newAmount += salary;

            return newAmount;
        }

        public string PaymentAddress(string paymentAddress)
        {

            return paymentAddress;
        }
    }
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
