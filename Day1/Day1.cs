string[] lines = System.IO.File.ReadAllLines("./input.txt");

PartOne(lines);
PartTwo(lines);

static void PartOne(string[] lines)
{
    Console.WriteLine("Part one");
    int maxValue = 0;
    int tempValue = 0;
    foreach (string line in lines)
    {
        try
        {
            tempValue += Convert.ToInt32(line);
        }
        catch (Exception)
        {
            maxValue = maxValue > tempValue ? maxValue : tempValue;
            tempValue = 0;
        }
    }
    Console.WriteLine(maxValue);
}

static void PartTwo(string[] lines)
{
    Console.WriteLine("Part two");

    List<int> elfsTotal = new();
    int total = 0;
    foreach (string line in lines)
    {
        try
        {
            total += Convert.ToInt32(line);
        }
        catch (Exception)
        {
            elfsTotal.Add(total);
            total = 0;
        }
    }
    elfsTotal.Sort((int a, int b) => b - a);
    System.Console.WriteLine($"{elfsTotal[0]}, {elfsTotal[1]}, {elfsTotal[2]}\nTotal {elfsTotal[0] + elfsTotal[1] + elfsTotal[2]}");
}
