﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Flower.UI.Controllers
{
    public class WarehouseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}