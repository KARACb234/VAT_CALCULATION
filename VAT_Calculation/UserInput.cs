using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAT_Calculation
{
    public class UserInput
    {
        private double[] listOfSalaries = new double[12];
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
        public double UserInputSalary(int monthNumber)
        {
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.Write($"Введите зарплату за {_months[monthNumber]}:");
            string salary = Console.ReadLine();
            if (string.IsNullOrEmpty(salary))
            {
                throw new Exception("Не корректный ввод");
            }
            if (double.TryParse(salary, out double result))
            {
                listOfSalaries[monthNumber] = result;
                Console.WriteLine("В этом месяце есть премия?");
                string userAnswer = Console.ReadLine();
                if (string.IsNullOrEmpty(userAnswer))
                {
                    throw new Exception("Не корректный ввод");
                }
                else if(userAnswer != "ДА" && userAnswer != "НЕТ")
                {
                    throw new Exception("Не корректный ввод. Отвечайте на вопрос 'ДА' или 'НЕТ'");
                }
                else if (userAnswer == "НЕТ")
                {
                    return result;
                }
                else
                {
                    if (monthNumber != 2 && monthNumber != 5 && monthNumber != 8 && monthNumber != 11)
                    {
                        Console.WriteLine("В этом месяце не может быть премии. Квартал не бы закончен.");
                        return result;
                    }
                    Console.Write("Введите коэффицент премии: ");
                    string coefficient = Console.ReadLine();
                    if (string.IsNullOrEmpty(coefficient))
                    {
                        throw new Exception("Не корректный ввод");
                    }
                    if(double.TryParse(coefficient, out double correctCoefficient))
                    {
                        double currentSalary = result;
                        result = result + listOfSalaries[monthNumber - 1] + listOfSalaries[monthNumber - 2];
                        result = Math.Round(result / 3.0 * correctCoefficient + currentSalary, 2, MidpointRounding.AwayFromZero);
                        return result;
                    }
                    throw new Exception("Не корректный ввод");
                }
            }
            throw new Exception("Не корректный ввод");
        }
    }
}