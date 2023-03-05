using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class ExtraPreOrder:BaseEntity
    {
        public int ExtraID { get; set; }
        public int PreOrderID { get; set; }

        //Relational Properties

        public virtual Extra Extra { get; set; }
        public virtual PreOrder PreOrder { get; set; }
    }
}
