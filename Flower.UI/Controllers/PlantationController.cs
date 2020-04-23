using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flower.DAL;
using Microsoft.AspNetCore.Mvc;
using Task5_EF.Entities;

namespace Flower.UI.Controllers
{
    public class PlantationController : Controller
    {
        private readonly DataManager _dataManager;

        public PlantationController(DataManager dataManager)
        {
           _dataManager = dataManager;
        }
        [HttpGet("Get")]
        public IEnumerable<Plantation> Get() => _dataManager.Plantations.Get();
        [HttpGet]
        public Plantation FindbyId(int id)
        {
            return _dataManager.Plantations.FindById(id);
        }
        [HttpPost("Create")]
        public void Create(Plantation item)
        {
            _dataManager.Plantations.Create(item);
        }
        [HttpPost("Update")]
        public void Update(Plantation item)
        {
            _dataManager.Plantations.Update(item);
        }
        [HttpPost("Remove")]
        public void Remove(Plantation item)
        {
            _dataManager.Plantations.Remove(item);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}