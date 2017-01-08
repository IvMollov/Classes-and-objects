using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Class_Person
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
            string mail = Console.ReadLine();
            Console.Write("What is your birth date?: ");
            string textDate = Console.ReadLine();
            Console.WriteLine();
            DateTime birthDate = new DateTime();

            try
            {
                birthDate = Convert.ToDateTime(textDate);
                Person ob = new Person(first, last, mail, birthDate);
                Console.WriteLine("Are you over 18 years old? {0}", ob.Adult);
                Console.WriteLine("Your western sun sign is: {0}.", ob.SunSign);
                Console.WriteLine("Your chinese sign is: {0}.", ob.ChineseSign);
                Console.WriteLine("Is it your birthday today? {0}", ob.Birthday);
                Console.WriteLine("Your screen name is: {0}", ob.ScreenName);
            }
            catch (Exception)
            {
                Console.WriteLine("{0:d}: This is not correct date!", textDate);
            }
            Console.ReadLine();
        }
    }
    

}
