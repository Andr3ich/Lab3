namespace Lab3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(400, "Andrii", "TM");
            Console.WriteLine(invoice.CalculateValueOrder());
        }
    }
}
