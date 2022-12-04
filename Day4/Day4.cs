string[] lines = System.IO.File.ReadAllLines("./input.txt");

PartOne(lines);
PartTwo(lines);


void PartOne(string[] lines)
{
    System.Console.WriteLine("Part one");
    int total = 0;
    foreach (var line in lines)
    {
        var pairs = line.Split(',');
        var firstPairtNums = pairs[0].Split('-');
        var secondPairtNums = pairs[1].Split('-');

        if (Convert.ToInt32(secondPairtNums[0]) >= Convert.ToInt32(firstPairtNums[0]) &&
            Convert.ToInt32(secondPairtNums[1]) <= Convert.ToInt32(firstPairtNums[1]))
        {
            total++;
        }
        else if (Convert.ToInt32(firstPairtNums[0]) >= Convert.ToInt32(secondPairtNums[0]) &&
             Convert.ToInt32(firstPairtNums[1]) <= Convert.ToInt32(secondPairtNums[1]))
        {
            total++;
        }
    }
    Console.WriteLine(total);
}

void PartTwo(string[] lines)
{
    System.Console.WriteLine("Part two");
    int total = 0;
    foreach (var line in lines)
    {
        var pairs = line.Split(',');
        var firstPairtNums = pairs[0].Split('-');
        var secondPairtNums = pairs[1].Split('-');

        if (Convert.ToInt32(secondPairtNums[1]) >= Convert.ToInt32(firstPairtNums[0]) &&
            Convert.ToInt32(secondPairtNums[0]) <= Convert.ToInt32(firstPairtNums[1]))
        {
            total++;
        }
        else if (Convert.ToInt32(firstPairtNums[1]) >= Convert.ToInt32(secondPairtNums[0]) &&
             Convert.ToInt32(firstPairtNums[0]) <= Convert.ToInt32(secondPairtNums[1]))
        {
            total++;
        }
    }
    Console.WriteLine(total);
}
