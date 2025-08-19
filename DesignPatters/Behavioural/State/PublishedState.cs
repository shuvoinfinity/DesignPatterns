namespace DesignPatterns.Behavioural.State
{
    public class PublishedState : IState
    {
        private readonly Document _document;
        public PublishedState(Document document)
        {
            _document = document;
        }

        public void Publish()
        {
            return; // In Published state, no further action is taken on Publish
        }
    }
}