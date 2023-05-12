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
      return View();
    }
  }
}