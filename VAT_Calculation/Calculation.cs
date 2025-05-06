using System;                                                       using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace VAT_Calculation
{
    public interface IVATCalculation
    {
        bool IsThithIncome(int grossSalary);
        double ReturnTax(int salary, int grossSalary);
        double ReturnNetSalary(int salary, double tax);
    }
    public class IncomeBelowTwoMillionFourHundredThousand : IVATCalculation
    {
        public bool IsThithIncome(int grossSalary)
        {
            if(grossSalary <= 2400000)
            {
                return true;
            }
            return false;
        }
        public double ReturnTax(int salary, int grossSalary)
        {
            int totalGrossSalary = grossSalary + salary;
            if(totalGrossSalary <= 2400000)
            {
                return salary * 0.13;
            }
            else if(totalGrossSalary > 2400000 && totalGrossSalary  <= 5000000)
            {
                double tax = 0;
                tax += (2400000 - grossSalary) * 0.13;
                tax += (totalGrossSalary - 2400000) * 0.15;
                return tax;
            }
            else if (totalGrossSalary > 5000000 && totalGrossSalary <= 7000000)
            {
                double tax = 0;
                tax += (2400000 - grossSalary) * 0.13;
                tax += 2600000 * 0.15;
                tax += (totalGrossSalary - 5000000) * 0.18;
                return tax;
            }                 
            else if (totalGrossSalary > 7000000 && totalGrossSalary <= 20000000)
            {
                double tax = 0;
                tax += (2400000 - grossSalary) * 0.13;
                tax += 2600000 * 0.15;
                tax += 2000000 * 0.18;
                tax += (totalGrossSalary - 7000000) * 0.2;
                return tax;
            }
            else
            {
                double tax = 0;
                tax += (2400000 - grossSalary) * 0.13;
                tax += 2600000 * 0.15;
                tax += 2000000 * 0.18;
                tax += 13000000 * 0.2;
                tax += (totalGrossSalary - 20000000) * 0.22;
                return tax;
            }
        }
        public double ReturnNetSalary(int salary, double tax)
        {
            return salary - tax;
        }
    }
    public class IncomeBelowFiveMillion : IVATCalculation
    {

        public bool IsThithIncome(int grossSalary)
        {
            if (grossSalary > 2400000 && grossSalary <= 5000000)
            {
                return true;
            }
            return false;
        }
        public double ReturnTax(int salary, int grossSalary)
        {
            int totalGrossSalary = grossSalary + salary;
            if (totalGrossSalary > 2400000 && totalGrossSalary <= 5000000)
            {
                double tax = 0;
                tax += salary * 0.15;
                return tax;
            }
            else if (totalGrossSalary > 5000000 && totalGrossSalary <= 7000000)
            {
                double tax = 0;
                tax += (5000000 - grossSalary) * 0.15;
                tax += (totalGrossSalary - 5000000) * 0.18;
                return tax;
            }
            else if (totalGrossSalary > 7000000 && totalGrossSalary <= 20000000)
            {
                double tax = 0;
                tax += (5000000 - grossSalary) * 0.15;
                tax += 2000000 * 0.18;
                tax += (totalGrossSalary - 7000000) * 0.2;
                return tax;
            }
            else
            {
                double tax = 0;
                tax += (5000000 - grossSalary) * 0.15;
                tax += 2000000 * 0.18;
                tax += 13000000 * 0.2;
                tax += (totalGrossSalary - 20000000) * 0.22;
                return tax;
            }
        }
        public double ReturnNetSalary(int salary, double tax)
        {
            return salary - tax;
        }
    }
    public class IncomeBelowsSevenMillion : IVATCalculation
    {
        public bool IsThithIncome(int grossSalary)
        {
            if (grossSalary > 5000000 && grossSalary <= 7000000)
            {
                return true;
            }
            return false;
        }
        public double ReturnTax(int salary, int grossSalary)
        {
            if (grossSalary + salary > 5000000 && grossSalary + salary <= 7000000)
            {
                double tax = 0;
                tax += salary * 0.18;
                return tax;
            }
            else if (grossSalary + salary > 7000000 && grossSalary + salary <= 20000000)
            {
                double tax = 0;
                tax += (7000000 - grossSalary) * 0.18;
                tax += (grossSalary + salary - 7000000) * 0.2;
                return tax;
            }
            else
            {
                double tax = 0;
                tax += (grossSalary + salary - 5000000) * 0.18;
                tax += 13000000 * 0.2;
                tax += (grossSalary + salary - 20000000) * 0.22;
                return tax;
            }
        }
        public double ReturnNetSalary(int salary, double tax)
        {
            return salary - tax;
        }
    }
    public class IncomeBelowsTwentyMillion : IVATCalculation
    {
        public bool IsThithIncome(int grossSalary)
        {
            if (grossSalary > 7000000 && grossSalary <= 20000000)
            {
                return true;
            }
            return false;
        }
        public double ReturnTax(int salary, int grossSalary)
        {
            if (grossSalary + salary > 7000000 && grossSalary + salary <= 20000000)
            {
                double tax = 0;
                tax += salary * 0.2;
                return tax;
            }
            else
            {
                double tax = 0;
                tax += (20000000 - grossSalary) * 0.2;
                tax += (grossSalary + salary - 20000000) * 0.22;
                return tax;
            }
        }
        public double ReturnNetSalary(int salary, double tax)
        {
            return salary - tax;
        }
    }
    public class IncomeBelowsFiftyMillion : IVATCalculation
    {
        public bool IsThithIncome(int grossSalary)
        {
            if (grossSalary > 20000000)
            {
                return true;
            }
            return false;
        }
        public double ReturnTax(int salary, int grossSalary)
        {
            return salary * 0.22;
        }
        public double ReturnNetSalary(int salary, double tax)
        {
            return salary - tax;
        }
    }
    public class Calculation 
    {
        private int _grossSalary;
        public int GetGrossSalary => _grossSalary;
        private double _netSalary;
        public double GetNetSalary => _netSalary;
        private double _tax;
        public double Tax => _tax; 
        private double _totalTaxAmount;
        public double TotalTaxAmount => _totalTaxAmount;
        private int _salary;
        public int Salary => _salary;
        public void VATCalculation(int salary, IVATCalculation calculationSystem)
        {
            _salary = salary;
            _tax = calculationSystem.ReturnTax(_salary, _grossSalary);
            _grossSalary += salary;
            _netSalary += calculationSystem.ReturnNetSalary(_salary, _tax);
            _totalTaxAmount += _tax;
        }
    }
}
