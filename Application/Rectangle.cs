using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoF.Lexi.Application.GUI;

namespace GoF.Lexi.Application
{
    public class Rectangle : Glyph
    {
        public override void Draw(Window window)
        {
            window.DrawText("Rectangle");
        }
    }
}
