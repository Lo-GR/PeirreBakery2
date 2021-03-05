using Microsoft.AspNetCore.Mvc;
using PierreBakery2.Models;
using System.Collections.Generic;

namespace PierreBakery2.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/vendors/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }
    [HttpGet("/vendors/{vendorId]/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> modelToPass = new Dictionary<string, object>();
      modelToPass.Add("order", order);
      modelToPass.Add("vendor", vendor);
      return View(modelToPass);
    }
  }
}