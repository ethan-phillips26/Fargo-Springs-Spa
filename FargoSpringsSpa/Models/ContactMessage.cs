using System;
using System.ComponentModel.DataAnnotations;

namespace FargoSpringsSpa.Models
{
    public class ContactMessage
    {
        public int Id { get; set; }

        [Required, StringLength(80)]
        public string Name { get; set; } = string.Empty;

        [Required, EmailAddress, StringLength(120)]
        public string Email { get; set; } = string.Empty;

        [Required, StringLength(120)]
        public string Subject { get; set; } = string.Empty;

        [Required, StringLength(2000, MinimumLength = 10)]
        public string Message { get; set; } = string.Empty;

        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    }
}
