using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.Lexi.Application.GUI
{
    public class TextWindow : Window
    {
        public TextWindow(WindowImp windowImpl) : base(windowImpl)
        {
        }

        public override string DrawnText 
        { 
            get
            {
                return base.windowImplementation.DrawnText;
            }
        }

        public override void DrawText(string input)
        {
            base.windowImplementation.DrawText(input);
        }

        public override void RemoveTextChars(int numberOfChars)
        {
            base.windowImplementation.RemoveTextChars(numberOfChars);
        }
    }
}
