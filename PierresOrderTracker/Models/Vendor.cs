using System.Collections.Generic;

namespace PierresOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; set; }
    private static int _nextId = 1; 
    private static List<Vendor> _instances = new List<Vendor> {}; 
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
    }
  }
}