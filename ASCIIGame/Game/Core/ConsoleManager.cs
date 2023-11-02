using Game.Core.Interfaces;

namespace Game.Core;

public class ConsoleManager : IConsole
{
    public void SetTitle(string title)
    {
        Console.Title = title;
    }

    public void WriteLine(string text)
    {
        Console.WriteLine(text);
    }

    public string ReadLine()
    {
        return Console.ReadLine();
    }
}

