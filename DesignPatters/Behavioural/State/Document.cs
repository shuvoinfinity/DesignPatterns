namespace DesignPatterns.Behavioural.State
{
    public class Document
    {
        public IState State { get; set; }
        public UserRoles CurrentUserRole { get; set; }

        public Document(UserRoles currentRole)
        {
            CurrentUserRole = currentRole;
            State = new DraftState(this);
        }

        public void Publish()
        {
            State.Publish();
        }
    }
}