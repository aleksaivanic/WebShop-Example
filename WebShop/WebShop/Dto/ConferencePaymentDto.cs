using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Dto
{
    public class ConferencePaymentDto
    {
        public string ApplicantFirstName { get; set; }
        public string ApplicantLastName { get; set; }
        public string ConferenceName { get; set; }
        public double ConferencePrice { get; set; }
        public string ConferenceStartDate { get; set; }
        public string ConferenceEndDate { get; set; }
        public bool Live { get; set; }

        public ConferencePaymentDto()
        {
        }
    }
}
