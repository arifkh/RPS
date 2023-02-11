using RPS.Core;
using RPS.Core.Interfaces;
using Xunit;

namespace RPS.Test
{
    public class TestGame
    {
        IGesture _rockGesture, _paperGesture, _scissorsGesture;

        public TestGame()
        {
            var factory = new RockPaperScissorsFactory();
            _rockGesture = factory.GetRock();
            _paperGesture = factory.GetPaper();
            _scissorsGesture = factory.GetScissors();
        }

        [Fact]
        public void Rock_Defeats_Scissors()
        {
            // Arrange
            var game = new Game();
            GameResult actual, expected = GameResult.Player1Wins;
            
            // Act
            actual = game.Battle(_rockGesture, _scissorsGesture);

            // Assert
           Assert.Equal(actual, expected);
        }

        [Fact]
        public void Rock_DefeatedBy_Paper()
        {
            // Arrange
            var game = new Game();
            GameResult actual, expected = GameResult.Player2Wins;

            // Act
            actual = game.Battle(_rockGesture, _paperGesture);

            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Rock_Draws_Rock()
        {
            // Arrange
            var game = new Game();
            GameResult actual, expected = GameResult.Draw;

            // Act
            actual = game.Battle(_rockGesture, _rockGesture);

            // Assert
            Assert.Equal(actual, expected);
        }
    }
}
