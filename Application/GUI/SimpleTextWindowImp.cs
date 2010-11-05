using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.Lexi.Application.GUI
{
    public class SimpleTextWindowImp : WindowImp
    {
        private StringBuilder savedText;

        public SimpleTextWindowImp ()
	    {
            savedText = new StringBuilder();
        }

        public string DrawnText
        {
            get { return savedText.ToString(); }
        }

        public void DrawText(string text)
        {
            savedText.Append(text);
        }

        public void RemoveTextChars(int numberOfChars)
        {
            savedText.Remove(savedText.Length - numberOfChars, numberOfChars);
        }
    }
}
