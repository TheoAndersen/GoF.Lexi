using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoF.Lexi.Application;

namespace GoF.Lexi.Test
{
    [TestClass]
    public class StrategyTest
    {
        [TestMethod]
        public void Draw_Row_With_Two_Rectangles_With_SpacesStrategy()
        {
            Row row = new Row(new SpacesStrategy());

            row.Insert(new Rectangle());
            row.Insert(new Rectangle());

            string result = row.Draw();

            Assert.AreEqual("(Rectangle), (Rectangle)", result);
        }

        [TestMethod]
        public void Draw_Row_With_Two_Rectangles_With_SquareBracketsStrategy()
        {
            Row row = new Row(new SquareBracketsStrategy());

            row.Insert(new Rectangle());
            row.Insert(new Rectangle());

            string result = row.Draw();

            Assert.AreEqual("[Rectangle], [Rectangle]", result);
        }

        [TestMethod]
        public void Draw_Row_With_Rectangle_And_Circle_First_With_SpacesStrategy_Then_With_BracketsStrategy()
        {
            Row row = new Row(new SpacesStrategy());

            row.Insert(new Circle());
            row.Insert(new Rectangle());

            string result = row.Draw();

            row.strategy = new SquareBracketsStrategy();

            result += ", " + row.Draw();

            Assert.AreEqual("(Circle), (Rectangle), [Circle], [Rectangle]", result);
        }
    }
}
