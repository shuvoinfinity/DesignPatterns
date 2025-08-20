namespace DesignPatterns.Behavioural.Strategy
{
    public class CompressMov : ICompress
    {
        public void Compress(string fileName)
        {
            Console.WriteLine($"Compressing {fileName} to .MOV format");
        }
    }
}