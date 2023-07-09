using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceOperation.Ex.Domain
{
	public class InvoicePriceEventArgs:EventArgs
	{
		public InvoicePriceEventArgs(decimal oldPrice, decimal newPrice)
		{
			OldPrice = oldPrice;
			NewPrice = newPrice;
		}

		public decimal OldPrice { get; set; }

        public decimal NewPrice { get; set; }
    }
}
