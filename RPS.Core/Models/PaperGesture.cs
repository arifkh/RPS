using RPS.Core.Interfaces;

namespace RPS.Core.Models
{
    public class PaperGesture : IGesture
    {
        public IGesture Defeats { get; internal set; }

        public string FriendlyName => "Paper";
    }
}
