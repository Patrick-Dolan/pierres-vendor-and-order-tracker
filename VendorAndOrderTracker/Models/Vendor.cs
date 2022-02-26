using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public int Id { get; }

    public Vendor(string vendorName)
    {
      Name = vendorName;
      _instances.Add(this);
      Id = _instances.Count;
    }
  }
}