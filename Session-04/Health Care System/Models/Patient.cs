using System;
using System.Collections.Generic;
using System.Text;

namespace Health_Care_System_DEPI.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public List<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
