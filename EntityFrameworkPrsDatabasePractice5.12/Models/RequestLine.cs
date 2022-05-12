using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkPrsDatabasePractice5._12.Models {
    [Table("RequestLine")]
    public class RequestLine {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public virtual Request Requests { get; set; } = null!;
        public int ProductId { get; set; }
        public virtual Product Products { get; set; } = null!;
        public int Quantity { get; set; } = 1;

        public override string ToString() {
            return $"{Id} {RequestId} {ProductId} {Quantity}";
        }
    }
}
