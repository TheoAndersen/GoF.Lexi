using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoF.Lexi.Application;
using GoF.Lexi.Application.GUI;

namespace GoF.Lexi.Test
{
    [TestClass]
    public class StrategyTest
    {
        private Window window;

        [TestInitialize]
        public void TestInitialize()
        {
            window = new Window();
        }


        [TestMethod]
        public void Draw_Row_With_Two_Rectangles_With_SpacesStrategy()
        {
            Row row = new Row(new SpacesStrategy());

            row.Insert(new Rectangle());
            row.Insert(new Rectangle());

            row.Draw(window);

            Assert.AreEqual("(Rectangle), (Rectangle)", window.DrawnText);
        }

        [TestMethod]
        public void Draw_Row_With_Two_Rectangles_With_SquareBracketsStrategy()
        {
            Row row = new Row(new SquareBracketsStrategy());

            row.Insert(new Rectangle());
            row.Insert(new Rectangle());

            row.Draw(window);

            Assert.AreEqual("[Rectangle], [Rectangle]", window.DrawnText);
        }

        [TestMethod]
        public void Draw_Row_With_Rectangle_And_Circle_First_With_SpacesStrategy_Then_With_BracketsStrategy()
        {
            Row row = new Row(new SpacesStrategy());

            row.Insert(new Circle());
            row.Insert(new Rectangle());

            row.Draw(window);

            row.strategy = new SquareBracketsStrategy();

            row.Draw(window);

            Assert.AreEqual("(Circle), (Rectangle)[Circle], [Rectangle]", window.DrawnText);
        }
    }
}
