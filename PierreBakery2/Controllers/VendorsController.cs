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
    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string title, string description, int price, string date)
    {
      Dictionary<string, object> modelToPass = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      string[] splitDateInput = date.Split('-');
      int parsedYear = int.Parse(splitDateInput[0]);
      int parsedMonth = int.Parse(splitDateInput[1]);
      int parsedDay = int.Parse(splitDateInput[2]);
      Order newOrder = new Order(title, description, price, parsedYear, parsedMonth, parsedDay);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorsOrders = foundVendor.Orders;
      modelToPass.Add("order", vendorsOrders);
      modelToPass.Add("vendor", foundVendor);
      return View("Show", modelToPass);
    }
  }
}