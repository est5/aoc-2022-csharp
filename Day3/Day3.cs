using System.Collections.Generic;
var alpha = new Dictionary<char, int>();
int count = 1;
for (char letter = 'a'; letter <= 'z'; letter++)
{
    alpha.Add(letter, count);
    count++;
}

for (char letter = 'A'; letter <= 'Z'; letter++)
{
    alpha.Add(letter, count);
    count++;
}

string[] lines = System.IO.File.ReadAllLines("./input.txt");
PartOne(lines);
PartTwo(lines);

void PartOne(string[] lines)
{
    int total = 0;
    Console.WriteLine("Part one");

    foreach (string line in lines)
    {
        var start = line.Substring(0, line.Length / 2);
        var end = line.Substring(line.Length / 2);
        List<Char> tempCommon = new List<Char>();
        foreach (var item in start)
        {
            var common = end.Contains(item);
            if (common)
            {
                if (tempCommon.Contains(item))
                {
                    continue;
                }
                tempCommon.Add(item);
                total += alpha[item];
            }
        }

    }
    System.Console.WriteLine(total);
}

void PartTwo(string[] lines)
{
    Console.WriteLine("\nPart two");
    int total = 0;
    int count = 0;
    List<string> tempStrings = new();

    foreach (var line in lines)
    {
        tempStrings.Add(line);
        count++;
        if (count == 3)
        {
            foreach (var item in tempStrings[0])
            {
                if (tempStrings[1].Contains(item) && tempStrings[2].Contains(item))
                {
                    total += alpha[item];
                    break;
                }
            }

            count = 0;
            tempStrings = new();
        }

    }
    Console.WriteLine(total);
}
