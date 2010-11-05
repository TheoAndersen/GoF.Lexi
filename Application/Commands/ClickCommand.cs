using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoF.Lexi.Application.GUI;

namespace GoF.Lexi.Application.Commands
{
    public class ClickCommand : Command
    {
        Window window;

        public ClickCommand(Window window)
        {
            this.window = window;
        }

        public override void Execute()
        {
            window.DrawText("Clicked");
            Command.commands.Add(this);
        }

        public override void Unexecute()
        {
            window.RemoveTextChars(7);
        }
    }
}
