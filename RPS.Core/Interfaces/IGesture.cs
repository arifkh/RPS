namespace RPS.Core.Interfaces
{
    public interface IGesture
    {
        string FriendlyName { get; }
        IGesture Defeats { get; }
    }
}
