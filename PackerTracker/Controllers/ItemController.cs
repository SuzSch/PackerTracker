using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
    public class ItemsController : Controller
    {
        [HttpGet("/items/new")]
        public ActionResult New()
        {
            return View();
        }
        [HttpPost("/items")]
        public ActionResult Create(string name, bool packed, bool purchased, int weight)
        {
            Item newItem = new Item(name, packed, purchased, weight);
            return RedirectToAction("Index");

        }
        [HttpGet("/items")]
        public ActionResult Index()
        {
            List<Item> _instances = Item.GetAll();
            return View(_instances);
        }
    }
}