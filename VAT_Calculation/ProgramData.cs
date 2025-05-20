using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAT_Calculation
{
    public class ProgramData
    {
        private double _salary;
        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Зарплата не может быть меньше 0");
                }
                _salary = value;
            }
        }
        private double _grossSalary;
        public double GrossSalary
        {
            get { return _grossSalary; }
            set { _grossSalary = value; }
        }
        private double _netSalary;
        public double NetSalary
        {
            get { return _netSalary; }
            set { _netSalary = value; }
        }
        private double _tax;
        public double Tax
        {
            get { return _tax; }
            set { _tax = value; }
        }
        private double _totalTaxAmount;
        public double TotalTaxAmount
        {
            get { return _totalTaxAmount; }
            set { _totalTaxAmount = value; }
        }
    }
}
