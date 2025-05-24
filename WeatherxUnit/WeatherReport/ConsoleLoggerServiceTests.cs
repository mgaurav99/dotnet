using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using WeatherReport.Classes;
using WeatherReport.Interfaces;

namespace WeatherReportTest
{
    /// <summary>
    /// ConsoleLoggerServiceTests
    /// Contains unit tests for ConsoleLoggerService class.
    /// </summary>
    public class ConsoleLoggerServiceTests
    {
        readonly IConsoleLoggerService _consoleloggerService;

        /// <summary>
        /// Constructor
        /// </summary>
        public ConsoleLoggerServiceTests()
        {
            _consoleloggerService = new ConsoleLoggerService();
        }

        /// <summary>
        /// Test case to log errors to console.
        /// </summary>
        [Fact]
        public void LogError_WriteMessageToConsole_ReturnsNothing()
        {
            //Arrange
            string expectedMessage = "Sample message with red foreground color!";
            StringWriter messageConsole = new StringWriter();
            Console.SetOut(messageConsole);

            //Act
            _consoleloggerService.LogError(expectedMessage);
            string  actualmessageConsole = messageConsole.ToString().TrimEnd();

            //Assert
            expectedMessage.Should().Be(actualmessageConsole);
        }

        /// <summary>
        /// Test case to log information to console.
        /// </summary>
        [Fact]
        public void LogInfo_WriteInformationToConsole_ReturnsNothing()
        {
            //Arrange
            string expectedMessage = "Sample message with white foreground color!";
            StringWriter messageConsole = new StringWriter();
            Console.SetOut(messageConsole);

            //Act
            _consoleloggerService.LogInfo(expectedMessage);
            string actualMessageConsole = messageConsole.ToString().TrimEnd();

            //Assert
            actualMessageConsole.Should().Be(expectedMessage);
            
        }

        /// <summary>
        /// Test case to log warning to console.
        /// </summary>
        [Fact]
        public void LogWarning_WriteWarningToConsole_ReturnsNothing()
        {
            //Arrange
            string expectedMessage = "Sample message with yellow foreground color!";
            StringWriter messageConsole = new StringWriter();
            Console.SetOut(messageConsole);

            //Act
            _consoleloggerService.LogWarning(expectedMessage);
            string actualMessageConsole = messageConsole.ToString().TrimEnd();

            //Assert
            actualMessageConsole.Should().Be(expectedMessage);

        }


    }
}
