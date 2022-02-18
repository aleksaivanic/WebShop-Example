using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Dto;
using WebShop.Model;
using WebShop.Service;

namespace WebShop.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConferencePaymentController : ControllerBase
    {
        private IConferencePaymentService _conferencePaymentService;

        public ConferencePaymentController(IConferencePaymentService conferencePaymentService)
        {
            _conferencePaymentService = conferencePaymentService;
        }

        [HttpPost()]
        public async Task<IActionResult> Create([FromBody] ConferencePaymentDto dto)
        {
            ConferencePayment conferencePayment = await _conferencePaymentService.Insert(new ConferencePayment{
                ConferenceName = dto.ConferenceName,
                ConferencePrice = dto.ConferencePrice,
                ApplicantFirstName = dto.ApplicantFirstName,
                ApplicantLastName = dto.ApplicantLastName,
                ConferenceStartDate = dto.ConferenceStartDate,
                ConferenceEndDate = dto.ConferenceEndDate,
                Live = dto.Live
            });

            if (conferencePayment != null)
            {
                return Ok(conferencePayment);
            }
            return BadRequest();
        }

        [HttpPost("accTransConf")]
        public async Task<IActionResult> CreateAccTransConf([FromBody] ConfAccTransPaymentDto dto)
        {
            ConferencePayment conferencePayment = await _conferencePaymentService.Insert(new ConferencePayment
            {
                ConferenceName = dto.ConferenceName,
                ConferencePrice = dto.ConferencePrice,
                ApplicantFirstName = dto.ApplicantFirstName,
                ApplicantLastName = dto.ApplicantLastName,
                ConferenceStartDate = dto.ConferenceStartDate,
                ConferenceEndDate = dto.ConferenceEndDate,
                Live = dto.Live,
                AccommodationPayment = new AccommodationPayment { Name = dto.AccommodationName, Price = dto.AccommodationPrice},
                TransportPayment = new TransportPayment { Name = dto.TransportName, Price = dto.TransportPrice}
            });

            if (conferencePayment != null)
            {
                return Ok(conferencePayment);
            }
            return BadRequest();
        }

        [HttpGet()]
        public async Task<IActionResult> Get()
        {
            //List<ConferencePayment> conferencePayments = await _conferencePaymentService.GetAll();

            return Ok(await _conferencePaymentService.GetAll());
        }
    }
}
