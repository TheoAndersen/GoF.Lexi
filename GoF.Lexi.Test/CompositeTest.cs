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
    public class CompositeTest
    {
        private Window window;

        [TestInitialize]
        public void TestInitialize()
        {
            window = new Window();
        }

        [TestMethod]
        public void Create_A_Single_Rectangle()
        {
            Glyph rectangle = new Rectangle();
            
            rectangle.Draw(window);

            Assert.AreEqual("Rectangle", window.DrawnText);
        }

        [TestMethod]
        public void Create_Composite_Of_Two_Rectangles()
        {
            Row row = new Row();
                        
            row.Insert(new Rectangle());
            row.Insert(new Rectangle());

            row.Draw(window);

            Assert.AreEqual("Rectangle, Rectangle", window.DrawnText);
        }

        [TestMethod]
        public void Create_Composite_Of_A_Rectangle_And_A_Circle()
        {
            Row row = new Row();

            row.Insert(new Rectangle());
            row.Insert(new Circle());

            row.Draw(window);

            Assert.AreEqual("Rectangle, Circle", window.DrawnText);
        }
    }
}
