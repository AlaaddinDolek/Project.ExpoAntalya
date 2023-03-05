using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class IssueStand:BaseEntity
    {
        public int IssueID { get; set; }
        public int StandID { get; set; }

        //Relational Properties

        public virtual Issue Issue { get; set; }
        public virtual Stand Stand { get; set; }
    }
}
