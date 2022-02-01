using System.ComponentModel;

namespace ShopRUsApi.Models
{
    public class MInvoice
    {
        [DisplayName("InvoiceId")]
        public int InvoiceId { get; set; } 

        [DisplayName("CustomerId")]
        public int CustomerId { get; set; }

        [DisplayName("Amount")]
        public double Amount { get; set;}

        [DisplayName("ShoppingProductType")]
        public string? ShoppingProductType { get; set; }


    }
}
