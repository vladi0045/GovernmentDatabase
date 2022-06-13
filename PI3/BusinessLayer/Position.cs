using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class Position
    {
        [Key]
        public int Id { get; private set; }

        [Required, MaxLength(50)]
        public string PositionName { get; set; }

        public IEnumerable<Politician> Politicians { get; set; }

        private Position()
        {

        }

        public Position(string positionName)
        {
            PositionName = positionName;
        }
    }
}
