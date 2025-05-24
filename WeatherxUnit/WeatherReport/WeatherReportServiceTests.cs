using System.Globalization;
using FluentAssertions;
using Moq;
using WeatherReport.Classes;
using WeatherReport.Interfaces;

namespace WeatherReportTest
{
    /// <summary>
    /// WeatherReportServiceTests
    /// Contains unit tests for  class WeatherReportService
    /// validate its behavior under various temperature conditions and input scenarios.
    /// </summary>
    public class WeatherReportServiceTests
    {
        readonly Mock<IConsoleLoggerService> _mockLoggerService;
        readonly Mock<ITemperatureService> _mockTemperatureService;
        readonly Mock<IDateTimeService> _mockDateTimeService;
        readonly IWeatherReportService _weatherReportService;
        readonly DateTime sampleDate; 
        

        /// <summary>
        /// Constructor
        /// </summary>
        public WeatherReportServiceTests()
        {
             sampleDate = DateTime.Parse("2023-10-01 12:00:00", CultureInfo.InvariantCulture);
            _mockLoggerService = new Mock<IConsoleLoggerService>();
            _mockTemperatureService = new Mock<ITemperatureService>();
            _mockDateTimeService = new Mock<IDateTimeService>();
            _weatherReportService = new WeatherReportService(_mockLoggerService.Object, _mockTemperatureService.Object, _mockDateTimeService.Object);
            _mockDateTimeService.Setup(x => x.GetCurrentDateTime()).Returns(sampleDate);
        }

        /// <summary>
        /// Test case for cold condition
        /// </summary>
        [Fact]
        public void GetClimate_TemperatureLessThan10_ReturnsCold()
        {
            //Arrange
            _mockTemperatureService.Setup(x => x.GetTemperature()).Returns(9);
            string city = "mumbai";
            string expectedValue = $"The climate of the {city} is cold";

            //Act
            string msg = _weatherReportService.GetClimate(city);

            //Assert
            _mockLoggerService.Verify(x => x.LogInfo($"This function called for city:{city} at {sampleDate}"));
            _mockTemperatureService.Verify(x => x.GetTemperature());
            msg.Should().Be(expectedValue);
        }

        /// <summary>
        /// Test case for warm condition
        /// </summary>
        [Fact]
        public void GetClimate_TemperatureBetween10And30_ReturnsWarm()
        {
            //Arrange
            _mockTemperatureService.Setup(x => x.GetTemperature()).Returns(11);
            string city = "delhi";
            string expectedValue = $"The climate of the {city} is warm";

            //Act
            string message = _weatherReportService.GetClimate(city);

            //Assert
            _mockLoggerService.Verify(x => x.LogInfo($"This function called for city:{city} at {sampleDate}"));
            _mockTemperatureService.Verify(x => x.GetTemperature());
            message.Should().Be(expectedValue);
        }

        /// <summary>
        /// Test case for warm condition
        /// </summary>
        [Fact]
        public void GetClimate_TemperatureEqualsTo10_ReturnsWarm()
        {
            //Arrange
            _mockTemperatureService.Setup(x => x.GetTemperature()).Returns(10);
            string city = "delhi";
            string expectedValue = $"The climate of the {city} is warm";

            //Act
            string message = _weatherReportService.GetClimate(city);

            //Assert
            _mockLoggerService.Verify(x => x.LogInfo($"This function called for city:{city} at {sampleDate}"));
            _mockTemperatureService.Verify(x => x.GetTemperature());
            message.Should().Be(expectedValue);
        }

        /// <summary>
        /// Test case for warm condition
        /// </summary>
        [Fact]
        public void GetClimate_TemperatureEqualsTo29_ReturnsWarm()
        {
            //Arrange
            _mockTemperatureService.Setup(x => x.GetTemperature()).Returns(29);
            string city = "delhi";
            string expectedValue = $"The climate of the {city} is warm";

            //Act
            string message = _weatherReportService.GetClimate(city);

            //Assert
            _mockLoggerService.Verify(x => x.LogInfo($"This function called for city:{city} at {sampleDate}"));
            _mockTemperatureService.Verify(x => x.GetTemperature());
            message.Should().Be(expectedValue);
        }


        /// <summary>
        /// Test case for hot condition
        /// </summary>
        [Fact]
        public void GetClimate_TemperatureGreaterThan30_ReturnsHot()
        {
            //Arrange
            _mockTemperatureService.Setup(x => x.GetTemperature()).Returns(31);
            string city = "chennai";
            string expectedValue = $"The climate of the {city} is hot";

            //Act
            string message = _weatherReportService.GetClimate(city);

            //Assert
            _mockLoggerService.Verify(x => x.LogInfo($"This function called for city:{city} at {sampleDate}"));
            _mockTemperatureService.Verify(x => x.GetTemperature());
            message.Should().Be(message);
        }

        /// <summary>
        /// Test case for hot condition
        /// </summary>
        [Fact]
        public void GetClimate_TemperatureEqualTo30_ReturnsHot()
        {
            //Arrange
            _mockTemperatureService.Setup(x => x.GetTemperature()).Returns(30);
            string city = "chennai";
            string expectedValue = $"The climate of the {city} is hot";

            //Act
            string message = _weatherReportService.GetClimate(city);

            //Assert
            _mockLoggerService.Verify(x => x.LogInfo($"This function called for city:{city} at {sampleDate}"));
            _mockTemperatureService.Verify(x => x.GetTemperature());
            message.Should().Be(expectedValue);
        }

        /// <summary>
        /// Test case for empty city
        /// </summary>
        [Fact]
        public void GetClimate_CityNotProvided_ThrowArgumentNullException()
        {
            //Arrange
            string city = "";
            string warningMsg = "No city provided!";
            string expectedValue = "Provide city!";

            //Act
            var exception = Assert.Throws<ArgumentNullException>(() => _weatherReportService.GetClimate(city));

            //Assert
            _mockLoggerService.Verify(x => x.LogInfo($"This function called for city:{city} at {sampleDate}"));
            _mockLoggerService.Verify(x => x.LogWarning(warningMsg));
            expectedValue.Should().Be(exception.ParamName);
        }

        /// <summary>
        /// Test case when city is null
        /// </summary>
        [Fact]
        public void GetClimate_CityIsNull_ThrowArgumentNullException()
        {
            //Arrange
            string city = null;
            string warningMsg = "No city provided!";
            string expectedValue = "Provide city!";

            //Act
            var exception = Assert.Throws<ArgumentNullException>(() => _weatherReportService.GetClimate(city));

            //Assert
            _mockLoggerService.Verify(x => x.LogInfo($"This function called for city:{city} at {sampleDate}"));
            _mockLoggerService.Verify(x => x.LogWarning(warningMsg));
            expectedValue.Should().Be(exception.ParamName);
        }
    }
}