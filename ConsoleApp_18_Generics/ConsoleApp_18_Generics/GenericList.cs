using System.Collections.Generic;

namespace ConsoleApp_18_Generics
{
    class GenericList<T>
    {  
        public List<T> CreateList(T t)
        {
            List<T> list = new List<T>();

            list.Add(t);

            return list;
        }
    }
}
