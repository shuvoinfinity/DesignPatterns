using System.Runtime.CompilerServices;

namespace DesignPatterns.Behavioural.Memento
{
    public class History
    {
        private List<EditorState> _states = new List<EditorState>();
        private readonly Editor _editor;
        public History(Editor editor)
        {
            _editor = editor;
        }

        public void Backup() => _states.Add(_editor.CreateState());
        public void Undo()
        {
            if (_states.Count == 0)
            {
                return;
            }
            EditorState prevState = _states.Last();
            _states.Remove(prevState);
            _editor.Restore(prevState);
        }

        public void ShowHistory()
        {
            System.Console.WriteLine($"State Histories:\t");
            foreach (var state in _states)
            {
                System.Console.WriteLine(state.GetNames());
            }
        }
    }
}