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
      Order testOrder = new Order("Title", "Description");
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitleOfOrder_String()
    {
      string title = "Flour Purchase";
      Order testOrder = new Order(title, "description");
      Assert.AreEqual(title, testOrder.Title);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescriptionOfOrder_String()
    {
      string description = "Sugard Delivery";
      Order testOrder = new Order("Title", description);

      Assert.AreEqual(description, testOrder.Description);
    }

  }
}