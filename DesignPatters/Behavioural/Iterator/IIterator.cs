namespace DesignPatterns.Behavioural.Iterator
{
    public interface Iterator<T>
    {
        void Next();
        bool HasNext();
        T Current();
    }
}