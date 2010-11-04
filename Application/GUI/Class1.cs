using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.Lexi.Application.GUI
{
    class ConsoleWriterWindowImp : WindowImp
    {
        private StringBuilder savedText;

        public ConsoleWriterWindowImp ()
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
            Console.Write(text);
        }
    }
}
