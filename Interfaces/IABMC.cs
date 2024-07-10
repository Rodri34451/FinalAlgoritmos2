using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Algoritmos_2.Interfaces
{
    internal interface IABMC<T> : IDD
    {
        void Modify(T data);

        void Add(T data);
        
        void Erase(T data);

        T Find(T data);
    }
}
