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
      Order.ClearAllOrders();
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
      string name = "Phils Fishes";
      string description ="Fish Sauce Provider";
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
      List<Order> orderList = new List<Order>{};
      List<Order> testVendorOrders = testVendor.GetOrders();
      CollectionAssert.AreEqual(orderList, testVendorOrders);
    }

    [TestMethod]
    public void GetOrders_ReturnsEveryOrderOfVendor_ListOfVendors()
    {
      Vendor sallysSubs = new Vendor("Sally's Subs", "Favorite Sub Place");

      Order purchase1 = new Order("Title", "Description", 5, "July 24");
      Order purchase2 = new Order("Title", "Description", 10, "January 12, 2020");
      Order purchase3 = new Order("Title", "Description", 15, "September 19 1992");
      List<Order> sampleOrders = new List<Order> {};
      sampleOrders.Add(purchase1);
      sampleOrders.Add(purchase2);
      sampleOrders.Add(purchase3);

      sallysSubs.AddOrder(purchase1);
      sallysSubs.AddOrder(purchase2);
      sallysSubs.AddOrder(purchase3);

      List<Order> sallysOrders = sallysSubs.GetOrders();

      CollectionAssert.AreEqual(sampleOrders, sallysOrders);
    }

    [TestMethod]
    public void FindId_FindVendorById_Vendor()
    {
      Vendor sallysSubs = new Vendor("Sally's Subs", "Favorite Sub Place");
      Vendor philsFishes = new Vendor("Phils Fishes", "Fish sauce supplier");

      Vendor pulledVendor = Vendor.FindVendor(2);

      Assert.AreEqual(philsFishes, pulledVendor);
    }

    [TestMethod]
    public void EditVendor_UpdatesValuesOfVendorObject_Vendor()
    {
      Vendor testVendor = new Vendor("Sally's Subs", "Favorite Sub Place");
      string newName = "Peter's Pies";
      string newDescription = "Favorite Pie Place";
      Vendor.EditVendor(1, newName, newDescription);

      Assert.AreEqual(newName, testVendor.Name);
      Assert.AreEqual(newDescription, testVendor.Description);
    }

    [TestMethod]
    public void DeleteVendor_RemovesVendorFromList_Null()
    {
      Vendor sallysSubs = new Vendor("Sally's Subs", "Favorite Sub Place");
      Vendor philsFishes = new Vendor("Phils Fishes", "Fish Sauce Supplier");
      Vendor sliceAndDice = new Vendor ("Slice And Dice", "Knife Supplier");
      
      Vendor.DeleteVendor(2);
      List<Vendor> expectedList = new List<Vendor>{};
      expectedList.Add(sallysSubs);
      expectedList.Add(sliceAndDice);

      CollectionAssert.AreEqual(expectedList, Vendor.GetAllVendors());
    }

    [TestMethod]
    public void RemoveOrder_RemovesOrderFromVendor_Null()
    {
      Vendor sallysSubs = new Vendor("Sally's Subs", "Favorite Sub Place");

      Order purchase1 = new Order("Title", "Description", 5, "July 24");
      Order purchase2 = new Order("Title", "Description", 10, "January 12, 2020");
      Order purchase3 = new Order("Title", "Description", 15, "September 19 1992");

      sallysSubs.AddOrder(purchase1);
      sallysSubs.AddOrder(purchase2);
      sallysSubs.AddOrder(purchase3);

      List<Order> sampleOrders = new List<Order> {};
      sampleOrders.Add(purchase1);
      sampleOrders.Add(purchase2);


      List<Order> sallysOrders = sallysSubs.GetOrders();

      sallysSubs.RemoveOrder(3);

      CollectionAssert.AreEqual(sampleOrders, sallysOrders);
    }

  }
}