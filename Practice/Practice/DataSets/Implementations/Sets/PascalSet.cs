using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice.DataSets.Implementations.Sets
{
    public class PascalSet : ICloneable, ICollection, IEnumerable
    {
        private int _lowerBound;
        private int _upperBound;
        private BitArray _data;

        //TODO: Implement the functions
        public PascalSet(int lowerBound, int upperBound)
        {
            if (lowerBound > upperBound)
            {
                throw new ArgumentException("lowerBound cannot be greater than upperBound");
            }

            _lowerBound = lowerBound;
            _upperBound = upperBound;

            _data = new BitArray(upperBound - lowerBound + 1);
        }

        public PascalSet(BitArray data)
        {
            _data = data;
        }

        public virtual PascalSet Union(PascalSet set)
        {
            if (!AreSimilar(set))
            {
                throw new ArgumentException("sets can't be of different universe");
            }

            PascalSet result = (PascalSet)Clone();

            result._data.Or(set._data);
            return result;
        }

        private bool AreSimilar(PascalSet set)
        {
            return set._upperBound == _upperBound && set._lowerBound == _lowerBound;
        }

        public static PascalSet operator +(PascalSet s, PascalSet t)
        {
            return s.Union(t);
        }

        public object Clone()
        {
            return new PascalSet(_lowerBound, _upperBound);
        }

        public IEnumerator GetEnumerator()
        {
            int totalElements = Count;
            int itemsReturned = 0;

            for (int i = 0; i < _data.Length; i++)
            {
                if (itemsReturned >= totalElements)
                {
                    break;
                }
                else if (_data.Get(i))
                {
                    yield return i + this._lowerBound;
                }
            }
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public int Count { get; }
        public object SyncRoot { get; }
        public bool IsSynchronized { get; }
    }
}
