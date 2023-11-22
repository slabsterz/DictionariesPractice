Dictionary<string, List<double>> studentLog = new Dictionary<string, List<double>>();

int cycles = int.Parse(Console.ReadLine());

for (int i = 0; i < cycles; i++)
{
    string name = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());

    if (!studentLog.ContainsKey(name))
    {
        studentLog.Add(name, new List<double>());
        studentLog[name].Add(grade);
    }
    else
    {
        studentLog[name].Add(grade);
    }
}

var aboveAverageGrade = studentLog.Where(pair => pair.Value.Average() >= 4.5);

foreach (var pair in aboveAverageGrade)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value.Average():f2}");
}