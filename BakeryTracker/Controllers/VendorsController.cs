using Microsoft.AspNetCore.Mvc;
using System;
using BakeryTracker.Models;
using System.Collections.Generic;

namespace BakeryTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Index(string[] vendor)
    {
      Vendor newVendor = new Vendor(vendor[0], vendor[1]);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Vendor foundVendor = Vendor.Find(id);
      return View(foundVendor);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string item, int qty)
    {
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(item, qty);
      foundVendor.AddOrder(newOrder);
      return View("Show", foundVendor);
    }
  }
}