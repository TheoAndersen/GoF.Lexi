using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoF.Lexi.Application.Commands
{
    public abstract class Command
    {
        protected static List<Command> commands = new List<Command>();

        public abstract void Execute();

        public abstract void Unexecute();

        public static void Undo()
        {
            if (commands.Last() != null)
            { 
                commands.Last().Unexecute();
                commands.Remove(commands.Last());
            }
        }
    }
}
