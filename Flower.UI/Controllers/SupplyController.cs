using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flower.DAL;
using Microsoft.AspNetCore.Mvc;
using Task5_EF.Entities;

namespace Flower.UI.Controllers
{
    public class SupplyController : Controller
    {
        private readonly DataManager _dataManager;

        public SupplyController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }
        [HttpGet("Get")]
        public IEnumerable<Supply> Get() => _dataManager.Supplies.Get();
        [HttpGet]
        public Supply FindbyId(int id)
        {
            return _dataManager.Supplies.FindById(id);
        }
        [HttpPost("Create")]
        public void Create(Supply item)
        {
            _dataManager.Supplies.Create(item);
        }
        [HttpPost("Update")]
        public void Update(Supply item)
        {
            _dataManager.Supplies.Update(item);
        }
        [HttpPost("Remove")]
        public void Remove(Supply item)
        {
            _dataManager.Supplies.Remove(item);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}