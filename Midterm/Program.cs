public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        ItemName = itemName; 
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        Price = newPrice;
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
       QuantityInStock = QuantityInStock + additionalQuantity;
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        // TODO: Decrease the item's stock quantity by the quantity sold.
        // Make sure the stock doesn't go negative.
        if (IsInStock()) {
            if (quantitySold <= QuantityInStock)
            {
                QuantityInStock = QuantityInStock - quantitySold;
            }
            else {
                QuantityInStock = 0;
            }
        }

    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        if (QuantityInStock > 0)
        {
            return true;
        }

        else {
            return false;
        }
        
    }

    // Print item details
    public void PrintDetails()
    {
        // TODO: Print the details of the item (name, id, price, and stock quantity).
        Console.WriteLine("Name:"+ItemName+"\nID:"+ItemId+"\nPrice:"+Price+"\nStock Quantity:"+QuantityInStock+"\n\n");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);


        // TODO: Implement logic to interact with these objects.
        // Example tasks:
        // 1. Print details of all items.
        // 2. Sell some items and then print the updated details.
        // 3. Restock an item and print the updated details.
        // 4. Check if an item is in stock and print a message accordingly.
        
        
        item1.PrintDetails();
        item2.PrintDetails();
        item1.SellItem(10);
        item1.SellItem(10); 
        item2.SellItem(10);
        item1.PrintDetails();
        item2.PrintDetails();
        item2.RestockItem(5);
        item2.PrintDetails();


        checkInStock(item1);
        checkInStock(item2);

    }
      static void checkInStock(InventoryItem item)
      {

        if (item.IsInStock())
        {
            Console.WriteLine("Item:" + item.ItemId + " " + item.ItemName + " Is in Stock");

        }
        else
        {
            Console.WriteLine("Item:" + item.ItemId + " " + item.ItemName + " Is not in Stock");
        }
      }
}
