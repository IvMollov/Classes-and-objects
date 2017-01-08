using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace _10.Exceptions
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter first name: ");
            string first = Console.ReadLine();
            Console.Write("Enter last name: ");
            string last = Console.ReadLine();
            Console.Write("Enter e-mail address: ");
            bool isValid = false;
            string mail = Console.ReadLine();           
            try
            {
                if (string.IsNullOrWhiteSpace(mail))
                {
                    Console.WriteLine("Mail address can't be empty!");
                }
                var test = new MailAddress(mail);
                isValid = true;
            }
            catch (FormatException)
            {
                isValid = false;
            }
            Console.Write("What is your birth date?: ");
            string textDate = Console.ReadLine();
            DateTime birthDate = DateTime.Parse(textDate);
            try
            {
                birthDate = Convert.ToDateTime(textDate);
            }
            catch (Exception)
            {
                Console.WriteLine("{0}: Invalid date intput", textDate);
            }
            Console.WriteLine();
            Person ob = new Person(first, last, mail, birthDate);

            Console.WriteLine("Date of birth is: {0}", ob.BirthDate);
            if (isValid)
            {
                Console.WriteLine("Email address is: {0}", ob.EmailAddress);
            }
            else
            {
                Console.WriteLine("Email address \"{0}\" is invalid.", mail);
            }

            Console.WriteLine("Are you over 18 years old? {0}", ob.Adult);
            Console.WriteLine("Your western sun sign is: {0}.", ob.SunSign);
            Console.WriteLine("Your chinese sign is: {0}.", ob.ChineseSign);
            Console.WriteLine("Is it your birthday today? {0}", ob.Birthday);
            Console.WriteLine("Your screen name is: {0}", ob.ScreenName);

            Console.ReadLine();
        }
    }

}
