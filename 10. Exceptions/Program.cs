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
    public class Person
    {
        private string firstName;
        private string lastName;
        private string emailAddress;
        private DateTime birthDate;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public string EmailAddress
        {
            get
            {
                return this.emailAddress;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(emailAddress))
                {
                    return;
                }
                try
                {
                    var test = new MailAddress(emailAddress);
                    return;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                this.emailAddress = value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                if (value > DateTime.Today) 
                {
                    throw new ArgumentException("Date of birth can't be in the future");
                }
               birthDate = value;
            }
        }

        public Person(string firstName, string lastName, string emailAddress, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;

            try
            {
                this.emailAddress = emailAddress;
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message);
            }

            try
            {
                this.birthDate = birthDate;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message);     
            }

        }
        //public Person(string firstName, string lastName, string emailAddress)
        //{
        //    this.firstName = firstName;
        //    this.lastName = lastName;
        //    try
        //    {
        //        this.emailAddress = emailAddress;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine();
        //        Console.WriteLine(ex.Message);
        //    }
        //}
        //public Person(string firstName, string lastName, DateTime birthDate)
        //{
        //    this.firstName = firstName;
        //    this.lastName = lastName;
        //    //try
        //    //{
        //        this.birthDate = birthDate;
        //    //    if (birthDate > DateTime.Today)
        //    //    {
        //    //        Console.WriteLine("Date of birth can't be in the future!");
        //    //    }
        //    //}
        //    //catch (ArgumentException ex)
        //    //{
        //    //    Console.WriteLine();
        //    //    Console.WriteLine(ex.Message);
        //    //}
        //}

        public bool Adult
        {
            get
            {
                DateTime eigthteen = this.birthDate.AddYears(18);
                if (DateTime.Today >= eigthteen)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool Birthday
        {

            get
            {
                DateTime now = DateTime.Today;
                if (this.birthDate.Day == now.Day && this.birthDate.Month == now.Month)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public string SunSign
        {
            get
            {
                if ((birthDate.Day >= 21 && birthDate.Month == 3) || (birthDate.Day <= 19 && birthDate.Month == 4))
                {
                    return "Aries";
                }
                else if ((birthDate.Day >= 20 && birthDate.Month == 4) || (birthDate.Day <= 20 && birthDate.Month == 5))
                {
                    return "Taurus";
                }
                else if ((birthDate.Day >= 21 && birthDate.Month == 5) || (birthDate.Day <= 20 && birthDate.Month == 6))
                {
                    return "Gemini";
                }
                else if ((birthDate.Day >= 21 && birthDate.Month == 6) || (birthDate.Day <= 22 && birthDate.Month == 7))
                {
                    return "Cancer";
                }
                else if ((birthDate.Day >= 23 && birthDate.Month == 7) || (birthDate.Day <= 22 && birthDate.Month == 8))
                {
                    return "Leo";
                }
                else if ((birthDate.Day >= 23 && birthDate.Month == 8) || (birthDate.Day <= 22 && birthDate.Month == 9))
                {
                    return "Virgo";
                }
                else if ((birthDate.Day >= 23 && birthDate.Month == 9) || (birthDate.Day <= 22 && birthDate.Month == 10))
                {
                    return "Libra";
                }
                else if ((birthDate.Day >= 23 && birthDate.Month == 10) || (birthDate.Day <= 21 && birthDate.Month == 11))
                {
                    return "Scorpio";
                }
                else if ((birthDate.Day >= 22 && birthDate.Month == 11) || (birthDate.Day <= 21 && birthDate.Month == 12))
                {
                    return "Sagittarius";
                }
                else if ((birthDate.Day >= 22 && birthDate.Month == 12) || (birthDate.Day <= 19 && birthDate.Month == 1))
                {
                    return "Capricorn";
                }
                else if ((birthDate.Day >= 20 && birthDate.Month == 1) || (birthDate.Day <= 18 && birthDate.Month == 2))
                {
                    return "Aquarius";
                }
                else

                {
                    return "Pisces";
                }
            }
        }
        public string ChineseSign
        {
            get
            {
                if (birthDate.Year == 2008 || birthDate.Year == 1996 ||

                     birthDate.Year == 1984 || birthDate.Year == 1972 ||

                     birthDate.Year == 1960 || birthDate.Year == 1948 ||

                     birthDate.Year == 1936 || birthDate.Year == 1924)
                {
                    return "Rat";
                }
                else if (birthDate.Year == 2009 || birthDate.Year == 1997 ||

                    birthDate.Year == 1985 || birthDate.Year == 1973 ||

                    birthDate.Year == 1961 || birthDate.Year == 1949 ||

                    birthDate.Year == 1937 || birthDate.Year == 1925)
                {
                    return "Ox";
                }
                else if (birthDate.Year == 2010 || birthDate.Year == 1998 ||

                    birthDate.Year == 1986 || birthDate.Year == 1974 ||

                    birthDate.Year == 1962 || birthDate.Year == 1950 ||

                    birthDate.Year == 1938 || birthDate.Year == 1926)
                {
                    return "Tiger";
                }
                else if (birthDate.Year == 2011 || birthDate.Year == 1999 ||

                    birthDate.Year == 1987 || birthDate.Year == 1975 ||

                    birthDate.Year == 1963 || birthDate.Year == 1951 ||

                    birthDate.Year == 1939 || birthDate.Year == 1927)
                {
                    return "Rabbit";
                }
                else if (birthDate.Year == 2012 || birthDate.Year == 2000 ||

                    birthDate.Year == 1988 || birthDate.Year == 1976 ||

                    birthDate.Year == 1964 || birthDate.Year == 1952 ||

                    birthDate.Year == 1940 || birthDate.Year == 1928)
                {
                    return "Dragon";
                }
                else if (birthDate.Year == 2013 || birthDate.Year == 2001 ||

                    birthDate.Year == 1989 || birthDate.Year == 1977 ||

                    birthDate.Year == 1965 || birthDate.Year == 1953 ||

                    birthDate.Year == 1941 || birthDate.Year == 1929)
                {
                    return "Snake";
                }
                else if (birthDate.Year == 2014 || birthDate.Year == 2002 ||

                    birthDate.Year == 1990 || birthDate.Year == 1978 ||

                    birthDate.Year == 1966 || birthDate.Year == 1954 ||

                    birthDate.Year == 1942 || birthDate.Year == 1930)
                {
                    return "Horse";
                }
                else if (birthDate.Year == 2015 || birthDate.Year == 2003 ||

                    birthDate.Year == 1991 || birthDate.Year == 1979 ||

                    birthDate.Year == 1967 || birthDate.Year == 1955 ||

                    birthDate.Year == 1943 || birthDate.Year == 1931)
                {
                    return "Goat";
                }
                else if (birthDate.Year == 2016 || birthDate.Year == 2004 ||

                    birthDate.Year == 1992 || birthDate.Year == 1980 ||

                    birthDate.Year == 1968 || birthDate.Year == 1956 ||

                    birthDate.Year == 1944 || birthDate.Year == 1932 || birthDate.Year == 1920)
                {
                    return "Monkey";
                }
                else if (birthDate.Year == 2017 || birthDate.Year == 2005 ||

                    birthDate.Year == 1993 || birthDate.Year == 1981 ||

                    birthDate.Year == 1969 || birthDate.Year == 1957 ||

                    birthDate.Year == 1945 || birthDate.Year == 1933 || birthDate.Year == 1921)
                {
                    return "Rooster";
                }
                else if (birthDate.Year == 2018 || birthDate.Year == 2006 ||

                    birthDate.Year == 1994 || birthDate.Year == 1982 ||

                    birthDate.Year == 1970 || birthDate.Year == 1958 ||

                    birthDate.Year == 1946 || birthDate.Year == 1934 || birthDate.Year == 1922)
                {
                    return "Dog";
                }
                else if (birthDate.Year == 2019 || birthDate.Year == 2007 ||

                    birthDate.Year == 1995 || birthDate.Year == 1983 ||

                    birthDate.Year == 1971 || birthDate.Year == 1959 ||

                    birthDate.Year == 1947 || birthDate.Year == 1935 || birthDate.Year == 1923)
                {
                    return "Pig";
                }
                return " ";
            }
        }
        public string ScreenName
        {
            get
            {
                return this.firstName[0] + this.lastName + this.birthDate.Year;
            }
        }
    }
}
