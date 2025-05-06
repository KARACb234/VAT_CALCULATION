using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAT_Calculation
{
    public class View
    {
        public void ShowInformation(Calculation calculation)
        {
            Console.WriteLine($"Cумма заработной платы начисленной за месяц с учётом налога: {calculation.Salary}");
            Console.WriteLine($"Налог: {calculation.Tax}");
            Console.WriteLine($"Заработная плата за вычетом налога: {calculation.Salary - calculation.Tax}");
            Console.WriteLine($"Заработная плата нарастающим итогом: {calculation.GetGrossSalary}");
            Console.WriteLine($"Налог нарастающим итогом: {calculation.TotalTaxAmount}");
            Console.WriteLine($"Сумма выплаты нарастающим итогом: {calculation.GetNetSalary}");
        }
    }
}