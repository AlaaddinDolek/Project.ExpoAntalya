using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Order:BaseEntity
    {

        public int EmployeeID { get; set; }


        // Relational Properties

        public virtual List<PreOrder> PreOrders { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
