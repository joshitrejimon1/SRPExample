using SRPSoluction.Model;
using SRPSolutionApp.Model;

namespace SRPSoluction
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(101, "Training", 0.2, 100);

            PrintToHTML.PrintInvoice(invoice);
        }
    }
}