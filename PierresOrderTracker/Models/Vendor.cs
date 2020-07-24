namespace PierresOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Id { get; set; }
    private static int _nextId = 1; 
    public Vendor (string name, string description)
    {
      Name = name;
      Description = description;
      Id =_nextId;
      _nextId ++;
    }
  }
}