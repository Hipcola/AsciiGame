using Game.Assets;
using Game.Core;
using Game.Core.Interfaces;
using Moq;

namespace Tests;

public class AsciiGameTests
{
    private Mock<IConsole> console;
    private GameLoop game;

    public AsciiGameTests()
    {
        console = new Mock<IConsole>();
        game = new GameLoop(console.Object);
    }

    [Fact]
    public void Game_Sets_Title()
    {
        game.Begin();
        console.Verify(x=> x.SetTitle(It.IsAny<string>()), Times.Once());

    }

    [Fact]
    public void Game_Shows_Guide()
    {
        game.Begin();
        console.Verify(x => x.WriteLine(It.IsAny<string>()), Times.Once());
    }

    [Fact]
    public void Game_Draws_Man()
    {
        console.Setup(x => x.ReadLine()).Returns("Run Man");
        game.Begin();
        game.Loop();
        console.Verify(x => x.WriteLine(ASCII.Man), Times.Once());
    }
}
