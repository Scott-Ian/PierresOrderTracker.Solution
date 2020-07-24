using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresOrderTracker.Models;
using System;
using System.Collections.Generic;

namespace PierresOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAllOrders();
    }

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

    [TestMethod]
    public void GetAllOrders_ReturnsAllInstancesOfOrder_ListOfOrders()
    {
      Order testOrder1 = new Order("Flour Purchase", "Flour for daily operations", 20, "January 11, 2020");
      Order testOrder2 = new Order("Cleaning", "Deep cleaning of kitchen", 200, "January 12, 2020");
      Order testOrder3 = new Order("Payroll", "Weekly payroll service fee", 100, "January 13, 2020");

      List <Order> allTestOrders = new List <Order> {};
      allTestOrders.Add(testOrder1);
      allTestOrders.Add(testOrder2);
      allTestOrders.Add(testOrder3);

      List <Order> allInstancesOfOrder = Order.GetAllOrders();

      CollectionAssert.AreEqual(allTestOrders, allInstancesOfOrder);
    }

    [TestMethod]
    public void FindId_FindOrderById_Order()
    {
      Order testOrder1 = new Order("Flour Purchase", "Flour for daily operations", 20, "January 11, 2020");
      Order testOrder2 = new Order("Cleaning", "Deep cleaning of kitchen", 200, "January 12, 2020");
      Order testOrder3 = new Order("Payroll", "Weekly payroll service fee", 100, "January 13, 2020");

      Order pulledOrder = Order.FindOrder(3);

      Assert.AreEqual(testOrder3, pulledOrder);
    }

    [TestMethod]
    public void EditOrder_UpdatesValuesOfOrderObject_Order()
    {
      Order testOrder= new Order("Flour Purchase", "Flour for daily operations", 20, "January 11, 2020");
      string newTitle = "Sugar Purchase";
      string newDescription = "For weeks batch of doughnuts";
      int newPrice = 10;
      string newDate = "July 24, 2020";

      Order.EditOrder(1, newTitle, newDescription, newPrice, newDate);

      Assert.AreEqual(newTitle, testOrder.Title);
      Assert.AreEqual(newDescription, testOrder.Description);
      Assert.AreEqual(newPrice, testOrder.Price);
      Assert.AreEqual(newDate, testOrder.Date);
    }

    [TestMethod]
    public void DeleteOrder_RemovesOrderFromList_Null()
    {
      Order testOrder1 = new Order("Flour Purchase", "Flour for daily operations", 20, "January 11, 2020");
      Order testOrder2 = new Order("Cleaning", "Deep cleaning of kitchen", 200, "January 12, 2020");
      Order testOrder3 = new Order("Payroll", "Weekly payroll service fee", 100, "January 13, 2020");

      Order.DelteOrder(3);

      List<Order> expectedOrders = new List <Order> {};
      expectedOrders.Add(testOrder1);
      expectedOrders.Add(testOrder2);

      CollectionAssert.AreEqual(expectedOrders, Order.GetAllOrders());
    }

  }
}