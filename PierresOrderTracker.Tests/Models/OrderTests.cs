using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresOrderTracker.Models;
using System;
using System.Collections.Generic;

namespace PierresOrderTracker.Tests
{
  [TestClass]
  public class OrderTests //: IDisposable
  {
    // public void Dispose()
    // {

    // }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order testOrder = new Order("Title", "Description", 5, "date");
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitleOfOrder_String()
    {
      string title = "Flour Purchase";
      Order testOrder = new Order(title, "description", 5, "date");
      Assert.AreEqual(title, testOrder.Title);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescriptionOfOrder_String()
    {
      string description = "Sugard Delivery";
      Order testOrder = new Order("Title", description, 5, "date");

      Assert.AreEqual(description, testOrder.Description);
    }

    [TestMethod]
    public void GetPrice_ReturnsPriceOfOrder_Int()
    {
      int price = 15;
      Order testOrder = new Order("Title", "Description", price, "date");

      Assert.AreEqual(price, testOrder.Price);
    }

    [TestMethod]
    public void GetDate_ReturnsDateOfOrder_String()
    {
      string date = "July 24, 2020";
      Order testOrder = new Order("Title", "Description", 200, date);
    }

    [TestMethod]
    public void GetId_ReturnsUniqueId_Int()
    {
      Order testOrder1 = new Order("Title", "Description", 200, "January 11, 2020");
      Order testOrder2 = new Order("Title", "Description", 200, "January 12, 2020");

      Assert.AreNotEqual(testOrder1.Id, testOrder2.Id);
    }

  }
}