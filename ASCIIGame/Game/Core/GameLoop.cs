using Game.Assets;
using Game.Core.Interfaces;

namespace Game.Core;

public class GameLoop
{

    private const string Guide = 
        @"
        Commands 
            - Run (Followed by a character to display character, e.g Run Man 
            - End (Closes the game)
           
        Characters 
            - Man
        ";

    private readonly IConsole _consoleManager;

    public GameLoop(IConsole consoleManager)
    {
        _consoleManager = consoleManager;
    }

    public void Begin()
    {
        _consoleManager.SetTitle("ASCII Game");
        _consoleManager.WriteLine(Guide);
    }

    public void Loop()
    {
        var input = _consoleManager.ReadLine();
        ProcessCommand(input);
    }

    private void ProcessCommand(string input)
    {
        switch (input)
        {
            case "End":
                Environment.Exit(0);
                break;
            case "Run Man":
                _consoleManager.WriteLine(ASCII.Man);
                break;
            default:
                _consoleManager.WriteLine("Command not recognised");
                break;
        }
    }
}

