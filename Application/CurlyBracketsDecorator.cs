using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.Lexi.Application
{
    public class CurlyBracketsDecorator : Decorator
    {
        public CurlyBracketsDecorator(Glyph component) : base(component)
        {
        }

        public override string Draw()
        {
            return "{" + base.component.Draw() + "}";
        }
    }
}
