using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        private ErrorLogger _logger;

        [SetUp]
        public void SetUp() => _logger = new ErrorLogger();
        
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            
        }
    }
}