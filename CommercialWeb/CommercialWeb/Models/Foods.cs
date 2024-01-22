using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommercialWeb.Models
{
    public class Foods
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public bool InStock { get; set; }
        public Information Information { get; set; }
    }
}
