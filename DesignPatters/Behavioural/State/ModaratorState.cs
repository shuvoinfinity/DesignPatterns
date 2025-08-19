namespace DesignPatterns.Behavioural.State
{
    public class ModaratorState : IState
    {
        private readonly Document _document;
        public ModaratorState(Document document)
        {
            _document = document;
        }
        public void Publish()
        {
            if (_document.CurrentUserRole == UserRoles.Admin)
            {
                _document.State = new PublishedState(_document);
            }
        }
    }
}