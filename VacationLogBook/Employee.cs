using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationLogBook
{
    class Employee : IVacationCalculate
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string LastName { get; set; }
        public string ID { get; set; }

        DateTime dateTimeNow;
        DateTime dateTimeAmount;

        public void CalculateDays(int year, int month, int day, int days)
        {
            dateTimeNow = new DateTime(year, month, day);

            dateTimeAmount = dateTimeNow.AddDays(days);
        }

        public void PrintState()
        {
            Console.WriteLine($"Работник: {Name}, ID: {ID}");

            Console.Write($"Дата начала отпука: {dateTimeNow} {Environment.NewLine}");

            Console.Write($"Конец отпуска: {dateTimeAmount}");

        }
    }
}
