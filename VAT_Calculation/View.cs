using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VAT_Calculation
{
    public class View
    {
        public void ShowInformation(ProgramData program)
        {
            Console.WriteLine($"Cумма заработной платы начисленной за месяц с учётом налога: {program.Salary}");
            Console.WriteLine($"Налог: {program.Tax}");
            Console.WriteLine($"Заработная плата за вычетом налога: {program.Salary - program.Tax}");
            Console.WriteLine($"Заработная плата нарастающим итогом: {program.GrossSalary}");
            Console.WriteLine($"Налог нарастающим итогом: {program.TotalTaxAmount}");
            Console.WriteLine($"Сумма выплаты нарастающим итогом: {program.NetSalary}");
        }
    }
}