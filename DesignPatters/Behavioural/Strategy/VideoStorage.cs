namespace DesignPatterns.Behavioural.Strategy
{
    public class VideoStorage
    {
        private ICompress _compressor;
        private IOverlay _overlay;

        public VideoStorage(ICompress compressor, IOverlay overlay)
        {
            _compressor = compressor;
            _overlay = overlay;
        }

        public void SetCompressor(ICompress compressor)
        {
            _compressor = compressor;
        }

        public void SetOverlay(IOverlay overlay)
        {
            _overlay = overlay;
        }

        public void StoreVideo(string fileName)
        {
            _compressor.Compress(fileName);
            _overlay.Apply(fileName);
            Console.WriteLine($"Video {fileName} stored successfully.");
        }
        
    }
}