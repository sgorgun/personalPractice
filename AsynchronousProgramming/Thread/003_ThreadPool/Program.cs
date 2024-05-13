using AsyncProgramming;
Console.WriteLine("Press any key for start...");
Console.ReadKey();

ThreadPoolWorker threadPoolWorker = new ThreadPoolWorker(new Action<object>(StarWriter));
threadPoolWorker.Start('*');

for (int i = 0; i < 40; i++)
{
    Console.Write('-');
    Thread.Sleep(50);
}

threadPoolWorker.Wait();
Console.WriteLine("The programm is finished.");

void StarWriter(object arg)
{
    char item = (char)arg;

    for (int i = 0; i < 120; i++)
    {
        Console.Write(item);
        Thread.Sleep(50);
    }
}