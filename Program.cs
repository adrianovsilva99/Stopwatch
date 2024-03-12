// See https://aka.ms/new-console-template for more information
using System.Threading;

Menu();

static void Menu()
{
    Console.WriteLine("(S)econds => 10s = 10 seconds");
    Console.WriteLine("(M)inutes => 10m = 10 minutes");
    Console.WriteLine("0 = Exit");
    Console.WriteLine("How many times do you want to count?");
    string data = Console.ReadLine().ToLower();

    if (data == "0")
        System.Environment.Exit(0);

    char type = char.Parse(data.Substring(data.Length - 1, 1));
    int time = int.Parse(data.Substring(0, data.Length - 1));

    if (type == 's')
        PreStart(time);
    else
        PreStart(time * 60);
}

static void PreStart(int time)
{
    Console.Clear();
    Console.WriteLine("Ready...");
    Thread.Sleep(1000);
    Console.WriteLine("Set...");
    Thread.Sleep(1000);
    Console.WriteLine("Go...");
    Thread.Sleep(1000);

    Start(time);
}

static void Start(int time)
{
    int currentTime = 0;
    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("Finished timer!");
    Thread.Sleep(2550);
    Menu();
}