namespace VendorAndOrderTracker
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }

    public Order(string title)
    {
      Title = title;
    }
    public Order(string title, string description)
      : this(title)
    {
      Description = description;
    }
  }
}