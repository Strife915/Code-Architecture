namespace CodeArchitecture.Iterator
{
    public class DinerMenuIterator : IIterator
    {
        MenuItem[] items;
        int _position = 0;

        public DinerMenuIterator(MenuItem[] items) {
            this.items = items;
        }

        public bool HasNext() {
            if (_position >= items.Length || items[_position] == null)
            {
                return false;
            }

            return true;
        }

        public object Next() {
            MenuItem menuItem = items[_position];
            _position = _position + 1;
            return menuItem;
        }
    }
}