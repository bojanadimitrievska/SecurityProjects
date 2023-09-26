using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ezdrastvoProject.Models
{
    public class PacientDoctor
    {
        public Doctor doctor { get; set; }
        public List<Pacient> Pacients { get; set; }
        public int PacientId { get; set; }
        public int DoctorId { get; set; }
    }
}