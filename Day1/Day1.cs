string[] lines = System.IO.File.ReadAllLines("./input.txt");

// int elfCount = 0;
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
