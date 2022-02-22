using CinemaTickets.Data;
using CinemaTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly ActorsService _service;

        public ActorsController(ActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }
    }
}
