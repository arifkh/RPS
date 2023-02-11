using RPS.Core.Interfaces;

namespace RPS.Core.Models
{
    public class ScissorsGesture : IGesture
    {
        public IGesture Defeats { get; internal set; }

        public string FriendlyName => "Scissors";
    }
}
