using System;

namespace VacationLogBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee { ID = "54321", Name = "Алексей"};

            employee1.CalculateDays(2024, 4, 1, 14);

            employee1.PrintState();

            Console.ReadKey();
        }
    }
}
