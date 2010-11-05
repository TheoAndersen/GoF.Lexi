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
    public class AbstractFactoryTest
    {

        /*   Abstract Factories allow us to create families of related products (only one implemented here)
         *   without instantiated the classes directly.
         * 
         *   Therefore by setting another factory we could instantiate a whole other family of classees, 
         *   without depending directly on them
         */

        private Window window;

        [TestInitialize]
        public void TestInitialize()
        {
            window = new TextWindow(new SimpleTextWindowImp());
        }

        [TestMethod]
        public void Use_A_MacFactory_To_Create_A_Button()
        {
            GUIFactory factory = new MacFactory();

            factory.CreateButton(window).Draw(window);

            Assert.AreEqual("MacButton", window.DrawnText);
        }

        [TestMethod]
        public void Use_A_WindowsFactory_To_Create_A_Button()
        {
            GUIFactory factory = new WindowsFactory();

            factory.CreateButton(window).Draw(window);

            Assert.AreEqual("WindowsButton", window.DrawnText);
        }
    }
}
