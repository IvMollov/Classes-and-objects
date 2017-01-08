using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _09.Class_Person;
namespace _11.Interface_Payable
{
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
            catch (FormatException ex)
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
}
