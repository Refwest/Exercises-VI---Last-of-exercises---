using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_VI
{
    internal class Taxpayer
    {
        //Exercises VI.2
        private int idNumber;
        private double grossIncome;
        private double taxOwed;


        public Taxpayer(int idNumber, double grossIncome)
        {
            this.idNumber = idNumber;
            this.grossIncome = grossIncome;
            tax();
        }

        public int IdNumber
        {
            get
            {
                return idNumber;
            }
            set
            {
                this.idNumber = value;
            }
        }

        public double GrossIncome
        {
            get
            {
                return grossIncome;
            }
            set
            {
                this.grossIncome = value;
                tax();
            }
        }

        public double TaxOwed
        {
            get
            {
                return taxOwed;
            }
        }

        public void tax()
        {
            if(grossIncome < 30000)
            {
                taxOwed = grossIncome * 0.15;
            }
            else
            {
                taxOwed = grossIncome * 0.28;
            }

        }
    }
}
