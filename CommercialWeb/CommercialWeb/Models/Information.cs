using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommercialWeb.Models
{
    public class Information
    {
        [Key]
        public string ProductType { get; set; }
        public string Storage {  get; set; }
        public string Usage { get; set; }
        public DateTime BestBefore { get; set; }

        [ForeignKey("Foods")]
        public int FoodId { get; set; }
        public Foods Foods { get; set; }
    }
}
