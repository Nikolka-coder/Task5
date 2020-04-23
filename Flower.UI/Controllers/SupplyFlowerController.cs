using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flower.DAL;
using Microsoft.AspNetCore.Mvc;
using Task5_EF.Entities;

namespace Flower.UI.Controllers
{
    public class SupplyFlowerController : Controller
    {
        private readonly DataManager _dataManager;

        public SupplyFlowerController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }
        [HttpGet("Get")]
        public IEnumerable<SupplyFlower> Get() => _dataManager.SupplyFlowers.Get();
        [HttpGet]
        public SupplyFlower FindbyId(int id)
        {
            return _dataManager.SupplyFlowers.FindById(id);
        }
        [HttpPost("Create")]
        public void Create(SupplyFlower item)
        {
            _dataManager.SupplyFlowers.Create(item);
        }
        [HttpPost("Update")]
        public void Update(SupplyFlower item)
        {
            _dataManager.SupplyFlowers.Update(item);
        }
        [HttpPost("Remove")]
        public void Remove(SupplyFlower item)
        {
            _dataManager.SupplyFlowers.Remove(item);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}