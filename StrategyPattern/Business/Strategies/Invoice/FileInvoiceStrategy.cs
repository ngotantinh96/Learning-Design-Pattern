using Strategy_Pattern_First_Look.Business.Models;
using System;
using System.IO;

namespace Strategy_Pattern_First_Look.Business.Strategies.Invoice
{
    public class FileInvoiceStrategy : InvoiceStrategy
    {
        public override void Generate(Order order)
        {
            using var streamWriter = new StreamWriter($"invoice_{Guid.NewGuid()}.txt");
            streamWriter.Write(GenerateTextInvoice(order));
            streamWriter.Flush();
        }
    }
}
