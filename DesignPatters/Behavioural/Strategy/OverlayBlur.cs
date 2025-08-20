namespace DesignPatterns.Behavioural.Strategy
{
    public class OverlayBlur : IOverlay
    {
        public void Apply(string fileName)
        {
            Console.WriteLine($"Applying blur overlay to {fileName}");
        }
    }
}