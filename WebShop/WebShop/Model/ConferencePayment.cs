using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Model
{
    public class ConferencePayment
    {
        public int Id { get; set; }
        public string ApplicantFirstName { get; set; }
        public string ApplicantLastName { get; set; }
        public string ConferenceName { get; set; }
        public double ConferencePrice { get; set; }
        public string ConferenceStartDate { get; set; }
        public string ConferenceEndDate { get; set; }
        public bool Live { get; set; }
        public int? AccommodationPaymentId { get; set; }
        public virtual AccommodationPayment AccommodationPayment { get; set; }
        public int? TransportPaymentId { get; set; }
        public virtual TransportPayment TransportPayment { get; set; }

        public ConferencePayment()
        {
        }
    }
}
