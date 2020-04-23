using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flower.DAL;
using Microsoft.AspNetCore.Mvc;
using Task5_EF.Entities;

namespace Flower.UI.Controllers
{
    public class PlantationFlowerController : Controller
    {
        private readonly DataManager _dataManager;

        public PlantationFlowerController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }
        [HttpGet("Get")]
        public IEnumerable<PlantationFlower> Get() => _dataManager.PlantationFlowers.Get();
        [HttpGet]
        public PlantationFlower FindbyId(int id)
        {
            return _dataManager.PlantationFlowers.FindById(id);
        }
        [HttpPost("Create")]
        public void Create(PlantationFlower item)
        {
            _dataManager.PlantationFlowers.Create(item);
        }
        [HttpPost("Update")]
        public void Update(PlantationFlower item)
        {
            _dataManager.PlantationFlowers.Update(item);
        }
        [HttpPost("Remove")]
        public void Remove(PlantationFlower item)
        {
            _dataManager.PlantationFlowers.Remove(item);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}