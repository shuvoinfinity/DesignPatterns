namespace DesignPatterns.Behavioural.State
{
    public class DraftState : IState
    {
        private readonly Document _document;
        public DraftState(Document document)
        {
            _document = document;
        }
        public void Publish()
        {
            _document.State = new ModaratorState(_document);
        }
    }
}