using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkPrsDatabasePractice5._12.Models {
    [Table("User")]
    [Index(nameof(Username), IsUnique = true)]
    public class User {

        public int Id { get; set; }
        [StringLength(30)]
        public string Username { get; set; } = string.Empty;
        [StringLength(30)]
        public string Password { get; set; } = string.Empty;
        [StringLength(30)]
        public string Firstname { get; set; } = string.Empty;
        [StringLength(30)]
        public string Lastname { get; set; } = null!;
        [StringLength(12)]
        public string? Phone { get; set; } = null!;
        [StringLength(255)]
        public string? Email { get; set; } = null!;
        public bool IsReviewer { get; set; } = false;
        public bool IsAdmin { get; set; } = false;

        public override string ToString() {
            return $"{Id} {Username, -30} {Password, -30} {Firstname, -30} "
                + $"{Lastname, -30} {Phone, -12} {Email, -255} {IsReviewer} {IsAdmin}";
        }
    }
}
