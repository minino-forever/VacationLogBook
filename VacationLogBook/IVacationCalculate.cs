using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationLogBook
{
    /// <summary>Интерфейс расчета отпуска </summary>
    interface IVacationCalculate
    {
        public void CalculateDays(int days)
        {
            DateTime dateTimeNow = new DateTime();
            DateTime dateTimeAmount = dateTimeNow.AddDays(days);
            Console.WriteLine(dateTimeAmount);
        }
    }
}
