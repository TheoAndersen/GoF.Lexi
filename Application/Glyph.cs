using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.Lexi.Application
{
    public abstract class Glyph
    {
        public abstract string Draw();

        public virtual void Insert(Glyph glyph)
        {
            throw new InvalidOperationException("Only a row glyph must use insert");
        }
    }
}
