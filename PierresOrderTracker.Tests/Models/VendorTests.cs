using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresOrderTracker.Models;
using System;
using System.Collections.Generic;

namespace PierresOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAllVendors();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor testVendor = new Vendor("SampleName", "sampleDescription");
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Phils Pharmaceuticals";
      Vendor testVendor = new Vendor(name, "description");
      Assert.AreEqual(name, testVendor.Name);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string name = "Phils Pharmaceuticals";
      string description ="Oxycodone Dealer";
      Vendor testVendor = new Vendor(name, description);
      Assert.AreEqual(description, testVendor.Description);
    }

    [TestMethod]
    public void GetId_ReturnsUniqueId_Int()
    {
      Vendor testVendor1 = new Vendor("name1", "description1");
      Vendor testVendor2 = new Vendor("name2", "description2");

      Assert.AreNotEqual(testVendor1.Id, testVendor2.Id);
    }

    [TestMethod]
    public void GetAllVendors_ReturnsEmptyList_VendorList()
    {
      List<Vendor> vendorList = new List<Vendor>{};
      CollectionAssert.AreEqual(vendorList, Vendor.GetAllVendors());
    }

    [TestMethod]
    public void GetAllVendors_ReturnsEveryInstantiatedVendor_ListOfVendors()
    {
      Vendor testVendor1 = new Vendor("name1", "description1");
      Vendor testVendor2 = new Vendor("name2", "description2");
      Vendor testVendor3 = new Vendor("name3", "description3");
      List<Vendor> vendorList = new List<Vendor>{};
      vendorList.Add(testVendor1);
      vendorList.Add(testVendor2);
      vendorList.Add(testVendor3);

      CollectionAssert.AreEqual(vendorList, Vendor.GetAllVendors());
    }

    [TestMethod]
    public void GetOrders_ReturnsEmptyList_OrderList()
    {
      Vendor testVendor = new Vendor("name", "description");
      List<Order> orderList = new List<order>{};
      CollectionAssert.AreEqual(orderList, Vendor.Orders);
    }

    [TestMethod]
    public void GetOrders_ReturnsEveryOrderOfVendor_ListOfVendors()
    {
      Vendor sallysSubs = new Vendor("Sally's Subs", "Favorite Sub Place");

      Order purchase1 = new Order();
      Order purchase2 = new Order();
      Order purchase3 = new Order();
      sampleOrders.Add(purchase1);
      sampleOrders.Add(purchase2);
      sampleOrders.Add(purchase3);
      List<Order> sampleOrders = new List<Order> {};

      sallysSubs.AddOrder(purchase1);
      sallysSubs.AddOrder(purchase1);
      sallysSubs.AddOrder(purchase1);

      CollectionAssert.AreEqual(sampleOrders, sallysSubs.Orders);
    }
  }
}