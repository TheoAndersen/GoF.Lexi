using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoF.Lexi.Application.GUI;
using GoF.Lexi.Application.Commands;

namespace GoF.Lexi.Application.GUI
{
    public class WindowsFactory : GUIFactory
    {
        public Button CreateButton(Window window)
        {
            return new WindowsButton(new ClickCommand(window));
        }
    }
}
