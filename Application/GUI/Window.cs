using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.Lexi.Application.GUI
{
    public abstract class Window
    {
        protected WindowImp windowImplementation;

        public Window(WindowImp windowImplementation)
        {
            this.windowImplementation = windowImplementation;
        }

        public abstract string DrawnText { get; }

        public abstract void DrawText(string text);
    }
}
