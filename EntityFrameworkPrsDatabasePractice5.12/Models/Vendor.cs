using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkPrsDatabasePractice5._12.Models {
    [Table("Vendor")]
    [Index(nameof(Code), IsUnique = true)]
    public class Vendor {
        public int Id { get; set; }
        [StringLength(30)]
        public string Code { get; set; } = null!;
        [StringLength(30)]
        public string Name { get; set; } = null!;
        [StringLength(30)]
        public string Address { get; set; } = null!;
        [StringLength(30)]
        public string City { get; set; } = null!;
        [StringLength(2)]
        public string State { get; set; } = null!;
        [StringLength(5)]
        public string Zip { get; set; } = null!;
        [StringLength(12)]
        public string? Phone { get; set; }
        [StringLength(255)]
        public string? Email { get; set; }

        public override string ToString() {
            return $"{Id} {Code,-30} {Name,-30} {Address,-30} "
                + $"{City,-30} {State,-2} {Zip,-5} {Phone, -12} {Email, -255}";
        }
    }
}
