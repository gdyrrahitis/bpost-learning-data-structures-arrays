namespace Learning.Arrays.Operations
{
    using System;

    public class ArrayImpl
    {
        private readonly int[] _array;
        private int _items = 0;

        public ArrayImpl(int size)
        {
            _array = new int[size];
        }

        public void Insert(int value) => _array[_items++] = value;

        public int Search(int searchKey)
        {
            for (var i = 0; i < _items; i++)
            {
                if (_array[i] == searchKey)
                {
                    return _array[i];
                }
            }

            return -1;
        }

        public void Delete(int searchKey)
        {
            for (var i = 0; i < _items; i++)
            {
                if (_array[i] == searchKey)
                {
                    for (var j = i; j < _items - 1; j++)
                    {
                        _array[j] = _array[j + 1];
                    }

                    _items--;
                }
            }
        }

        public void Display()
        {
            Console.Write("[");
            for (var i = 0; i < _items; i++)
            {
                Console.Write($"{_array[i]}");
                if (i != _items - 1) Console.Write("{0, -3}", ", " );
            }

            Console.WriteLine("]");
        }
    }
}