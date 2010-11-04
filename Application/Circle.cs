using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoF.Lexi.Application.GUI;

namespace GoF.Lexi.Application
{
    public class Circle : Glyph
    {
        public override void Draw(Window window)
        {
            window.DrawText("Circle"); ;
        }
    }
}
