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
    public void TwoRocksResultInATie()
    {
        RpsGame("Rock", "Rock").Should().Be("Draw");
    }

    [Test]
    public void TwoScissorsResultInATie()
    {
        RpsGame("Scissors", "Scissors").Should().Be("Draw");
    }

    [Test]
    public void Player1WinsWithAPaper()
    {
        RpsGame("Paper", "Rock").Should().Be("Player 1 Wins");
    }

    [Test]
    public void Player1WinsWithARock()
    {
        RpsGame("Rock", "Scissors").Should().Be("Player 1 Wins");
    }

    [Test]
    public void Player1WinsWithAScissor()
    {
        RpsGame("Scissors", "Paper").Should().Be("Player 1 Wins");
    }


    private string RpsGame(string player1, string player2)
    {
        string result = "Draw";
        switch (player1)
        {
            case "Paper":
                if (player2 == "Rock") result = "Player 1 Wins";
                break;
            case "Rock":
                if (player2 == "Scissors") result = "Player 1 Wins";
                break;
            case "Scissors":
                if (player2 == "Paper") result = "Player 1 Wins";
                break;
        }

        return result;
    }
}