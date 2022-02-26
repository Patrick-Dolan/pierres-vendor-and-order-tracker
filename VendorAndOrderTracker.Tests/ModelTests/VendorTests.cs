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
  }
}