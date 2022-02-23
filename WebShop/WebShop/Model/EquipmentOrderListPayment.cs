using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Model
{
    public class EquipmentOrderListPayment
    {
        public int Id { get; set; }
        public virtual List<EquipmentOrderItem> EquipmentOrderItems { get; set; }
        public string SupplierName { get; set; }
        public string SupplierUsername { get; set; } 

        public EquipmentOrderListPayment()
        {
        }
    }
}
