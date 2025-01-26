﻿using eTickets.Data;
using eTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ProducersController : Controller
    {
        public readonly IProducersService _service;
        public ProducersController(IProducersService service)
        {
            _service = service ;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }
    }
}
