namespace CodeArchitecture.Iterator
{
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }
}