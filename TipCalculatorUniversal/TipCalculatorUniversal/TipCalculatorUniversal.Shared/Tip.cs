using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalculatorUniversal
{
    class Tip
    {
        public string BillAmount { get; set; }
        public string TipAmount { get; set; }
        public string TotalAmount { get; set; }

        public Tip()
        {
            this.BillAmount = string.Empty;
            this.TipAmount = string.Empty;
            this.TotalAmount = string.Empty;
        }

        public void CalculateTip(string originalAmount, double tipPercentage)
        {
            double billAmount = 0.0;
            double tipAmount = 0.0;
            double totalAmount = 0.0;

            if(double.TryParse(originalAmount.Replace('$', ' '),out billAmount))
            {
                tipAmount = billAmount * tipPercentage;
                totalAmount = billAmount + tipAmount;
            }

            this.BillAmount = string.Format("{0:C}", billAmount);
            this.TipAmount = string.Format("{0:C}", tipAmount);
            this.TotalAmount = string.Format("{0:C}", totalAmount);
        }
    }
}
