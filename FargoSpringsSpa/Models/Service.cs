﻿namespace FargoSpringsSpa.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int DurationInMinutes { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }

}
