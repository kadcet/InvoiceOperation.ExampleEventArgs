using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceOperation.Ex.Domain
{
	public delegate void InvoicePriceEventHandler(Invoice invoice, InvoicePriceEventArgs e);
	
}
