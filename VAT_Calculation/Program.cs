namespace VAT_Calculation
{
    public class Program
    {
        static void Main()
        {
            UserInput userInput = new UserInput();
            Calculation calculation = new Calculation();
            CalculateVAT _vATCalculations = new CalculateVAT(); 
            View view = new View();
            for (int i = 0; i < 12; i++)
            {
                double salary = userInput.UserInputSalary(i);
                calculation.VATCalculation(salary, _vATCalculations);
                view.ShowInformation(calculation);
            }
        }
    }
}