using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class NonExistentTriangleException:Exception
    {
        public NonExistentTriangleException(string message) : base(message) { }
    }
}
