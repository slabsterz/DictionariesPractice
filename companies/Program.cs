Dictionary<string, List<string>> companyData = new Dictionary<string, List<string>>();

while (true)
{
    string[] input = Console.ReadLine().Split(" -> ");

    string companyName = input[0];

    if (companyName == "End")
    {
        break;
    }

    string employeeID = input[1];

    if (!companyData.ContainsKey(companyName))
    {
        companyData.Add(companyName, new List<string>());
        companyData[companyName].Add(employeeID);
    }
    else
    {
        if (companyData[companyName].Contains(employeeID))
        {
            continue;
        }

        companyData[companyName].Add(employeeID);
    }  
}

foreach (KeyValuePair<string, List<string>> pair in companyData)
{
    Console.WriteLine($"{pair.Key}");

    foreach (string entry in pair.Value)
    {
        Console.WriteLine($"-- {entry}");
    }
}