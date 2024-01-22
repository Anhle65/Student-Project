using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommercialWeb.Models
{
    public class Categories
    {
        [Key]
        public byte CategoryId { get; set; }
        public string CategoryName { get; set; }

        //public Information Information { get; set; }
        //public Foods Foods { get; set; }
    }
}
