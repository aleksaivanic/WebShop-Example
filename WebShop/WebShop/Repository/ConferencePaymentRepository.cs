using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Database;
using WebShop.Model;

namespace WebShop.Repository
{
    public class ConferencePaymentRepository : MySqlRepository<ConferencePayment>, IConferencePaymentRepository
    {
        public ConferencePaymentRepository(WebShopDbContext context)
           : base(context)
        { }
    }
}
