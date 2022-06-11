using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    class GovernmentDivision
    {
        [Key]
        public int Id { get; private set; }

        [Required, MaxLength(50)]
        public string Division { get; set; }

        public IEnumerable<GovernmentSubdivision> GovernmentSubdivision { get; set; }

        public GovernmentDivision(string division)
        {
            Division = division;
        }
    }
}
