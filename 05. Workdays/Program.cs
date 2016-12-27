using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Workdays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime[] holidays = {new DateTime(2016,12,26),
                         new DateTime(2017,01,02),
                         new DateTime(2017,03,03),
                         new DateTime(2017,04,14),
                                                new DateTime(2017,04,17),
                         new DateTime(2017,05,01),
                         new DateTime(2017,05,08),
                         new DateTime(2017,05,24),
                         new DateTime(2017,09,06),
                         new DateTime(2017,09,22),
                         new DateTime(2017,12,25),
                         new DateTime(2017,12,26),
                         new DateTime(2018,01,01),};

            DateTime now = DateTime.Now;
            Console.WriteLine("Today is {0:d}", now);
            Console.Write("Enter end day(YYYY/MM/DD):");
            DateTime endDate = Convert.ToDateTime(Console.ReadLine());
            int workingDays = 0;
            do
            {
                now = now.AddDays(1);

                if (now.DayOfWeek >= DayOfWeek.Monday && now.DayOfWeek <= DayOfWeek.Friday)
                {
                    workingDays++;
                }

                foreach (var i in holidays)
                {
                    if (i.Date == now.Date)
                    {
                        workingDays--;
                    }
                }
            } while (now.Date != endDate.Date);

            Console.WriteLine("There are {0} working days to {1:d}", workingDays, endDate);

            Console.ReadLine();

        }
    }
}
