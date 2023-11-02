using Game.Core;

namespace Game;

class Program
{
    static void Main()
    {
        var consoleManager = new ConsoleManager();
        var gameLoop = new GameLoop(consoleManager);

        gameLoop.Begin();

        while(true) { gameLoop.Loop();}
    }
}
