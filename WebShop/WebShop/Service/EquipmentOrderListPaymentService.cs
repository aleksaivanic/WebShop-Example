using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Model;
using WebShop.Repository;

namespace WebShop.Service
{
    public class EquipmentOrderListPaymentService : IEquipmentOrderListPaymentService
    {
        private IEquipmentOrderListPaymentRepository _equipmentOrderListPaymentRepository;

        public EquipmentOrderListPaymentService(IEquipmentOrderListPaymentRepository equipmentOrderListPaymentRepository)
        {
            _equipmentOrderListPaymentRepository = equipmentOrderListPaymentRepository;
        }
        public Task Delete(EquipmentOrderListPayment entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EquipmentOrderListPayment>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<EquipmentOrderListPayment> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<EquipmentOrderListPayment> Insert(EquipmentOrderListPayment entity)
        {
            return _equipmentOrderListPaymentRepository.Insert(entity);
        }

        public Task<EquipmentOrderListPayment> Update(EquipmentOrderListPayment entity)
        {
            throw new NotImplementedException();
        }
    }
}
