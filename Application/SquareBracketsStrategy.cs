using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.Lexi.Application
{
    public class SquareBracketsStrategy : Strategy
    {
        public string Compose(string input)
        {
            return "[" + input + "]";
        }
    }
}
