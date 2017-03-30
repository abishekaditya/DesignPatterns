using System.Collections;
using System.Collections.Generic;

namespace IteratorPattern
{
    class DinnerMenuIterator : IEnumerable
    {
        private int _count = 0;
        private Menu[] _items;

        public DinnerMenuIterator(Menu[] items)
        {
            _items = items;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return new DinnerMenuEnum(_items);
        }
    }
}
