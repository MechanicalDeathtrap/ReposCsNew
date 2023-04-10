using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.FirstHW.Var2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<int> list = new MyLinkedList<int>();
            var array1 = new int[] {1,2,3,4 };
            var array2 = new int[] {11,12,5,6,7,8,9};
            var array3 = new int[] {16,34,45,66,77,88,10};
            list.Add(array1);
            list.Add(array2);
            list.Add(array3);
            list.Get(4);
            list.Get(5);
            list.Get(11);
            list.Get(12);
            list.Get(13);
        }
    }
}
