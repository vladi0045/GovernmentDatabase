using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    class Party
    {
        [Key]
        public int Id { get; private set; }

        [Required, MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(20)]
        public string Ideology { get; set; }

        public DateTime DateOfCreation { get; set; }

        public IEnumerable<Politician> Politicians { get; set; }

        public Party(string name, string ideology, DateTime dateOfCreation)
        {
            Name = name;
            Ideology = ideology;
            DateOfCreation = dateOfCreation;
        }
    }
}
