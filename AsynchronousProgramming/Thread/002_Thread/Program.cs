
Console.WriteLine($"Main method thread Id - { Thread.CurrentThread.ManagedThreadId }");
Console.WriteLine("Press any button for start...");
Console.ReadKey();

Report();
ThreadPool.QueueUserWorkItem(new WaitCallback(Task1));



Report();
ThreadPool.QueueUserWorkItem(new WaitCallback(Task2));
Report();

Console.ReadKey();
Report();

void Task1(object? state)
{
    Console.WriteLine($"The Task1 method started executing in the thread {Thread.CurrentThread.ManagedThreadId}");
    Thread.Sleep(2000);
    Console.WriteLine($"The Task1 method stoped executing in the thread {Thread.CurrentThread.ManagedThreadId}");
}

void Task2(object? state)
{
    Console.WriteLine($"The Task2 method started executing in the thread {Thread.CurrentThread.ManagedThreadId}");
    Thread.Sleep(2000);
    Console.WriteLine($"The Task2 method stoped executing in the thread {Thread.CurrentThread.ManagedThreadId}");
}

void Report()
{
    ThreadPool.GetMaxThreads(out int maxWorkerThreads,out int maxPortThreads);
    ThreadPool.GetAvailableThreads(out int workerThreads,out int portThreads);

    Console.WriteLine($"Worker threads {workerThreads} from {maxWorkerThreads}.");
    Console.WriteLine($"I/O threads {portThreads} from {maxPortThreads}.");
    Console.WriteLine(new string('-', 80));
}