using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDisposeError
{
    public class Adder : IDisposable
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public void Dispose()
        {
            //Example
        }
    }
}
