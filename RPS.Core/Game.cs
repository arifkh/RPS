using RPS.Core.Interfaces;

namespace RPS.Core
{
    public class Game
    {
        public GameResult Battle(IGesture player1, IGesture player2)
        {
            if (player1.GetType() == player2.GetType()) return GameResult.Draw;

            return player1.Defeats.GetType() == player2.GetType() 
                ? GameResult.Player1Wins
                : GameResult.Player2Wins;
        }
    }
}
