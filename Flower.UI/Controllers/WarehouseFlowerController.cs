using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flower.DAL;
using Microsoft.AspNetCore.Mvc;
using Task5_EF.Entities;

namespace Flower.UI.Controllers
{
    public class WarehouseFlowerController : Controller
    {
        private readonly DataManager _dataManager;

        public WarehouseFlowerController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }
        [HttpGet("Get")]
        public IEnumerable<WarehouseFlower> Get() => _dataManager.WarehouseFlowers.Get();
        [HttpGet]
        public WarehouseFlower FindbyId(int id)
        {
            return _dataManager.WarehouseFlowers.FindById(id);
        }
        [HttpPost("Create")]
        public void Create(WarehouseFlower item)
        {
            _dataManager.WarehouseFlowers.Create(item);
        }
        [HttpPost("Update")]
        public void Update(WarehouseFlower item)
        {
            _dataManager.WarehouseFlowers.Update(item);
        }
        [HttpPost("Remove")]
        public void Remove(WarehouseFlower item)
        {
            _dataManager.WarehouseFlowers.Remove(item);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}