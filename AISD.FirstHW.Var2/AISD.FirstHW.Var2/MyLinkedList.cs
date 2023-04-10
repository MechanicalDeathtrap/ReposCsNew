using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISD.FirstHW.Var2
{
    internal class MyLinkedList<T> where T: IComparable<T>
    {
        QueueItem<T> head { get; set; }
        QueueItem<T> tail { get; set; }
        public int arrayLenght { get; set; }

        public MyLinkedList() 
        {
            head = null;
            arrayLenght = 0;
        }
        public void Add(T[] item)
        {
            if (head == null)
            {
                head=tail = new QueueItem<T> (item);
            }
            else
            {
                var array = new QueueItem<T>(item);
                tail.nextArray = array;
                tail = array;
            }
        }
        public void Get(int index)//получение элемента по индексу
        {
            
            var currentArray=head;
            var masLenght = head.value.Length;
            if (index<0)
                throw new ArgumentOutOfRangeException("index cannot be less than zero");
            while (index>masLenght)
            {
                currentArray = currentArray.nextArray;
                index -=masLenght;
                masLenght=currentArray.value.Length;
            }
            if (index == masLenght)
            {
                var k =currentArray.value[index-1];
                Console.WriteLine (k);
            }
            else
            {
                var k = currentArray.value[index - 1];
                Console.WriteLine (k);
            }
        }
        public int FoundCount()
        {
            var item=head;
            var count = 1;
            while (item.nextArray == null)
            {
                count++;
                item = item.nextArray;
            }
            return count;
        }
    }
}
