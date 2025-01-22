using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Definitions;
using FlaUI.UIA3;
using NUnit.Framework;
using System;

namespace TrumpfMetamation_Task1
{
    [TestFixture]
    public class Task1Automation
    {
        private Application app;
        private AutomationBase automation;

        [SetUp]
        public void Setup()
        {
            app = Application.Launch("explorer.exe");
            automation = new UIA3Automation();
        }

        [Test]
        public void AutomateDirectoryAndFileHandling()
        {
            var desktop = automation.GetDesktop();
            var explorer = desktop.FindFirstChild(cf => cf.ByControlType(ControlType.Window));

            Assert.NotNull(explorer, "File Explorer did not launch successfully.");

            // Automate file explorer interactions
            explorer.AsWindow().Focus();

            // Example: Navigate to 'D:\'
            Keyboard.Type("D:");
            Keyboard.Press(VirtualKeyShort.RETURN);

            // Create folder using UI automation
            Keyboard.Press(VirtualKeyShort.F10); // Focus on menu bar
            Keyboard.Type("New Folder");
            Keyboard.Press(VirtualKeyShort.RETURN);

            // Add file to the created folder
            Keyboard.Type("Welcome.txt");
            Keyboard.Press(VirtualKeyShort.RETURN);

            // Type content into the file
            Keyboard.Type("Hello world!");
            Keyboard.Press(VirtualKeyShort.CONTROL, VirtualKeyShort.KEY_S); // Save file

            // Verify the folder and file are created (can add assertions)
            Console.WriteLine("Folder and file automation completed.");
        }

        [TearDown]
        public void Teardown()
        {
            app?.Close();
            automation?.Dispose();
        }
    }
}
