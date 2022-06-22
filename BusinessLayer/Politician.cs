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
        public string FirstName { get; set; }

        [Required,MaxLength(20)]
        public string MiddleName { get; set; }

        [Required, MaxLength(20)]
        public string LastName { get; set; }

        [Required,Range(18, 100)]
        public int Age { get; set; }

        [ForeignKey("Position")]
        public int PositionId { get; set; }
        public Position Position { get; set; }

        [ForeignKey("Party")]
        public int PartyId { get; set; }
        public Party Party { get; set; }

        [Required]
        public DateTime DateOfAppointment { get; set; }

        private Politician()
        {

        }
        public Politician(string firstName, string middleName, string lastName, int age, DateTime dateOfAppointment)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Age = age;
            DateOfAppointment = dateOfAppointment;
        }

        public Politician(string firstName, string middleName, string lastName, int age, Position position ,Party party , DateTime dateOfAppointment)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Age= age;
            Position = position;
            Party = party;
            DateOfAppointment = dateOfAppointment;
        }

        public Politician(int id, string firstName, string middleName, string lastName, int age, Position position, Party party, DateTime dateOfAppointment)
        {
            Id = id;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Age = age;
            Position = position;
            Party = party;
            DateOfAppointment = dateOfAppointment;

            PartyId = party.Id;
            PositionId = Position.Id;
        }
    }
}
