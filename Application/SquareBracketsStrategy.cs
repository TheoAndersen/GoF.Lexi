using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoF.Lexi.Application.GUI;

namespace GoF.Lexi.Application
{
    public class SquareBracketsStrategy : Strategy
    {
        public void Compose(Glyph item, Window window)
        {
            window.DrawText("[");
            item.Draw(window);
            window.DrawText("]");
        }
    }
}
