using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesAnOrderObject_Order()
    {
      string title = "7 Bread";
      string description = "The vendor wants bread this time";
      int price = 15;
      string date = "january 12";
      Order newOrder = new Order(title, description, price, date);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsOrderTitle_String()
    {
      string title = "7 Bread";
      string description = "The vendor wants bread this time";
      int price = 15;
      string date = "january 12";
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Title;
      Assert.AreEqual(title, newOrder.Title);
    }
    [TestMethod]
    public void GetDescription_ReturnsOrderDescription_String()
    {
      string title = "7 Bread";
      string description = "The vendor wants bread this time";
      int price = 15;
      string date = "january 12";
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Description;
      Assert.AreEqual(description, newOrder.Description);
    }
    [TestMethod]
    public void GetPrice_ReturnsOrderPrice_Int()
    {
      string title = "7 Bread";
      string description = "The vendor wants bread this time";
      int price = 15;
      string date = "january 12";
      Order newOrder = new Order(title, description, price, date);
      int result = newOrder.Price;
      Assert.AreEqual(price, newOrder.Price);
    }
    [TestMethod]
    public void GetDate_ReturnsOrderDate_String()
    {
      string title = "7 Bread";
      string description = "The vendor wants bread this time";
      int price = 15;
      string date = "january 12";
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Date;
      Assert.AreEqual(date, newOrder.Date);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrderList_OrderList()
    {
      Order newOrder1 = new Order("title", "description", 15, "date");
      Order newOrder2 = new Order("title", "description", 18, "date");
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      Order newOrder = new Order("title", "description", 15, "date");
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }
  }
}