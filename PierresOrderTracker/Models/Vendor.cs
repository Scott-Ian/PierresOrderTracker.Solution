using System.Collections.Generic;

namespace PierresOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    private static int _nextId = 1; 
    private static List<Vendor> _instances = new List<Vendor> {}; 
    private List<Order> _orders = new List<Order> {}; 
    public Vendor (string name, string description)
    {
      Name = name;
      Description = description;

      Id =_nextId;
      _nextId ++;
      _instances.Add(this);
    }

    public static List<Vendor> GetAllVendors()
    {
      return _instances;
    }

    public static void ClearAllVendors()
    {
      _instances.Clear();
      _nextId = 1;
    }

    public List<Order> GetOrders ()
    {
      return _orders;
    }

    public void AddOrder(Order order)
    {
      _orders.Add(order);
    }

    // Will return the latest Vendor if no vendor is found!
    public static Vendor FindVendor(int searchId)
    {
      for (int i = 0; i < _instances.Count; i++)
      {
        if(_instances[i].Id == searchId)
        {
          return _instances[i];
        }
      }
      return _instances[_instances.Count -1];
    }

    public static void EditVendor(int searchId, string newName, string newDescription)
    {
      Vendor vendorToEdit = FindVendor(searchId);
      vendorToEdit.Name = newName;
      vendorToEdit.Description = newDescription;
    }

    public static void DeleteVendor(int searchId)
    {
      Vendor toDelete = Vendor.FindVendor(searchId);
      _instances.Remove(toDelete);
    }

    public void RemoveOrder(int searchId)
    {
      Order toRemove = Order.FindOrder(searchId);
      _orders.Remove(toRemove);
      Order.DeleteOrder(searchId);
    }
  }
}