using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOrientadaAObejtos.Business
{
    public class Collections<T>
    {
        private T[] _element;
        private int _index;
        private int _limit;

        public Collections(int limit)
        {
            _limit = limit;
            _element = new T[_limit];
            _index = 0;
        }
        public void Add(T element)
        {
           if (_index < _limit) {
                _element[_index] = element;
                _index++;
            }
        }

    }
   
}
