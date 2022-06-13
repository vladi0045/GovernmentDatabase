using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessLayer
{
    public class Politician
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

        [ForeignKey("Position")]
        public int PositionId { get; set; }
        public Position Position { get; set; }

        [ForeignKey("Party")]
        public int PartyId { get; set; }
        public Party Party { get; set; }

        [Required]
        public DateTime DateOfAppointment;

        private Politician()
        {

        }

        public Politician(string firstName, string middleName, string lastName, Position position ,Party party , DateTime dateOfAppointment)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Position = position;
            Party = party;
            DateOfAppointment = dateOfAppointment;
        }
    }
}
