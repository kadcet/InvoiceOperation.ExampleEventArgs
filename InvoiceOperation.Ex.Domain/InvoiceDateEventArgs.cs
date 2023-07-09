using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceOperation.Ex.Domain
{
	public class InvoiceDateEventArgs:EventArgs
	{
		public InvoiceDateEventArgs( DateTime oldDate, DateTime newDate)
		{
			
			OldDate = oldDate;
			NewDate = newDate;
			
		}


		public DateTime OldDate { get; }

		public DateTime NewDate { get; }

       
    }
}
