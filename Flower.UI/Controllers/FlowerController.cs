using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flower.DAL;
using Microsoft.AspNetCore.Mvc;
using Task5_EF.Entities;

namespace Flower.UI.Controllers
{
    public class FlowerController : Controller
    {
        private readonly DataManager _dataManager;

        public FlowerController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }
        [HttpGet("Get")]
        public IEnumerable<TheFlower> Get() => _dataManager.TheFlowers.Get();
        [HttpGet]
        public TheFlower FindbyId(int id)
        {
            return _dataManager.TheFlowers.FindById(id);
        }
        [HttpPost("Create")]
        public void Create(TheFlower flower)
        {
            _dataManager.TheFlowers.Create(flower);
        }
        [HttpPost("Update")]
        public void Update(TheFlower flower)
        {
            _dataManager.TheFlowers.Update(flower);
        }
        [HttpPost("Remove")]
        public void Remove(TheFlower flower)
        {
            _dataManager.TheFlowers.Remove(flower);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}