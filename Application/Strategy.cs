using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoF.Lexi.Application.GUI;

namespace GoF.Lexi.Application
{
    public interface Strategy
    {
        void Compose(Glyph item, Window window);
    }
}
