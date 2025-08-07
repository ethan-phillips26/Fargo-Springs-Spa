namespace FargoSpringsSpa.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        public EmployeeAvailability Availability { get; set; }
    }

    public class EmployeeAvailability
    {
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