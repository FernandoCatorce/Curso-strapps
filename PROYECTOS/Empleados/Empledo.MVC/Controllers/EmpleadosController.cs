﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Empledo.MVC.Models;

namespace Empledo.MVC.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly ILogger<EmpleadoController> _logger;

        public EmpleadoController(ILogger<EmpleadoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Listado()
        {
            return View();
        }
        public IActionResult Registro()
        {
            return View();
        } 
    
    }
}