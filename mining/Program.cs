Dictionary<string, int> treasure = new Dictionary<string, int>();

while (true)
{
    string material = Console.ReadLine();

    if (material == "stop")
    {
        break;
    }

    int quantity = int.Parse(Console.ReadLine());

    if (!treasure.ContainsKey(material))
    {
        treasure.Add(material, quantity);
    }
    else
    {
        treasure[material] += quantity;
    }
}

foreach (KeyValuePair<string, int> pair in treasure)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}