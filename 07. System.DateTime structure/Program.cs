using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.System.DateTime_structure
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello!\nWhat is your birthdate?\nPlease use one of these formats:" +
                         "YYYY/MM/DD or YYYY,MM,DD or YYYY.MM.DD or YYYY MM DD: ");
            string birthday = Console.ReadLine();

            Birthday(birthday);

            Console.ReadLine();
        }

        public static void Birthday(string birthday)
        {
            DateTime birth = new DateTime();

            try
            {
                birth = Convert.ToDateTime(birthday);
                DateTime now = DateTime.Today;
                int age = (now.Year - birth.Year);
                if (birth > now)
                {
                    Console.WriteLine("Wrong input! Your date of birth can't be after today!");
                }
                else if ((now.Year - birth.Year) <= 131)
                {
                    if ((now.Day - birth.Day) == 0 && (now.Month - birth.Month) == 0)
                    {
                        if ((now.Day - birth.Day) == 0 && (now.Month - birth.Month) == 0 && (now.Year - birth.Year) == 0)
                        {
                            Console.WriteLine("Happy birthday! You are born today! It's your first year!");
                        }
                        else
                        {
                            Console.WriteLine("Happy birthday! You are {0} years old, now!", age);
                        }

                    }
                    else if ((((now.Day - birth.Day) < 0 && (now.Month - birth.Month) <= 0)) || (now.Month - birth.Month) < 0)
                    {

                        Console.WriteLine("You are {0} years old!", age - 1);
                    }
                    else
                    {
                        Console.WriteLine("You are {0} years old!", age);
                    }

                    Console.WriteLine($"According to Western (sun sign) astrological system, you are {WesternZodiac(birth)}.\n" +
                                        $"According to Chinese astrological system, you are {ChineseZodiac(birth)}.");
                }
                if (((now.Year - birth.Year) - 1) > 130 || ((now.Year - birth.Year) >= 130 && (now.Day - birth.Day) >= 0 && (now.Month - birth.Month) >= 0))
                {
                    Console.WriteLine("You can't be that old! Duncan MacLeod is that you?");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("{0}: This is not correct date!", birthday);
            }

        }

        public static string WesternZodiac(DateTime birth)
        {
            string sign = " ";
            if ((birth.Day >= 21 && birth.Month == 3) || (birth.Day <= 19 && birth.Month == 4))
            {
                sign = "Aries";
            }
            else if ((birth.Day >= 20 && birth.Month == 4) || (birth.Day <= 20 && birth.Month == 5))
            {
                sign = "Taurus";
            }
            else if ((birth.Day >= 21 && birth.Month == 5) || (birth.Day <= 20 && birth.Month == 6))
            {
                sign = "Gemini";
            }
            else if ((birth.Day >= 21 && birth.Month == 6) || (birth.Day <= 22 && birth.Month == 7))
            {
                sign = "Cancer";
            }
            else if ((birth.Day >= 23 && birth.Month == 7) || (birth.Day <= 22 && birth.Month == 8))
            {
                sign = "Leo";
            }
            else if ((birth.Day >= 23 && birth.Month == 8) || (birth.Day <= 22 && birth.Month == 9))
            {
                sign = "Virgo";
            }
            else if ((birth.Day >= 23 && birth.Month == 9) || (birth.Day <= 22 && birth.Month == 10))
            {
                sign = "Libra";
            }
            else if ((birth.Day >= 23 && birth.Month == 10) || (birth.Day <= 21 && birth.Month == 11))
            {
                sign = "Scorpio";
            }
            else if ((birth.Day >= 22 && birth.Month == 11) || (birth.Day <= 21 && birth.Month == 12))
            {
                sign = "Sagittarius";
            }
            else if ((birth.Day >= 22 && birth.Month == 12) || (birth.Day <= 19 && birth.Month == 1))
            {
                sign = "Capricorn";
            }
            else if ((birth.Day >= 20 && birth.Month == 1) || (birth.Day <= 18 && birth.Month == 2))
            {
                sign = "Aquarius";
            }
            else if ((birth.Day >= 19 && birth.Month == 2) || (birth.Day <= 20 && birth.Month == 3))
            {
                sign = "Pisces";
            }
            return sign;
        }
        public static string ChineseZodiac(DateTime birth)
        {
            string chineseSing = " ";
            if ((birth.Year == 2008 || birth.Year == 1996 || birth.Year == 1984 || birth.Year == 1972 || birth.Year == 1960))
            {
                chineseSing = "Rat";
            }
            else if ((birth.Year == 2009 || birth.Year == 1997 || birth.Year == 1985 || birth.Year == 1973 || birth.Year == 1961))
            {
                chineseSing = "Ox";
            }
            else if ((birth.Year == 2010 || birth.Year == 1998 || birth.Year == 1986 || birth.Year == 1974 || birth.Year == 1962))
            {
                chineseSing = "Tiger";
            }
            else if ((birth.Year == 2011 || birth.Year == 1999 || birth.Year == 1987 || birth.Year == 1975 || birth.Year == 1963))
            {
                chineseSing = "Rabbit";
            }
            else if ((birth.Year == 2012 || birth.Year == 2000 || birth.Year == 1988 || birth.Year == 1976 || birth.Year == 1964))
            {
                chineseSing = "Dragon";
            }
            else if ((birth.Year == 2013 || birth.Year == 2001 || birth.Year == 1989 || birth.Year == 1977 || birth.Year == 1965))
            {
                chineseSing = "Snake";
            }
            else if ((birth.Year == 2014 || birth.Year == 2002 || birth.Year == 1990 || birth.Year == 1978 || birth.Year == 1966))
            {
                chineseSing = "Horse";
            }
            else if ((birth.Year == 2015 || birth.Year == 2003 || birth.Year == 1991 || birth.Year == 1979 || birth.Year == 1967))
            {
                chineseSing = "Goat";
            }
            else if ((birth.Year == 2016 || birth.Year == 2004 || birth.Year == 1992 || birth.Year == 1980 || birth.Year == 1968))
            {
                chineseSing = "Monkey";
            }
            else if ((birth.Year == 2017 || birth.Year == 2005 || birth.Year == 1993 || birth.Year == 1981 || birth.Year == 1969))
            {
                chineseSing = "Rooster";
            }
            else if ((birth.Year == 2018 || birth.Year == 2006 || birth.Year == 1994 || birth.Year == 1982 || birth.Year == 1970))
            {
                chineseSing = "Dog";
            }
            else if ((birth.Year == 2019 || birth.Year == 2007 || birth.Year == 1995 || birth.Year == 1983 || birth.Year == 1971))
            {
                chineseSing = "Pig";
            }
            return chineseSing;
        }
    }
}