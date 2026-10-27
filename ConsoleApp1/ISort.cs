using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }
}
