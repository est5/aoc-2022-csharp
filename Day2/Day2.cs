string[] lines = System.IO.File.ReadAllLines("./input.txt");

int total = 0;

PartOne(lines, total);
PartTwo(lines, total);

void PartOne(string[] lines, int total)
{
    foreach (var line in lines)
    {
        string[] pair = line.Split(" ");
        total += PlayRoundPartOne(opponent: pair[0], player: pair[1]);
    }
    System.Console.WriteLine("Part one: " + total);
}

void PartTwo(string[] lines, int total)
{
    foreach (var line in lines)
    {
        string[] pair = line.Split(" ");
        total += PlayRoundPartTwo(opponent: pair[0], player: pair[1]);
    }
    System.Console.WriteLine("Part two: " + total);
}

static int PlayRoundPartOne(string player, string opponent)
{
    switch (opponent)
    {
        case "A":
            switch (player)
            {
                case "X": return 3 + 1;
                case "Y": return 6 + 2;
                case "Z": return 0 + 3;
            }
            break;
        case "B":
            switch (player)
            {
                case "X": return 0 + 1;
                case "Y": return 3 + 2;
                case "Z": return 6 + 3;
            }
            break;
        case "C":
            switch (player)
            {
                case "X": return 6 + 1;
                case "Y": return 0 + 2;
                case "Z": return 3 + 3;
            }
            break;
    }
    return 0;
}


static int PlayRoundPartTwo(string player, string opponent)
{
    switch (opponent)
    {
        case "A":
            switch (player)
            {
                case "X": return 0 + 3;
                case "Y": return 3 + 1;
                case "Z": return 6 + 2;
            }
            break;
        case "B":
            switch (player)
            {
                case "X": return 0 + 1;
                case "Y": return 3 + 2;
                case "Z": return 6 + 3;
            }
            break;
        case "C":
            switch (player)
            {
                case "X": return 0 + 2;
                case "Y": return 3 + 3;
                case "Z": return 6 + 1;
            }
            break;
    }
    return 0;
}

