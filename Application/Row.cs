using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoF.Lexi.Application.GUI;

namespace GoF.Lexi.Application
{
    public class Row : Glyph
    {
        List<Glyph> children;
        public Strategy strategy;

        public Row()
        {
            children = new List<Glyph>();
        }

        public Row(Strategy strategy) : this()
        {
            this.strategy = strategy;
        }

        public override void Draw(Window window)
        {
            for (int i = 0; i < children.Count; i++)
            {
                if (strategy != null)
                    strategy.Compose(children[i], window);
                else
                    children[i].Draw(window);

                if (i < (children.Count - 1))
                    window.DrawText(", ");
            }

            foreach (Glyph item in children)
            {
                
            }
        }

        public override void Insert(Glyph glyph)
        {
            children.Add(glyph);
        }
    }
}
