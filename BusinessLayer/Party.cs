using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class Party
    {
        [Key]
        public int Id { get; private set; }

        [Required, MaxLength(20)]
        public string Name { get; set; }

        [Required, MaxLength(20)]
        public string Ideology { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateOfCreation { get; set; }

        public IEnumerable<Politician> Politicians { get; set; }

        private Party()
        {

        }

        public Party(string name, string ideology, DateTime dateOfCreation)
        {
            Name = name;
            Ideology = ideology;
            DateOfCreation = dateOfCreation;
        }

        public Party(int id, string name, string ideology, DateTime dateOfCreation)
        {
            Id = id;
            Name = name;
            Ideology = ideology;
            DateOfCreation = dateOfCreation;
        }
    }
}
