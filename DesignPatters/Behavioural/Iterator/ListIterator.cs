namespace DesignPatterns.Behavioural.Iterator
{
    public class ListIterator : Iterator<string>
    {
        private ShoppingList _shoppingList;
        private int _index = 0;

        public ListIterator(ShoppingList items)
        {
            _shoppingList = items;
        }
        public string Current()
        {
            return _shoppingList._items[_index];
        }

        public bool HasNext()
        {
            return _index < _shoppingList._items.Count;
        }

        public void Next()
        {
            _index++;
        }
    }
}