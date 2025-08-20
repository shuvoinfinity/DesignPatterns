namespace DesignPatterns.Behavioural.Strategy
{
    public class CompressMp4 : ICompress
    {
        public void Compress(string fileName)
        {
            Console.WriteLine($"Compressing {fileName} to .MP4 format");
        }
    }
}