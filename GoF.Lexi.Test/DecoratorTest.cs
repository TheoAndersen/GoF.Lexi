using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoF.Lexi.Application;

namespace GoF.Lexi.Test
{
    [TestClass]
    public class DecoratorTest
    {
        [TestMethod]
        public void Rectangle_Decorated_With_CurlyBrackets()
        {
            Glyph row = new CurlyBracketsDecorator(new Rectangle());

            string result = row.Draw();

            Assert.AreEqual("{Rectangle}", result);
        }
    }
}
