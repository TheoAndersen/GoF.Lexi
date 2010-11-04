using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoF.Lexi.Application.GUI;

namespace GoF.Lexi.Application.GUI
{
    public class WindowsFactory : GUIFactory
    {
        public Button CreateButton()
        {
            return new WindowsButton();
        }
    }
}
