using RPS.Core.Interfaces;
using RPS.Core.Models;

namespace RPS.Core
{
    public class RockPaperScissorsFactory
    {
        public IGesture GetRock()
        {
            return new RockGesture() { Defeats = new ScissorsGesture() }; 
        }

        public IGesture GetPaper()
        {
            return new PaperGesture() { Defeats = new RockGesture() };
        }

        public IGesture GetScissors()
        {
            return new ScissorsGesture() { Defeats = new PaperGesture() };
        }
    }
}
