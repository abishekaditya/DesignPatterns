using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorPattern
{
    public class DinnerMenuEnum : IEnumerator
    {
        private readonly Menu[] _items;
        private int _position = -1;
        public DinnerMenuEnum(Menu[] items)
        {
            _items = items;
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public bool MoveNext()
        {
            _position++;
            return (_position < _items.Length);
        }

        public void Reset()
        {
            _position = -1;
        }

        object IEnumerator.Current => Current;

        public Menu Current
        {
            get
            {
                try
                {
                    return _items[_position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}