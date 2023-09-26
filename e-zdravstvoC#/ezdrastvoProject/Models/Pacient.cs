using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ezdrastvoProject.Models
{
    public class Pacient
    {
        public Pacient()
        {
            doctor = new List<Doctor>();
        }
        [Key]
        public int Id { get; set; }
        [Display(Name = "Social security number")]
        public int SSN { get; set; }
        [Required]
        public string Name { get; set; }
        public string Surname { get; set; }
        [Display(Name = "Date of birth")]
        public string DateOfBirth { get; set; }
        [Display(Name = "Appointement Date")]
        public string AppointementDate { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Doctor> doctor { get; set; }
    }
}