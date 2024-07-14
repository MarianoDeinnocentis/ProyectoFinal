using Proyecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto

{
    internal interface IABMC<T>: IID
    {
        void Modify (T dato);
        void Add (T dato);
        void Erase (T dato);
        Usuario Find (T dato);
    }
}
