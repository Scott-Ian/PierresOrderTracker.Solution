using Microsoft.AspNetCore.Mvc;
using PierresOrderTracker.Models;
using System.Collections.Generic;

namespace PierresOrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/orders")]
    public ActionResult Index()
    {
      List<Order> allOrders = Order.GetAllOrders();
      return View(allOrders);
    }

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.FindVendor(vendorId);
      return View(vendor);
    }
  }
}