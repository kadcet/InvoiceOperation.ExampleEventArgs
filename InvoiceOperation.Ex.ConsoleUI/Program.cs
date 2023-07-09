using InvoiceOperation.Ex.Domain;

namespace InvoiceOperation.Ex.ConsoleUI
{
	public class Program
	{
		static void Main(string[] args)
		{
			Invoice invoice = new Invoice();

			invoice.InvoiceDate = new DateTime(2022, 05, 15);
			invoice.InvoiceNo = "GIB2022000000555";
			invoice.Price = 5000;

			invoice.InvoiceDateChanged += Invoice_InvoiceDateChanged;
			invoice.InvoiceDate = new DateTime(2023, 12, 12);


			invoice.InvoiceNoChanged += İnvoice_InvoiceNoChanged;
			invoice.InvoiceNo = "GIB2023000000999";

			invoice.InvoicePriceChanged += İnvoice_InvoicePriceChanged;
			invoice.Price = 800000;
			

		}

		private static void İnvoice_InvoicePriceChanged(Invoice invoice, InvoicePriceEventArgs e)
		{
			Console.WriteLine($" {e.OldPrice} tutarlı faturanın  - Yeni Tutarı :{e.NewPrice}");
		}

		private static void İnvoice_InvoiceNoChanged(Invoice imvoice, InvoiceNoEventArgs e)
		{
			Console.WriteLine($" {e.OldInvoiceNo} nolu faturanın  - Yeni Numarası :{e.NewInvoiceNo}");
		}

		private static void Invoice_InvoiceDateChanged(Invoice invoice, InvoiceDateEventArgs e)
		{
			Console.WriteLine($" {e.OldDate} Tarihli faturanın   - Yeni Tarihi :{e.NewDate}");
		}
	}
}