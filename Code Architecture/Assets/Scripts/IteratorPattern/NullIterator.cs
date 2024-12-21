using CodeArchitecture.Iterator;

namespace CodeArchitecture.Iterator
{
    public class NullIterator : IIterator
    {
        public bool HasNext() {
            return false;
        }

        public object Next() {
            return null;
        }
    }
}