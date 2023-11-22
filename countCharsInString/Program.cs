string input = Console.ReadLine();

Dictionary<char, int> countChars = new Dictionary<char, int>();

char[] inputArray = input.ToCharArray();

for (int i = 0; i < inputArray.Length; i++)
{
    char currentLetter = inputArray[i];

    if (currentLetter == ' ')
    {
        continue;
    }

    if (!countChars.ContainsKey(currentLetter))
    {
        countChars.Add(currentLetter, 1);
    }
    else
    {
        countChars[currentLetter]++;
    }
}

foreach (KeyValuePair<char, int> pair in countChars)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}