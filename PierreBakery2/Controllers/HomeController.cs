using Microsoft.AspNetCore.Mvc;

namespace PierreBakery2.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}