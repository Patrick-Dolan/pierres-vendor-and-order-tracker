using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTests 
  {
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
  }
}