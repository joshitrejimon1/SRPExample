using SRPViolation.Model;

namespace SRPViolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(101, "Training Invoice", 0.2, 100);
            invoice.PrintInvoice();
        }
    }
}