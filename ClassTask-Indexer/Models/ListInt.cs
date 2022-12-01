using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask_Indexer.Models
{
    internal class ListInt
    {
        int[] _array;
        
        public int this[int index]
        {
            get {
                if (index < _array.Length)
                {
                    return _array[index];
                }
                throw new Exception();
            }
            set 
            { 
                if( index< _array.Length)
                {
                    _array[index]=value;
                }
                throw new Exception();
            }
        }
        public ListInt()
        {
            int[] array = new int[0];
        }

        public ListInt(int Length)
        {
            int[] array = new int[Length];
        }

        public void Add(int num)
        {
            Array.Resize(ref _array, _array.Length + 1);
            _array[_array.Length - 1] = num;
        }
        public void Add(params int[] num)
        {
            Array.Resize(ref _array, _array.Length+ num.Length);
            for(int i = 0; i < num.Length; i++)
            {
                _array[i] = (_array.Length + num.Length - 1);
            }
        }
        public bool Contains(int num)
        {
           for(int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == num)
                {
                    return true;
                }
               
            }

            return false;
        }
        public void Pop()
        {
            Array.Resize(ref _array, _array.Length - 1);
                {
                for(int i = 0; i < _array.Length; i++)
                {
                    return;
                }

                }
        }
    }
}
