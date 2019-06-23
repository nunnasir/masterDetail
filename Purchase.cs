using System;
using System.Collections.Generic;

namespace MvcLayoutHtmlHelper.Models
{
    public class Purchase
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }


        public virtual List<PurchaseDetails> PurchaseDetailses { get; set; } 

    }
}