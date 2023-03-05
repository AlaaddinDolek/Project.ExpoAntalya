using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Stand:BaseEntity
    {
        public string StandNo { get; set; }

        public int? SaloonID { get; set; }

        public string Area { get; set; }


        //Relational Properties

        public virtual Saloon Saloon { get; set; }
        public virtual PreOrder PreOrder { get; set; }
        public virtual List<IssueStand> IssueStands { get; set; }

    }
}
