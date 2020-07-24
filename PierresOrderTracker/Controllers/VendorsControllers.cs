using Microsoft.AspNetCore.Mvc;
using PierresOrderTracker.Models;
using System.Collections.Generic;

namespace PierresOrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAllVendors();
      return View(allVendors);
    }
    
  }
}