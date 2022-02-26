using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesAVendorObject_Vendor()
    {
      Vendor newVendor = new Vendor("Test Vendor Name");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void ReturnName_ReturnVendorName_String()
    {
      string vendorName = "Test Vendor";
      Vendor newVendor = new Vendor(vendorName);
      string result = newVendor.Name;
      Assert.AreEqual(vendorName, result);
    }
  }
}