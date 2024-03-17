// The predefined nongeneric EventHandler delegate can be used when an event doesn't
// carry extra information:

Stock stock = new Stock("THPW");
stock.Price = 27.10M;
// Register with the PriceChanged event
stock.PriceChanged += stock_PriceChanged;
stock.Price = 31.59M;
stock.PriceChanged += PriceChangeMoreThan;
stock.Price = 50.59M;
stock.Price = 150.59M;
stock.Price = 70.59M;
stock.Price = 150.59M;


void stock_PriceChanged(object sender, EventArgs e)
{
    Console.WriteLine("New price = " + ((Stock)sender).Price);
}

void PriceChangeMoreThan(object sender, EventArgs e)
{
    if (stock.Price > 150.00M)
        Console.WriteLine("The price is more than 150. Sell!!!");
}

public class Stock
{
    string symbol;
    decimal price;

    public Stock(string symbol) { this.symbol = symbol; }

    public event EventHandler PriceChanged;

    protected virtual void OnPriceChanged(EventArgs e)
    {
        PriceChanged?.Invoke(this, e);
    }

    public decimal Price
    {
        get { return price; }
        set
        {
            if (price == value) return;
            price = value;
            OnPriceChanged(EventArgs.Empty);
        }
    }
}