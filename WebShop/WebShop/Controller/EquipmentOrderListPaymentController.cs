using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Model;
using WebShop.Service;

namespace WebShop.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentOrderListPaymentController : ControllerBase
    {
        private IEquipmentOrderListPaymentService _equipmentOrderListPaymentService;

        public EquipmentOrderListPaymentController(IEquipmentOrderListPaymentService equipmentOrderListPaymentService)
        {
            _equipmentOrderListPaymentService = equipmentOrderListPaymentService;
        }

        [HttpPost()]
        public async Task<IActionResult> Create([FromBody] EquipmentOrderListPayment dto)
        {
            EquipmentOrderListPayment equipmentOrderListPayment = await _equipmentOrderListPaymentService.Insert(dto);

            if (equipmentOrderListPayment != null)
            {
                return Ok(equipmentOrderListPayment);
            }
            return BadRequest();
        }
    }
}
