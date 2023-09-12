using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPViolation.Model
{
    internal class Invoice
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public double DiscountPrecent { get; set; }

        public double Cost { get; set; }
        const int tax = 10;

        public Invoice(int id,string description,double discountPercent,double cost)
        {
            Id = id;
            Description = description;
            DiscountPrecent = discountPercent;
            Cost = cost;
        }

        private double Calculatetax()
        {
            return ((Cost - CalculateDiscount())) * tax / 100;

        }

        private double CalculateDiscount()
        {
            return Cost * DiscountPrecent;
        }

        private double CalculateFinalCost()
        {
            return Cost - CalculateDiscount() + Calculatetax();
        }
        public void PrintInvoice()
        {
            Console.WriteLine($"INVOICE DETAILS ARE \n" +
                $"INVOICE ID{Id}" +
                $"DESCRIPTION{Description}" +
                $"DISCOUNT{CalculateDiscount()}" +
                $"TAX{Calculatetax()}" +
                $"ORIGINAL COST{Cost}" +
                $"FINAL COST{CalculateFinalCost()}");
        }
    }
}
