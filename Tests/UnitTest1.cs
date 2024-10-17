using FluentAssertions;

namespace Tests;

// Rock Paper Scissors
// 	Let's play! You have to return which player won! In case of a draw return Draw!.
//
// Examples(Input1, Input2 --> Output):
//
// "scissors", "paper" --> "Player 1 won!"
// "scissors", "rock" --> "Player 2 won!"
// "paper", "paper" --> "Draw!"

public class Tests
{
    [SetUp]
    public void Setup() { }

    [Test]
    public void TwoPapersResultInATie()
    {
        RpsGame("Paper", "Paper").Should().Be("Draw");
    }

    [Test]
    public void Player1ResultInWin()
    {
        RpsGame("Paper", "Rock").Should().Be("Player 1 Wins");
    }

    private string RpsGame(string player1, string player2)
    {
        string result = "Draw";

        if (player1 == "Paper" && player2 == "Rock") result = "Player 1 Wins";
        return result;
    }
}