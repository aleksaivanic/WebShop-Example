using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Dto
{
    public class ConfAccTransPaymentDto
    {
        public string ApplicantFirstName { get; set; }
        public string ApplicantLastName { get; set; }
        public string ConferenceName { get; set; }
        public double ConferencePrice { get; set; }
        public string ConferenceStartDate { get; set; }
        public string ConferenceEndDate { get; set; }
        public string AccommodationName { get; set; }
        public double AccommodationPrice { get; set; }
        public string TransportName { get; set; }
        public double TransportPrice { get; set; }
        public bool Live { get; set; }

        public ConfAccTransPaymentDto()
        {
        }
    }
}
