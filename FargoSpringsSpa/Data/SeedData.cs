using FargoSpringsSpa.Data;
using FargoSpringsSpa.Models;
using Microsoft.EntityFrameworkCore;
public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new FargoSpringsSpaContext(
        serviceProvider.GetRequiredService<
        DbContextOptions<FargoSpringsSpaContext>>());

        // Moved this above employee for database changes to work. We really should remove employee model.
        if (!context.EmployeeAvailability.Any())
        {
            context.EmployeeAvailability.Add(new EmployeeAvailability
            {
                Id = 2,
                StartTime = new TimeOnly(9, 0),
                EndTime = new TimeOnly(17, 0),
                Monday = true,
                Tuesday = true,
                Wednesday = true,
                Thursday = true,
                Friday = true,
                Saturday = false,
                Sunday = false,
                IsActive = true
            });
            context.SaveChanges();
        }
        if (!context.User.Any())
        {
            context.User.AddRange(
            new User
            {
                Name = "Customer Account",
                Email = "customer@gmail.com",
                PasswordHash = "123",
                Role = "Customer"
            },

            new User
            {
                Name = "Employee Account",
                Email = "employee@gmail.com",
                PasswordHash = "123",
                Role = "Employee"
            },

            new User
            {
                Name = "Admin Account",
                Email = "admin@gmail.com",
                PasswordHash = "123",
                Role = "Admin"
            }
            );
            context.SaveChanges();
        }

        // We can remove this once we remove the employee model if we have time
        if (!context.Employee.Any())
        {
            context.Employee.Add(new Employee
            {
                Id = 2,
                AvailabilityId = 2
            });
            context.SaveChanges();
        }



        if (!context.Service.Any())
        {
            context.Service.AddRange(
            new Service
            {
                Name = "Deep Tissue Massage",
                Description = "Focused, therapeutic work targeting chronic tension and muscle knots. Ideal for athletes or those with persistent aches.",
                Price = 55,
                DurationInMinutes = 60
            },

            new Service
            {
                Name = "Scalp & Head Massage",
                Description = "A focused treatment to relieve tension, boost circulation, and leave you feeling clear-headed and refreshed.",
                Price = 35,
                DurationInMinutes = 45
            },

            new Service
            {
                Name = "Anti-Aging Facial",
                Description = "Targets fine lines, dullness, and loss of elasticity with firming, brightening ingredients and advanced techniques.",
                Price = 40,
                DurationInMinutes = 35
            }
                );

            context.SaveChanges();
        }
    }
}