using Microsoft.AspNetCore.Mvc;
using PierresOrderTracker.Models;
using System.Collections.Generic;

namespace PierresOrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/categories")]
    public ActionResult Index()
    {
      List<Vendors> allVendors = Vendor.GetAllVendors();
      return View(allCategories);
    }
    
  }
}