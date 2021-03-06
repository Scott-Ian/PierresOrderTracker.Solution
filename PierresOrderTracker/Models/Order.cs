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
      _nextId = 1;
    }

    public static Order FindOrder(int searchId)
    {
      for (int i = 0; i < _instances.Count; i++)
      {
        if(_instances[i].Id == searchId)
        {
          return _instances[i];
        }
      }
      return null;
    }

    public static void EditOrder(int searchId, string newTitle, string newDescription, int newPrice, string newDate)
    {
      Order orderToEdit = FindOrder(searchId);
      orderToEdit.Title = newTitle;
      orderToEdit.Description = newDescription;
      orderToEdit.Price = newPrice;
      orderToEdit.Date = newDate;
    }

    public static void DeleteOrder(int searchId)
    {
      Order toDelete = Order.FindOrder(searchId);
      _instances.Remove(toDelete);
    }


  }
}