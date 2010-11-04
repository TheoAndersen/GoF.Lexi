using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoF.Lexi.Application.GUI;

namespace GoF.Lexi.Application
{
    public abstract class Glyph
    {
        public abstract void Draw(Window window);

        public virtual void Insert(Glyph glyph)
        {
            throw new InvalidOperationException("Only a row glyph must use insert");
        }
    }
}
