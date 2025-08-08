using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02C_Advanced
{
    internal class FixedSizeList<T>
    {
        private int listSize ;
        private List<T> list;
        public FixedSizeList(int size)
        { 
            listSize = size;
            list = new List<T>();
        }
        public void Add(T item)
        {
            if (list.Count >= listSize)
                throw new ArgumentException("Size List is Full You can't add item");
            list.Add(item);
        }
        public T GetElementListByIndex(int idex)
        {
            if (idex < 0 || idex >= list.Count)
                throw new ArgumentException("Invalid index");
            return list[idex];
        }
    }
}
