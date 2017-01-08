using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.System.DateTime_structure
{
    class Program
    {
       static string[] chineseSign = new string[] {"Dog", "Pig", "Rat", "Ox", "Tiger", "Rabbit", "Dragon",
                                               "Snake", "Horse", "Goat", "Monkey", "Rooster", "Monkey" };
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
            switch (birth.Month)
            {
                case 1:
                    if (birth.Day <= 19)
                    {
                        return "Capricorn";
                    }
                    else
                    {
                        return "Aquarius";
                    }
                case 2:
                    if (birth.Day <= 18)
                    {
                        return "Aquarius";
                    }
                    else
                    {
                        return "Pisces";
                    }
                case 3:
                    if (birth.Day <= 20)
                    {
                        return "Pisces";
                    }
                    else
                    {
                        return "Aries";
                    }
                case 4:
                    if (birth.Day <= 19)
                    {
                        return "Aries";
                    }
                    else
                    {
                        return "Taurus";
                    }
                case 5:
                    if (birth.Day <= 20)
                    {
                        return "Taurus";
                    }
                    else
                    {
                        return "Gemini";
                    }
                case 6:
                    if (birth.Day <= 20)
                    {
                        return "Gemini";
                    }
                    else
                    {
                        return "Cancer";
                    }
                case 7:
                    if (birth.Day <= 22)
                    {
                        return "Cancer";
                    }
                    else
                    {
                        return "Leo";
                    }
                case 8:
                    if (birth.Day <= 22)
                    {
                        return "Leo";
                    }
                    else
                    {
                        return "Virgo";
                    }
                case 9:
                    if (birth.Day <= 22)
                    {
                        return "Virgo";
                    }
                    else
                    {
                        return "Libra";
                    }
                case 10:
                    if (birth.Day <= 22)
                    {
                        return "Libra";
                    }
                    else
                    {
                        return "Scorpio";
                    }
                case 11:
                    if (birth.Day <= 21)
                    {
                        return "Scorpio";
                    }
                    else
                    {
                        return "Sagittarius";
                    }
                case 12:
                    if (birth.Day <= 21)
                    {
                        return "Sagittarius";
                    }
                    else
                    {
                        return "Capricorn";
                    }
                default: Console.WriteLine("Invalid month!"); break;
            }
            return "";
        }
        public static string ChineseZodiac(DateTime birth)
        {
            int index = birth.Year % 12;
            for (int i = 0; i < chineseSign.Length; i++)
            {
                if (index - 2 == i)
                {
                    return chineseSign[i];
                }
            }

            return " ";
        }
    }
}