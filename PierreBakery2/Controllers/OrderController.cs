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
  }
}