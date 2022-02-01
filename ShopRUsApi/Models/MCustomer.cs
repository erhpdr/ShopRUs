using System.ComponentModel;

namespace ShopRUsApi.Models
{
    public class MCustomer
    {
        [DisplayName("CustomerId")]
        public int CustomerId { get; set; }
        
        [DisplayName("CustomerName")]
        public string? CustomerName { get; set; }

        [DisplayName("CustomerSurname")]
        public string? CustomerSurname { get; set; }

        [DisplayName("CustomerInsertDate")]
        public DateTime CustomerInsertDate { get; set; }

        [DisplayName("CustomerType")]
        public string? CustomerType { get; set; }

    }
}
