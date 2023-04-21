using System.Collections;

namespace NumberUtils
{
    
    public class Listify : IList
    {
        private int _start;
        private int _end;        

        public Listify(int start, int end)
        {
            _start = start;
            _end = end;            
        }

        public object? this[int index] { get 
            {
                if(index > Count || index < 0)
                    throw new IndexOutOfRangeException();
                return _start+index; } set => throw new NotImplementedException(); }

        public bool IsFixedSize => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public int Count => _end-_start;

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public int Add(object? value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(object? value)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            return Enumerable.Range(_start, _end).GetEnumerator();
        }

        public int IndexOf(object? value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object? value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object? value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }
}