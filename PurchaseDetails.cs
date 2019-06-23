namespace MvcLayoutHtmlHelper.Models
{
    public class PurchaseDetails
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }


        public long PurchaseId { get; set; }
        public virtual Purchase Purchase { get; set; }

    }
}