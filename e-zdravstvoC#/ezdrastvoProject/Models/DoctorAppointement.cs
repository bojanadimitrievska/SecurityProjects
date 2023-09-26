using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ezdrastvoProject.Models
{
    public class DoctorAppointement
    {
        public Doctor doctor { get; set; }
        public List<Pacient> pacients { get; set; }
        public DoctorAppointement()
        {
            pacients = new List<Pacient>();
        }
    }
}