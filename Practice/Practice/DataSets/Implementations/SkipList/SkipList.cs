using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Practice.DataSets.Implementations.SkipList
{
    //TODO: Make code DRY-er
    //TODO: Add options to the menu and implement this class
    public class SkipList<T> : IEnumerable<T>, ICollection<T>
    {
        private SkipListNode<T> _head;
        private int _count;
        private Random _randomNumber;
        private IComparer<T> _comparer = Comparer<T>.Default;

        protected readonly double _probability = 0.5;
        public int Height => _head.Height;
        public int Count => _count;

        public SkipList() : this(-1, null) { }

        public SkipList(int randomSeed) : this(randomSeed, null) { }

        public SkipList(IComparer<T> comparer) : this(-1, comparer) { }

        public SkipList(int randomSeed, IComparer<T> comparer)
        {
            _head = new SkipListNode<T>(1);
            _count = 0;
            if (randomSeed < 0)
            {
                _randomNumber = new Random();
            }
            else
            {
                _randomNumber = new Random(randomSeed);
            }

            _comparer = comparer == null ? _comparer : comparer;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        protected virtual int ChooseRandomHeight(int maxLevel)
        {
            int level = 1;

            while (_randomNumber.NextDouble() < _probability)
            {
                level++;
            }

            return level;
        }

        public void Add(T item)
        {
            var updates = BuildUpdateTable(item);
            var current = updates[0];

            if (current[0] != null && _comparer.Compare(current[0].Value, item) == 0)
            {
                // Duplicate value
                return;
            }

            var newNode = new SkipListNode<T>(item, ChooseRandomHeight(_head.Height + 1));
            _count++;

            if (newNode.Height > _head.Height)
            {
                _head.IncrementHeight();
                _head[_head.Height - 1] = newNode;
            }

            for (int i = 0; i < newNode.Height; i++)
            {
                newNode[i] = updates[i][i];
                updates[i][i] = newNode;
            }
        }

        public SkipListNode<T> BuildUpdateTable(T item)
        {
            var updates = new SkipListNode<T>(_head.Height);
            var current = _head;

            for (int i = _head.Height - 1; i > 0; i--)
            {
                while (current[i] != null && _comparer.Compare(current[i].Value, item) < 0)
                {
                    current = current[i];
                }

                updates[i] = current;
            }

            return updates;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            var current = _head;

            for (int i = _head.Height - 1; i > 0; i--)
            {
                while (current[i] != null)
                {
                    int result = _comparer.Compare(current[i].Value, item);

                    if (result == 0)
                    {
                        return true;
                    }
                    else if (result < 0)
                    {
                        current = current[i];
                    }
                    else if (result > 0)
                    {
                        break;
                    }
                }
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }
        public bool Remove(T value)
        {
            var updates = BuildUpdateTable(value);
            SkipListNode<T> current = updates[0][0];

            if (current != null && _comparer.Compare(current.Value, value) == 0)
            {
                _count--;

                for (int i = 0; i < _head.Height; i++)
                {
                    if (updates[i][i] != current)
                    {
                        break;
                    }
                    else
                    {
                        updates[i][i] = current[i];
                    }
                }

                if (_head[_head.Height - 1] == null)
                {
                    _head.DecrementHeight();
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsReadOnly { get; }
    }
}
