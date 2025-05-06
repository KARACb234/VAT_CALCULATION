namespace VAT_Calculation
{
    public class Program
    {
        static void Main()
        {
            UserInput userInput = new UserInput();
            Calculation calculation = new Calculation();
            IVATCalculation[] _vATCalculations =
            [
                new IncomeBelowTwoMillionFourHundredThousand(),
                new IncomeBelowFiveMillion(),
                new IncomeBelowsSevenMillion(),
                new IncomeBelowsTwentyMillion(),
                new IncomeBelowsFiftyMillion()
            ];
            View view = new View();
            for (int i = 0; i < 12; i++)
            {
                int salary = userInput.UserInputSalary(i);
                foreach (var j in _vATCalculations)
                {
                    if (j.IsThithIncome(calculation.GetGrossSalary))
                    {
                        calculation.VATCalculation(salary, j);
                        view.ShowInformation(calculation);
                        break;
                    }
                }
            }
        }
    }
}