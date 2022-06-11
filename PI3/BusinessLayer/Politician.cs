using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessLayer
{
    class Politician
    {
        [Key]
        public int Id { get; private set; }

        [Required, MaxLength(20)]
        public string FirstName;

        [MaxLength(20)]
        public string MiddleName;

        [Required, MaxLength(20)]
        public string LastName;

        public string ImageUrl { get; set; }

        [Range(18, 100)]
        public int Age { get; set; }

        [Required]
        public DateTime DateOfAppointment;

        public Position Position { get; set; }

        public Party Party { get; set; }

        public Politician(string firstName, string middleName, string lastName, DateTime dateOfAppointment)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            DateOfAppointment = dateOfAppointment;
        }
    }
}
