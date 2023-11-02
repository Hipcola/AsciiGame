
namespace Game.Core.Interfaces;
public interface IConsole
{
    void SetTitle (string title);
    void WriteLine (string text);
    string ReadLine ();
}