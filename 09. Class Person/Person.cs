using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Class_Person
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private string emailAddress;
        private DateTime birthDate;
        private string[] chineseSign = new string[]{"Dog", "Pig", "Rat", "Ox", "Tiger", "Rabbit", "Dragon",
                                               "Snake", "Horse", "Goat", "Monkey", "Rooster", "Monkey" };

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string EmailAddress
        {
            get
            {
                return emailAddress;
            }
            set
            {
                emailAddress = value;
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
                birthDate = value;
            }
        }

        public Person(string firstName, string lastName, string emailAddress, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.birthDate = birthDate;
        }
        public Person(string firstName, string lastName, string emailAddress)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
        }
        public Person(string firstName, string lastName, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
        }

        protected Person()
        {

        }

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
                switch (birthDate.Month)
                {
                    case 1:
                        if (birthDate.Day <= 19)
                        {
                            return "Capricorn";
                        }
                        else
                        {
                            return "Aquarius";
                        }
                    case 2:
                        if (birthDate.Day <= 18)
                        {
                            return "Aquarius";
                        }
                        else
                        {
                            return "Pisces";
                        }
                    case 3:
                        if (birthDate.Day <= 20)
                        {
                            return "Pisces";
                        }
                        else
                        {
                            return "Aries";
                        }
                    case 4:
                        if (birthDate.Day <= 19)
                        {
                            return "Aries";
                        }
                        else
                        {
                            return "Taurus";
                        }
                    case 5:
                        if (birthDate.Day <= 20)
                        {
                            return "Taurus";
                        }
                        else
                        {
                            return "Gemini";
                        }
                    case 6:
                        if (birthDate.Day <= 20)
                        {
                            return "Gemini";
                        }
                        else
                        {
                            return "Cancer";
                        }
                    case 7:
                        if (birthDate.Day <= 22)
                        {
                            return "Cancer";
                        }
                        else
                        {
                            return "Leo";
                        }
                    case 8:
                        if (birthDate.Day <= 22)
                        {
                            return "Leo";
                        }
                        else
                        {
                            return "Virgo";
                        }
                    case 9:
                        if (birthDate.Day <= 22)
                        {
                            return "Virgo";
                        }
                        else
                        {
                            return "Libra";
                        }
                    case 10:
                        if (birthDate.Day <= 22)
                        {
                            return "Libra";
                        }
                        else
                        {
                            return "Scorpio";
                        }
                    case 11:
                        if (birthDate.Day <= 21)
                        {
                            return "Scorpio";
                        }
                        else
                        {
                            return "Sagittarius";
                        }
                    case 12:
                        if (birthDate.Day <= 21)
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
        }
        public string ChineseSign
        {
            get
            {
                int index = birthDate.Year % 12;
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
        public string ScreenName
        {
            get
            {
                return this.firstName[0] + this.lastName + this.birthDate.Year;
            }
        }
    }
}
