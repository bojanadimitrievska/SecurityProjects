using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ezdrastvoProject.Models
{
    public class Doctor
    {
        public Doctor()
        {
            pacient = new List<Pacient>();
        }
        [Key]
        public int Id { get; set; }
        [Display(Name = "Social security number")]
        public int SSN { get; set; }
        [Required]
        public string Name { get; set; }
        public string Surname { get; set; }
        public virtual ICollection<Pacient> pacient { get; set; }
    }
}