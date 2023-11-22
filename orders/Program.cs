Dictionary<string, List<decimal>> items = new();

while (true)
{
    string[] input = Console.ReadLine().Split();

    string drink = input[0];

    if (drink == "buy")
    {
        break;
    }

    decimal price = decimal.Parse(input[1]);
    decimal quantity = decimal.Parse(input[2]);

    if (!items.ContainsKey(drink))
    {
        items.Add(drink, new List<decimal>());
        items[drink].Add(price);
        items[drink].Add(quantity);
    }
    else
    {
        items[drink][0] = price;
        items[drink][1] += quantity;
    }
}

foreach (KeyValuePair<string, List<decimal>> item in items)
{
    decimal price = item.Value[0];
    decimal quantity = item.Value[1];
    decimal total = price * quantity;

    Console.WriteLine($"{item.Key} -> {total}");
}