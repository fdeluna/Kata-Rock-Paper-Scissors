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

public class Tests {
	[SetUp]
	public void Setup() { }

	[Test]
	public void TwoPapersResultInATie() {
		Rps("Paper","Paper").Should().Be("Draw"); 
	}

	private string Rps(string paper, string s)
	{
		return "Draw";
	}
}