// The easiest way to declare an event is to put the event keyword in front of a delegate member.
// Code within the containing type has full access and can treat the event as a delegate.
// Code outside of the containing type can only perform += and -= operations on the event.

var stock = new Stock("MSFT");
stock.PriceChanged += ReportPriceChange;
stock.PriceChanged += BestDeal;
stock.Price = 123;
stock.Price = 456;
//stock.PriceChanged -= ReportPriceChange;
stock.Price = 500;
stock.Price = 80;
stock.Price = 180;
stock.Price = 120;
stock.Price = 110;
stock.Price = 90;
stock.Price = 110;

void ReportPriceChange(decimal oldPrice, decimal newPrice) // subscriber
{
    Console.WriteLine("Price changed from " + oldPrice + " to " + newPrice);
}

void BestDeal (decimal oldPrice, decimal newPrice)
{
    if (newPrice < 100)
        Console.WriteLine($"Deal! The best price is {newPrice}!");
}

public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);

public struct Stock
{
    string symbol;
    decimal price;

    public Stock(string symbol) { this.symbol = symbol; }

    public event PriceChangedHandler PriceChanged; // broadcaster

    public decimal Price
    {
        get { return price; }
        set
        {
            if (price == value) return;         // Exit if nothing has changed
            decimal oldPrice = price;
            price = value;
            if (PriceChanged != null)           // If invocation list not empty (subscribes list isn't empty),
                PriceChanged.Invoke(oldPrice, price);  // fire event.
        }
    }

}