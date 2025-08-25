namespace DesignPatterns.Behavioural.Iterator
{
    public class ShoppingList
    {
        public List<string> _items = new List<string>();
        public void AddItem(string item) => _items.Add(item);
        public void RemoveItem(string item) => _items.Remove(item);
        public Iterator<string> CreateIterator() => new ListIterator(this);
    }
}