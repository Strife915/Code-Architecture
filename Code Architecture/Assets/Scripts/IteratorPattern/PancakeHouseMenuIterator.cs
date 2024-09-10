using System.Collections.Generic;

namespace CodeArchitecture.Iterator
{
    public class PancakeHouseMenuIterator : IIterator
    {
        List<MenuItem> _items;
        int _position = 0;

        public PancakeHouseMenuIterator(List<MenuItem> items) {
            _items = items;
        }

        public bool HasNext() {
            if (_position >= _items.Count || _items[_position] == null)
            {
                return false;
            }

            return true;
        }

        public object Next() {
            MenuItem menuItem = _items[_position];
            _position = _position + 1;
            return menuItem;
        }
    }
}