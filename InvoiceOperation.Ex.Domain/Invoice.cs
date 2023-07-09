using System.Diagnostics.Tracing;

namespace InvoiceOperation.Ex.Domain
{
	public class Invoice
	{
		public event InvoiceDateEventHandler InvoiceDateChanged;
		public event InvoiceNoEventHandler InvoiceNoChanged;
		public event InvoicePriceEventHandler InvoicePriceChanged;




		private DateTime invoiceDate;

		public DateTime InvoiceDate
		{
			get { return invoiceDate; }
			set 
			{
				DateTime oldDate = invoiceDate;
				invoiceDate = value;
				InvoiceDateChanged?.Invoke(this, new InvoiceDateEventArgs(oldDate, invoiceDate));

			}
		}

		private decimal price;

		public decimal Price
		{
			get { return price; }
			set 
			{
				var oldPrice = price;
				price = value;
				InvoicePriceChanged?.Invoke(this,new InvoicePriceEventArgs(oldPrice,price));
			}
		}


		private string invoiceNo;

		public string InvoiceNo
		{
			get { return invoiceNo; }
			set
			{
				var oldInvoiceNo = invoiceNo;
				invoiceNo = value;
				InvoiceNoChanged?.Invoke(this, new InvoiceNoEventArgs(oldInvoiceNo,invoiceNo));
			}
		}




		
    }

    
}