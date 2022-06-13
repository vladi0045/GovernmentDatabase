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

        [MaxLength(20)]
        public string Ideology { get; set; }

        public DateTime DateOfCreation { get; set; }

        public IEnumerable<Politician> Politicians { get; set; }

        private Party()
        {

        }

        public Party(string name, string ideology,IEnumerable<Politician> politicians, DateTime dateOfCreation)
        {
            Name = name;
            Ideology = ideology;
            Politicians = politicians;
            DateOfCreation = dateOfCreation;
        }
    }
}
