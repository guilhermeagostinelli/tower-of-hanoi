using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HanoiTower
{
    public class CustomExceptions : Exception
    {
        public CustomExceptions() : base() { }
        public CustomExceptions(string message) : base(message) { }
        public CustomExceptions(string message, Exception e) : base(message, e) { }
    }
}
