using AutoMapper;
using DutchTreat.Data;
using DutchTreat.Data.Entities;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutchTreat.Controllers
{
    [Route("/api/orders/{orderid}/items")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class OrderItemsController : Controller
    {
        private readonly IDutchRepository _repository;
        private readonly ILogger<OrdersController> _logger;
        private readonly IMapper _mapper;

        public OrderItemsController(IDutchRepository repository,
            ILogger<OrdersController> logger,
            IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get(int orderId)
        {
            try
            {
                //var order = _repository.GetOrderById(orderId);
                var order = _repository.GetOrderById(User.Identity.Name, orderId);

                if (order != null)
                {
                    return Ok(_mapper.Map<IEnumerable<OrderItem>, IEnumerable<OrderItemViewModel>>(order.Items));
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get order items: {ex}");
                return BadRequest("Failed to get order items");
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int orderId, int id)
        {
            try
            {
                var order = _repository.GetOrderById(User.Identity.Name, orderId);

                if (order != null)
                {
                    var item = order.Items.Where(i => i.Id == id).FirstOrDefault();

                    if (item != null)
                    {
                        return Ok(_mapper.Map<OrderItem, OrderItemViewModel>(item));
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get order item: {ex}");
                return BadRequest("Failed to get order item");
            }
        }

        //TODO Add action methods for POST and PUT and DELETE etc.
    }
}
