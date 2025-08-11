using System.ComponentModel.DataAnnotations.Schema;

namespace FargoSpringsSpa.Models
{
    // Employee may not be needed anymore as we are no longer using the Bookings list.   
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? AvailabilityId { get; set; }

        // Not using this list anymore, we are just searching for bookings with the userID as the employeeID
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        public EmployeeAvailability Availability { get; set; }
    }

    public class EmployeeAvailability
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        // Work the same hours everyday, maybe add differnt hours if time
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }

        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public bool Saturday { get; set; }
        public bool Sunday { get; set; }

        public bool IsActive { get; set; } = true;
    }
}