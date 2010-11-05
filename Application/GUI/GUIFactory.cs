using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoF.Lexi.Application.GUI;

namespace GoF.Lexi.Application.GUI
{
    public interface GUIFactory
    {
        Button CreateButton(Window window);
    }
}
