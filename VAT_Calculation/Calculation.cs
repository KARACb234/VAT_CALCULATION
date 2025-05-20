namespace VAT_Calculation
{
    public class CalculateVAT
    {
        public double ReturnTax(double salary, double grossSalary)
        {
            return TaxUtil.CalculateTax(salary, grossSalary);
        }
        public double ReturnNetSalary(double salary, double tax)
        {
            return salary - tax;
        }
    }

    public class Calculation
    {
        public void VATCalculation(double salary, CalculateVAT calculationSystem, ProgramData data)
        {
            data.Salary = salary;
            data.Tax = calculationSystem.ReturnTax(data.Salary, data.GrossSalary);
            data.GrossSalary += salary;
            data.NetSalary += calculationSystem.ReturnNetSalary(data.Salary, data.Tax);
            data.TotalTaxAmount += data.Tax;
        }
    }

    public class TaxBracket
    {
        public double UpperLimit;
        public double Rate;
    }
    public static class TaxUtil
    {
        private static readonly List<TaxBracket> brackets = new List<TaxBracket>()
        {
            new TaxBracket{UpperLimit = 2400000, Rate = 0.13},
            new TaxBracket{UpperLimit = 5000000, Rate = 0.15},
            new TaxBracket{UpperLimit = 7000000, Rate = 0.18},
            new TaxBracket{UpperLimit = 20000000, Rate = 0.2},
            new TaxBracket{UpperLimit = double.MaxValue, Rate = 0.22}
        };
        public static double CalculateTax(double salary, double grossSalary)
        {
            double remainingSalary = salary;
            double taxedSoFar = grossSalary;
            double totalTax = 0;
            foreach (var bracket in brackets)
            {
                if (remainingSalary <= 0) break;
                if (taxedSoFar >= bracket.UpperLimit) continue;
                double taxableInBracket = Math.Min(remainingSalary, bracket.UpperLimit - taxedSoFar);
                totalTax += taxableInBracket * bracket.Rate;
                remainingSalary -= taxableInBracket;
                taxedSoFar += taxableInBracket;
            }
            return totalTax;

        }
    }
}
