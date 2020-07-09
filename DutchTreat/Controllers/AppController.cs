﻿using DutchTreat.Data;
using DutchTreat.Services;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        private readonly IMailService _mailService;
        private readonly IDutchRepository _repository;

        public AppController(IMailService mailService, IDutchRepository repository)
        {
            _mailService = mailService;
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                //Send the email
                _mailService.SendMessage("test@test.com", model.Subject, $"From: {model.Name} - {model.Email} Message: {model.Message}");
                ViewBag.UserMessage = "Message sent";
                ModelState.Clear();
            }

            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [Authorize]
        public IActionResult ShopMVCVersion()
        {
            var results = _repository.GetAllProducts();

            return View(results);
        }

        //[Authorize] //Removed because you don't want to make people before they shop, just when they checkout
                      //Was just here originally to help illustrate the use of Authorize attribute
        public IActionResult Shop()
        {
            return View();
        }

    }
}
