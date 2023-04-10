using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.FirstHW.Var2
{
    internal class QueueItem<T> where T : IComparable<T>
    {
        public T[] value { get; set; }
        public QueueItem<T> nextArray { get; set; }

        public QueueItem(T[] array)
        {
            value=array;
            nextArray = null;

        }
    }
}
