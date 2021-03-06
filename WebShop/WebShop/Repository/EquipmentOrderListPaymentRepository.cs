using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Database;
using WebShop.Model;

namespace WebShop.Repository
{
    public class EquipmentOrderListPaymentRepository : MySqlRepository<EquipmentOrderListPayment>, IEquipmentOrderListPaymentRepository
    {
        public EquipmentOrderListPaymentRepository(WebShopDbContext context)
           : base(context)
        { }
    }
}
