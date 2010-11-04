using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoF.Lexi.Application;

namespace GoF.Lexi.Test
{
    [TestClass]
    public class CompositeTest
    {
        [TestMethod]
        public void Create_A_Single_Rectangle()
        {
            Rectangle rectangle = new Rectangle();
            
            string result = rectangle.Draw();

            Assert.AreEqual("Rectangle", result);
        }

        [TestMethod]
        public void Create_Composite_Of_Two_Rectangles()
        {
            Row row = new Row();
                        
            row.Insert(new Rectangle());
            row.Insert(new Rectangle());

            string result = row.Draw();

            Assert.AreEqual("Rectangle, Rectangle", result);
        }

        [TestMethod]
        public void Create_Composite_Of_A_Rectangle_And_A_Circle()
        {
            Row row = new Row();

            row.Insert(new Rectangle());
            row.Insert(new Circle());

            string result = row.Draw();

            Assert.AreEqual("Rectangle, Circle", result);
        }
    }
}
