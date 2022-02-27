using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

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

    [TestMethod]
    public void ReturnId_ReturnsVendorId_Int()
    {
      string vendorName = "Test Vendor";
      Vendor newVendor = new Vendor(vendorName);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void OverloadConstructorDescription_ReturnsDescription_String()
    {
      string vendorName = "Vendor Name Here";
      string vendorDescription = "A vendor that pierre sells to";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      string result = newVendor.Description;
      Assert.AreEqual(vendorDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name1 = "Tester Vendor 1";
      string name2 = "Tester Vendor 2";
      Vendor newVendor1 = new Vendor(name1);
      Vendor newVendor2 = new Vendor(name2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsSpecificVendor_Vendor()
    {
      string name1 = "Vendor 1";
      string name2 = "Vendor 2";
      Vendor newVendor1 = new Vendor(name1);
      Vendor newVendor2 = new Vendor(name2);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AttachsOrderToVendor_OrderList()
    {
      Order newOrder = new Order("title", "description", 15, "date");
      List<Order> newList = new List<Order> { newOrder };
      string vendorName = "Vendor 1";
      Vendor newVendor = new Vendor(vendorName);
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}