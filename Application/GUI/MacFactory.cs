using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoF.Lexi.Application.Commands;

namespace GoF.Lexi.Application.GUI
{
    public class MacFactory : GUIFactory
    {
        public Button CreateButton(Window window)
        {
            return new MacButton(new ClickCommand(window));
        }
    }
}
