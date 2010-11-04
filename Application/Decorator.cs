using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoF.Lexi.Application.GUI;

namespace GoF.Lexi.Application
{
    public abstract class Decorator : Glyph
    {
        protected Glyph component;

        public Decorator(Glyph component)
        {
            this.component = component;
        }

        public override void Draw(Window window)
        {
            component.Draw(window);
        }
    }
}
