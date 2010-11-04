using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.Lexi.Application.GUI
{
    public class MacFactory : GUIFactory
    {
        public Button CreateButton()
        {
            return new MacButton();
        }
    }
}
