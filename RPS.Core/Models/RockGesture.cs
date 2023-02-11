using RPS.Core.Interfaces;

namespace RPS.Core.Models
{
    public class RockGesture : IGesture
    {
        public IGesture Defeats { get; internal set; }

        public string FriendlyName => "Rock";
    }
}
