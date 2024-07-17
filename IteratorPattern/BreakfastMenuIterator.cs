using System.Collections;

namespace IteratorPattern;

class BreakfastMenuIterator : IEnumerable
{
    private int _count = 0;
    private ArrayList _items;

    public BreakfastMenuIterator(ArrayList items)
    {
        _items = items;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator GetEnumerator()
    {
        return new BreakfastMenuEnum(_items);
    }
}
