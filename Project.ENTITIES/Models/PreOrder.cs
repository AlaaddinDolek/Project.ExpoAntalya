using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class PreOrder:BaseEntity
    {
        public PreOrder()
        {

        }
        public decimal UnitPrice { get; set; }
        public  Activity Active { get; set; }

        public int OrderID { get; set; }



        //Relational Properties

        public virtual List<ExtraPreOrder> ExtraPreOrders { get; set; }

        public virtual Stand Stand { get; set; }

        public virtual Order Order { get; set; }


        //public override string ToString()
        //{
        //    if (Extras.Count <1)
        //    {
        //        return $"{Stand.Saloon.SaloonName} fiyatı => {UnitPrice:C2}";
        //    }
        //    string extras = null;

        //    foreach (Extra item in Extras)
        //    {
        //        extras += $"{item.Name}, ";
        //    }

        //    return $"{Stand.Saloon.SaloonName} Salonu, İçindeki extralar => {extras} Fiyat: {UnitPrice:C2}";
        //}

        //public void TutarHesapla()
        //{
        //    UnitPrice = Stand.Saloon.UnitPrice;

        //    switch (Active)
        //    {
        //        case Activity.High:
        //            UnitPrice += 150;
        //            break;
        //        case Activity.Medium:
        //            UnitPrice += 100;
        //            break;
        //            case Activity.Low:
        //            UnitPrice += 50;
        //            break;
              
        //    }

        //    foreach (Extra item in Extras)
        //    {
        //        UnitPrice += item.UnitPrice;
        //    }


            

       // }
    }
}
