using System;
using System.Collections.Generic;
using System.Text;

namespace Health_Care_System_DEPI.Models
{
    public class Appointment
    {
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        public DateTime AppointmentDate { get; set; }

    }
}
