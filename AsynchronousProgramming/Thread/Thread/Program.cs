﻿Thread thread = new(new ParameterizedThreadStart (WriteChar));

Console.WriteLine("Push any button for start...");
Console.ReadKey();

thread.Start('*');

for (int i = 0; i < 80; i++)
{
    Console.Write('-');
    Thread.Sleep(70);
}

void WriteChar(object? arg)
{
    var item = (char)arg;
    for (int i = 0; i < 80; i++)
    {
        Console.Write(item);
        Thread.Sleep(70);
    }
}