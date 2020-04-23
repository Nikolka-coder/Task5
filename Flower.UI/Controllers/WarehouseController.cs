﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flower.DAL;
using Microsoft.AspNetCore.Mvc;
using Task5_EF.Entities;

namespace Flower.UI.Controllers
{
    public class WarehouseController : Controller
    {
        private readonly DataManager _dataManager;

        public WarehouseController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }
        [HttpGet("Get")]
        public IEnumerable<Warehouse> Get() => _dataManager.Warehouses.Get();
        [HttpGet]
        public Warehouse FindbyId(int id)
        {
            return _dataManager.Warehouses.FindById(id);
        }
        [HttpPost("Create")]
        public void Create(Warehouse item)
        {
            _dataManager.Warehouses.Create(item);
        }
        [HttpPost("Update")]
        public void Update(Warehouse item)
        {
            _dataManager.Warehouses.Update(item);
        }
        [HttpPost("Remove")]
        public void Remove(Warehouse item)
        {
            _dataManager.Warehouses.Remove(item);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}