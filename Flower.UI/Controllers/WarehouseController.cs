using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flower.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Flower.UI.Controllers
{
    public class WarehouseController : Controller
    {
        private readonly DataManager dataManager;

        public WarehouseController(DataManager _dataManager)
        {
            dataManager = _dataManager;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}