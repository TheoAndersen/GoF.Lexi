using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoF.Lexi.Application.GUI;
using GoF.Lexi.Application;
using GoF.Lexi.Application.Commands;

namespace GoF.Lexi.Test
{
    [TestClass]
    public class CommandTest
    {
        Window window;

        [TestInitialize]
        public void TestInitialize()
        {
            window = new TextWindow(new SimpleTextWindowImp());
        }

        [TestMethod]
        public void ClickCommand_Returns_Clicked()
        {
            Command command = new ClickCommand(window);

            command.Execute();

            Assert.AreEqual("Clicked", window.DrawnText);
        }

        [TestMethod]
        public void ClickCommand_Issues_Through_Button_Returns_Clicked()
        {
            Button button = new WindowsFactory().CreateButton(window);

            button.Click();

            Assert.AreEqual("Clicked", window.DrawnText);
        }

        [TestMethod]
        public void ClickCommand_Execute_And_Then_Undo_Should_Be_Empty()
        {
            Command command = new ClickCommand(window);

            command.Execute();
            Command.Undo();

            Assert.AreEqual("", window.DrawnText);
        }
    }
}
