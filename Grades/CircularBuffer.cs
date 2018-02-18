using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class CircularBuffer<T>
    {
        private T[] _buffer;
        private int _start;
        private int _end;

        public CircularBuffer(int capacity)
        {
            // the circular buffer is designed to be a 
            // template "generic" class
            // this class can quickly be adapted to be a circular buffer 
            // of any generic data type as the items in the bufferf
            _buffer = new T[capacity + 1];
            _start = 0;
            _end = 0;
        }
    }
}
