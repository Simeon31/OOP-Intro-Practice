using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0601_Ex03ListyIterator
{
    public interface IIterateList
    {
        bool Move();
        bool HasNext();
        void Print();
    }
}
