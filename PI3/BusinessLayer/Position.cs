using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    class Position
    {
        [Key]
        public int Id { get; private set; }

        [Required, MaxLength(50)]
        public string Post { get; set; }

        public IEnumerable<Politician> Politicians { get; set; }

        public Position(string post)
        {
            Post = post;
        }
    }
}
