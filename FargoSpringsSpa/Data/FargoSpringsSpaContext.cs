using Microsoft.EntityFrameworkCore;

namespace FargoSpringsSpa.Data
{
    public class FargoSpringsSpaContext : DbContext
    {
        public FargoSpringsSpaContext(DbContextOptions<FargoSpringsSpaContext> options)
            : base(options)
        {
        }

        public DbSet<FargoSpringsSpa.Models.User> User { get; set; } = default!;
        public DbSet<FargoSpringsSpa.Models.EmployeeAvailability> EmployeeAvailability { get; set; } = default!;
        public DbSet<FargoSpringsSpa.Models.Employee> Employee { get; set; } = default!;
        public DbSet<FargoSpringsSpa.Models.Booking> Booking { get; set; } = default!;
        public DbSet<FargoSpringsSpa.Models.Service> Service { get; set; } = default!;
        public DbSet<FargoSpringsSpa.Models.Review> Review { get; set; } = default!;
    }
}
