namespace DesignPatterns.Behavioural.Memento
{
    public class Editor
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public EditorState CreateState()
        {
            return new EditorState(Title, Content);
        }

        public void Restore(EditorState _state)
        {
            Title = _state.GetTitle();
            Content = _state.GetContent();
        }
    }
}