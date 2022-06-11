using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    class GovernmentSubdivision
    {
        [Key]
        public int Id { get; private set; }

        [Required, MaxLength(50)]
        public string Subdivision { get; set; }

        public GovernmentDivision GovernmentDivision { get; set; }

        public IEnumerable<Position> Position { get; set; }

        public GovernmentSubdivision(string subdivision)
        {
            Subdivision = subdivision;
        }
    }
}
