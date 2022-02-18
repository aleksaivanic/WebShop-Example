using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Model
{
    public class EquipmentOrderItem
    {
        public int Id { get; set; }
        public string ProductType { get; set; }
        public double PriceOffer { get; set; }
        public int RequiredQuantity { get; set; }
        public int EquipmentOrderListPaymentId { get; set; }
        public virtual EquipmentOrderListPayment EquipmentOrderListPayment { get; set; }

        public EquipmentOrderItem()
        {
        }
    }
}
