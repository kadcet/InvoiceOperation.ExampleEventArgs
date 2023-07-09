using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceOperation.Ex.Domain
{
	public class InvoiceNoEventArgs:EventArgs
	{
		public InvoiceNoEventArgs(string oldInvoiceNo, string newInvoiceNo)
		{
			OldInvoiceNo = oldInvoiceNo;
			NewInvoiceNo = newInvoiceNo;
			
		}

		public string OldInvoiceNo { get; set; }

		public string NewInvoiceNo { get; set; }

       
    }
}
