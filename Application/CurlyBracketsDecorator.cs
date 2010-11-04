using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoF.Lexi.Application.GUI;

namespace GoF.Lexi.Application
{
    public class CurlyBracketsDecorator : Decorator
    {
        public CurlyBracketsDecorator(Glyph component) : base(component)
        {
        }

        public override void Draw(Window window)
        {
            window.DrawText("{");
            base.component.Draw(window);
            window.DrawText("}");
        }
    }
}
