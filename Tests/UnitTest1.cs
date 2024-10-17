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

    [Test]
    public void Player2WinsWithAPaper()
    {
        RpsGame("Rock", "Paper").Should().Be("Player 2 Wins");
    }
    
    [Test]
    public void Player2WinsWithARock()
    {
        RpsGame("Scissors", "Rock").Should().Be("Player 2 Wins");
    }
    
    private string RpsGame(string player1, string player2)
    {
        if (player1 == player2) return "Draw";

        if (PlayerWins(player2, player1) == "Player 1 Wins")
            return "Player 2 Wins";
        
        return PlayerWins(player1, player2);
    }

    private static string PlayerWins(string player1, string player2)
    {
        switch (player1)
        {
            case "Paper":
                if (player2 == "Rock") return "Player 1 Wins";
                break;
            case "Rock":
                if (player2 == "Scissors") return "Player 1 Wins";
                break;
            case "Scissors":
                if (player2 == "Paper") return "Player 1 Wins";
                break;
        }

        throw new ArgumentException("Unknown inputs for Rps game");
    }
}