using System;
using System.Collections.Generic;

namespace PierresOrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    private static int _nextId = 1;
    private static List<Order> _instances = new List<Order> {};
    public Order (string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      Id = _nextId;
      _nextId ++;
      _instances.Add(this);
    }

    public static List<Order> GetAllOrders()
    {
      return _instances;
    }

    public static void ClearAllOrders()
    {
      _instances.Clear();
    }
  }
}