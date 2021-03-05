using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PierreBakery2.Models;

namespace PierreBakery2.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName)
    {
      Vendor newVendor = new Vendor(vendorName);
      return RedirectToAction("Index");
    }
    [HttpGet("vendors/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> modelToPass = new Dictionary<string, object>();
      Vendor vendorToPass = Vendor.Find(id);
      List<Order> ordersToPass = vendorToPass.Orders;
      modelToPass.Add("vendor", vendorToPass);
      modelToPass.Add("order", ordersToPass);
      return View(modelToPass);
    }
  }
}