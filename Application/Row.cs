using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public override string Draw()
        {
            StringBuilder result = new StringBuilder();

            foreach (Glyph item in children)
            {
                if (strategy != null)
                    result.Append(strategy.Compose(item.Draw()));
                else
                    result.Append(item.Draw());

                result.Append(", ");
            }

            return result.ToString().Substring(0, result.ToString().Length - 2);
        }

        public override void Insert(Glyph glyph)
        {
            children.Add(glyph);
        }
    }
}
