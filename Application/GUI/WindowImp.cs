using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.Lexi.Application.GUI
{
    public interface WindowImp
    {
        string DrawnText { get; }

        void DrawText(string text);

        void RemoveTextChars(int numberOfChars);
    }
}
