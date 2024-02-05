// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = product[0] switch
{
    "01" => "Sweat shirt",
    "02" => "T-Shirt",
    "03" => "Sweat pants",
    _ => "Other"
};

string color = product[1] switch
{
    "BL" => "Black",
    "MN" => "Maroon",
    _ => "White"
};

string size = product[2] switch
{
    "S" => "Small",
    "M" => "Medium",
    "L" => "Large",
    _ => "One Size Fits All"
};

Console.WriteLine($"Product: {size} {color} {type}");