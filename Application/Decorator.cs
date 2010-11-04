using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.Lexi.Application
{
    public abstract class Decorator : Glyph
    {
        protected Glyph component;

        public Decorator(Glyph component)
        {
            this.component = component;
        }

        public override string Draw()
        {
            return component.Draw();
        }
    }
}
