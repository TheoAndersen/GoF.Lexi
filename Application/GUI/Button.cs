using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoF.Lexi.Application.Commands;

namespace GoF.Lexi.Application.GUI
{
    public abstract class Button : Glyph
    {
        Command clickCommand;

        public Button(Command clickCommand)
        {
            this.clickCommand = clickCommand;
        }
        
        public void Click()
        {
            clickCommand.Execute();
        }
    }
}
