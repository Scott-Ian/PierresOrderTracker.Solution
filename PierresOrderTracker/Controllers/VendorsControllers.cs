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

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string name, string description)
    {
      Vendor newVendor = new Vendor(name, description);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{Id}")]
    public ActionResult Show(int Id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.FindVendor(Id);
      List<Order> vendorOrders = selectedVendor.GetOrders();
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }

    [HttpGet("/vendors/{Id}/edit")]
    public ActionResult Edit(int id)
    {
      return View(Vendor.FindVendor(id));
    }

    [HttpPost("/vendors/{Id}/")]
    public ActionResult Update (string id, string name, string description)
    {
      int intId = int.Parse(id);
      Vendor.EditVendor(intId, name, description);
      return RedirectToAction("Index");
    }
    
  }
}