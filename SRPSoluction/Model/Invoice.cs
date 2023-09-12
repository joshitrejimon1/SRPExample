using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPSoluction.Model
{
    internal class Invoice
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public double DiscountPrecent { get; set; }

        public double Cost { get; set; }
        const int tax = 10;

        public Invoice(int id, string description, double discountPercent, double cost)
        {
            Id = id;
            Description = description;
            DiscountPrecent = discountPercent;
            Cost = cost;
        }

        public double Calculatetax()
        {
            return ((Cost - CalculateDiscount())) * tax / 100;

        }

        public double CalculateDiscount()
        {
            return Cost * DiscountPrecent;
        }

        public double CalculateFinalCost()
        {
            return Cost - CalculateDiscount() + Calculatetax();
        }
    }
}
