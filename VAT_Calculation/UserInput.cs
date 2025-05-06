using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAT_Calculation
{
    public class UserInput
    {
        private readonly string[] _months = new[]
        {
                "Январь",
                "Февраль",
                "Март",
                "Апрель",
                "Май",
                "Июнь",
                "Июль",
                "Август",
                "Сентябрь",
                "Октябрь",
                "Ноябрь",
                "Декабрь"
        };
        public int UserInputSalary(int monthNumber)
        {
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.Write($"Введите зарплату за {_months[monthNumber]}:");
            string salary = Console.ReadLine();
            if (string.IsNullOrEmpty(salary))
            {
                throw new Exception("Не корректный ввод");
            }
            if (int.TryParse(salary, out int result))
            {
                return result;
            }
            throw new Exception("Не корректный ввод");
        }
    }
}