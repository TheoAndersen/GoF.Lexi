using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.Lexi.Application.GUI
{
    public class Window
    {
        StringBuilder drawnText;

        public string DrawnText 
        { 
            get
            {
                return drawnText.ToString();
            }
        }

        public Window ()
	    {
            drawnText = new StringBuilder();
	    }

        public void DrawText(string input)
        {
            drawnText.Append(input);
        }

        
    }
}
