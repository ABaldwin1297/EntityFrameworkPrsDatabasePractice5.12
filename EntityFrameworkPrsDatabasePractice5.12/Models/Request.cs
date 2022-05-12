using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkPrsDatabasePractice5._12.Models {
    [Table("Request")]
    public class Request {
        public int Id { get; set; }
        [StringLength (80)]
        public string Description { get; set; } = null!;
        [StringLength(80)]
        public string Justification { get; set; } = null!;
        [StringLength(80)]
        public string? RejectionReason { get; set; }
        [StringLength(20)]
        public string DeliveryMode { get; set; } = null!;
        [StringLength(10)]
        public string Status { get; set; } = null!;
        [Column(TypeName = "decimal(11,2)")]
        public decimal Total { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; } = null!;

        public override string ToString() {
            return $"{Id} {Description,-80} {Justification,-80} {RejectionReason,-80} "
                + $"{DeliveryMode,-20} {Status,-10} {Total,-11} {UserId}";
        }
    }
}
