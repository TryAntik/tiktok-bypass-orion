using System;
using System.Threading;

public class Tools
{
    protected void Cout(string text, ConsoleColor color = ConsoleColor.White) {
        Console.ForegroundColor = color;
        Console.WriteLine(text);
        ResetColor();
    }
    protected void ResetColor() => Console.ForegroundColor = ConsoleColor.White;
    protected void Clear() => Console.Clear();
    protected void Wait(int duration) => Thread.Sleep(duration);
}
