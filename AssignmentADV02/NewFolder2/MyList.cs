using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADV02.NewFolder2
{
    public class MyList<T>
    {
        private T[] _items;
        private int _size;
        private const int DefaultCapacity = 4;

        public MyList()
        {
            _items = new T[DefaultCapacity];
            _size = 0;
        }

        public MyList(int capacity)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity cannot be negative.");
            _items = new T[capacity];
            _size = 0;
        }

        public int Count => _size;

        // Add method for testing
        public void Add(T item)
        {
            if (_size == _items.Length)
                EnsureCapacity(_size + 1);

            _items[_size++] = item;
        }

        private void EnsureCapacity(int min)
        {
            if (_items.Length < min)
            {
                int newCapacity = _items.Length == 0 ? DefaultCapacity : _items.Length * 2;
                if (newCapacity < min) newCapacity = min;
                T[] newItems = new T[newCapacity];
                Array.Copy(_items, 0, newItems, 0, _size);
                _items = newItems;
            }
        }

        // 1. Exist
        public bool Exist(Predicate<T> match)
        {
            if (match == null)
                throw new ArgumentNullException(nameof(match));
            return FindIndex(match) != -1;
        }

        // 2. Find
        public T Find(Predicate<T> match)
        {
            if (match == null)
                throw new ArgumentNullException(nameof(match));
            foreach (T item in _items)
            {
                if (match(item))
                    return item;
            }
            return default;
        }

        // 3. Find All
        public List<T> FindAll(Predicate<T> match)
        {
            if (match == null)
                throw new ArgumentNullException(nameof(match));
            List<T> result = new List<T>();
            foreach (T item in _items)
            {
                if (match(item))
                    result.Add(item);
            }
            return result;
        }

        // 4. Find Index
        public int FindIndex(Predicate<T> match)
        {
            if (match == null)
                throw new ArgumentNullException(nameof(match));
            for (int i = 0; i < _size; i++)
            {
                if (match(_items[i]))
                    return i;
            }
            return -1;
        }

        // 5. Find Last
        public T FindLast(Predicate<T> match)
        {
            if (match == null)
                throw new ArgumentNullException(nameof(match));
            for (int i = _size - 1; i >= 0; i--)
            {
                if (match(_items[i]))
                    return _items[i];
            }
            return default;
        }

        // 6. Find Last Index
        public int FindLastIndex(Predicate<T> match)
        {
            if (match == null)
                throw new ArgumentNullException(nameof(match));
            for (int i = _size - 1; i >= 0; i--)
            {
                if (match(_items[i]))
                    return i;
            }
            return -1;
        }

        // 7. Foreach
        public void ForEach(Action<T> action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));
            foreach (T item in _items)
            {
                action(item);
            }
        }

        // 8. TrueForAll
        public bool TrueForAll(Predicate<T> match)
        {
            if (match == null)
                throw new ArgumentNullException(nameof(match));
            foreach (T item in _items)
            {
                if (!match(item))
                    return false;
            }
            return true;
        }
    }
    }
