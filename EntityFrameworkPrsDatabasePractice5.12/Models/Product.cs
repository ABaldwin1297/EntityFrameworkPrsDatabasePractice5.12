using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkPrsDatabasePractice5._12.Models {
    [Table("Product")]
    [Index(nameof(PartNbr), IsUnique = true)]
    public class Product {
        public int Id { get; set; }
        [StringLength(30)]
        public string PartNbr { get; set; } = null!;
        [StringLength(30)]
        public string Name { get; set; } = null!;
        [Column(TypeName = "decimal(11,2)")]
        public decimal Price { get; set; }
        [StringLength(30)]
        public string Unit { get; set; } = null!;
        [StringLength(255)]
        public string? PhotoPath { get; set; }
        public int VendorId { get; set; }
        public virtual Vendor Vendor { get; set; } = null!;

        public override string ToString() {
            return $"{Id} {PartNbr,-30} {Name,-30} {Price,-11} "
                + $"{Unit,-30} {PhotoPath,-2} {VendorId,-255}";
        }
    }
}
