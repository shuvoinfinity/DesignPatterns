namespace DesignPatterns.Behavioural.Strategy
{
    public class OverlayBlackAndWhite : IOverlay
    {
        public void Apply(string fileName)
        {
            Console.WriteLine($"Applying black and white overlay to {fileName}");
        }
    }
}