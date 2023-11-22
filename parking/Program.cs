int cycles = int.Parse(Console.ReadLine());

Dictionary<string, string> data = new Dictionary<string, string>();

for  (int i = 0; i < cycles; i++)
{
    string[] input = Console.ReadLine().Split();

    string command = input[0];
    string user = input[1];

    if (command == "register")
    {
        string plate = input[2];

        if (!data.ContainsKey(user))
        {
            data.Add(user, plate);
            Console.WriteLine($"{user} registered {plate} successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: already registered with plate number {data[user]}");
        }
    }
    else if (command == "unregister")
    {
        if (!data.ContainsKey(user))
        {
            Console.WriteLine($"ERROR: user {user} not found");
        }
        else
        {
            data.Remove(user);
            Console.WriteLine($"{user} unregistered successfully");
        }
    }
}
foreach (KeyValuePair<string, string> pair in data)
{
    Console.WriteLine($"{pair.Key} => {pair.Value}");
}