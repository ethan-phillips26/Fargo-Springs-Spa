using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FargoSpringsSpa.Models;

namespace FargoSpringsSpa.Data
{
    public class FargoSpringsSpaContext : DbContext
    {
        public FargoSpringsSpaContext (DbContextOptions<FargoSpringsSpaContext> options)
            : base(options)
        {
        }

        public DbSet<FargoSpringsSpa.Models.User> User { get; set; } = default!;
        public DbSet<FargoSpringsSpa.Models.Booking> Booking { get; set; } = default!;
    }
}
