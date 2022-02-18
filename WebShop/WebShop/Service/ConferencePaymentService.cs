using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Model;
using WebShop.Repository;

namespace WebShop.Service
{
    public class ConferencePaymentService : IConferencePaymentService
    {
        private IConferencePaymentRepository _conferencePaymentRepository;

        public ConferencePaymentService(IConferencePaymentRepository conferencePaymentRepository)
        {
            _conferencePaymentRepository = conferencePaymentRepository;
        }
        public Task Delete(ConferencePayment entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ConferencePayment>> GetAll()
        {
            return _conferencePaymentRepository.GetAll();
        }

        public Task<ConferencePayment> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ConferencePayment> Insert(ConferencePayment entity)
        {
            return _conferencePaymentRepository.Insert(entity);
        }

        public Task<ConferencePayment> Update(ConferencePayment entity)
        {
            throw new NotImplementedException();
        }
    }
}
