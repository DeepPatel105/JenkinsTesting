
while (true)
{
    Console.Write($"Current Date and Time is {DateTime.Now}.");
    WriteElipse(.5, 20);
}


static void WriteElipse(double intervalInSeconds, int timesToLoop)
{
    int totalTimes = 0;
    for (int i = 0; i < timesToLoop; i++)
    {
        Thread.Sleep(Convert.ToInt32(intervalInSeconds * 1000));
        Console.Write(".");
        totalTimes++;
    }
    Console.WriteLine();
}