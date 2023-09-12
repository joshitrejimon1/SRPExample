using SRPSoluction.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPSolutionApp.Model
{
    internal class PrintToHTML
    {
        public static void PrintInvoice(Invoice invoice)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\albin.kurian\Desktop\DotNet\Section18\SRPViolationApp\SRPSolutionApp\bill.html");
            string html = $"<html><body><table border=1 width=45>" +
                $"<tr><th>Invoice Id</th>" +
                $"<th>Description</th>" +
                $"<th>Orginal Price</th>" +
                $"<th>Discount</th>" +
                $"<th>Tax</th>" +
                $"<th>Final Price<th></tr>";
            html += $"<tr><th></th>" +
                $"<th>{invoice.Id}</th>" +
                $"<th>{invoice.Description}</th>" +
                $"<th>{invoice.Cost}</th>" +
                $"<th>{invoice.CalculateDiscount()}</th>" +
                $"<th>{invoice.Calculatetax()}</th>" +
                $"<th> {invoice.CalculateFinalCost()}</th>";
            sw.WriteLine(html);
            sw.Close();


        }
        //public void PrintInvoice(Invoice invoice) 
        //{ 
        //    Console.WriteLine($"Invoice Details: \n" + $"Invoice Id:{invoice.Id}" + 
        //        $"Description:{invoice.Description}" + $"Discount:{invoice.CalculateDiscount()}" + 
        //        $"Tax:{invoice.CalculateTax()}" + $"Orginal Price:{invoice.Cost}" + 
        //        $"Price: {invoice.CalculateFinlCost()}"); 

        //} 
    }
}