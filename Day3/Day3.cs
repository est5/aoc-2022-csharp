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

