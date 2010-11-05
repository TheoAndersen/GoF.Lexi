using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoF.Lexi.Application.Commands;

namespace GoF.Lexi.Application.GUI
{
    public class MacButton : Button
    {

        public MacButton(Command clickCommand) : base(clickCommand)
        {
                
        }

        public override void Draw(Window window)
        {
            window.DrawText("MacButton");
        }
    }
}
