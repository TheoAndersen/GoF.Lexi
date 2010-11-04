using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.Lexi.Application.GUI
{
    public class MacButton : Button
    {
        public override void Draw(Window window)
        {
            window.DrawText("MacButton");
        }
    }
}
