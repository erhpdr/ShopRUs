using System.ComponentModel;

namespace ShopRUsApi.Models
{
    public class Affiliate
    {
        [DisplayName("AffiliateId")]
        public int AffiliateId { get; set; }    

        [DisplayName("AffiliateName")]
        public string AffiliateName { get; set; }

    }
}
