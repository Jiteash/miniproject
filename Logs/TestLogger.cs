using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using log4net.Layout;
using log4net.Appender;
using log4net.Core;
using log4net.Config;
using log4net;

namespace miniproject.Logs
{   
    [TestClass]
    public class TestLogger       
    {
        [TestMethod]
        public void TestLog4Net()
        {
            var PatternLayout = new PatternLayout();
            PatternLayout.ConversionPattern = "%messages%newline";
            PatternLayout.ActivateOptions();

            var consoleAppender = new ConsoleAppender()
            {
                Name = "Console Appender",
                Layout = PatternLayout,
                Threshold = Level.All

            };

            var fileappender = new FileAppender()
            {
                Name = "Fileappender",
                Layout = PatternLayout,
                Threshold = Level.All,
                AppendToFile= true,
                File= "Filelogger.log",

            };
            fileappender.ActivateOptions();
            consoleAppender.ActivateOptions();
            BasicConfigurator.Configure(consoleAppender, fileappender);

            ILog logger = LogManager.GetLogger(typeof(TestLogger));

            logger.Debug("This is Debug information");
            logger.Info("This is Info information");
            logger.Warn("This is Warn information");
            logger.Error("This is Error information");
            logger.Fatal("This is Fatal information");
        }

    }
}
