namespace FargoSpringsSpa.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public int EmployeeId { get; set; }
        public DateTime AppointmentDate { get; set; }
        // We should add status functionality in later if we have time, but for now it is never used
        public string Status { get; set; }

        public string Notes
        {
            get; set;

        }

    }
}
