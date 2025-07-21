using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WealthTracker.Shared.DataAccess;

namespace WealthTracker.Repository.DataAccessObjects
{
    public class UserAccount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string IdentityUserId { get; set; } = string.Empty;

        [Required]
        [MaxLength(200)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(200)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [MaxLength(200)]
        public string Email { get; set; } = string.Empty;
        public int RetryAttempts { get; set; } = 0;

        [MaxLength(25)]
        public string? PhoneNumber { get; set; }

        [Required]
        public string PaymentPlan { get; set; } = "Free";

        public DateTime LastLoggedIn { get; set; } = DateTime.UtcNow;

        public int RetryAttempts { get; set; } = 0;
        public ApplicationUser? IdentityUser { get; set; }
    }
}
