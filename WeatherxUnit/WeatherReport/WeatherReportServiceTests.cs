using Moq;
using WeatherxUnit.Classes;
using WeatherxUnit.Interfaces;

namespace WeatherReportTest
{
    /// <summary>
    /// WeatherReportServiceTests
    /// Contains unit tests for the class,
    /// validating its behavior under various temperature conditions and input scenarios.
    /// Testing WeatherReportService
    /// </summary>
    public class WeatherReportServiceTests
    {
        readonly Mock<ILoggerService> _mockLoggerService;
        readonly Mock<ITemperatureService> _mockTemperatureService;
        readonly Mock<IDateTimeService> _mockDateTimeService;
        readonly IWeatherReportService _weatherService;
        DateTime sampleDate = DateTime.Parse("2023-10-01 12:00:00");

        /// <summary>
        /// Constructor
        /// </summary>
        public WeatherReportServiceTests()
        {
            _mockLoggerService = new Mock<ILoggerService>();
            _mockTemperatureService = new Mock<ITemperatureService>();
            _mockDateTimeService = new Mock<IDateTimeService>();
            _weatherService = new WeatherReportService(_mockLoggerService.Object, _mockTemperatureService.Object, _mockDateTimeService.Object);
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
            string msg = _weatherService.GetClimate(city);

            //Assert
            _mockLoggerService.Verify(x => x.LogInfo($"This function called for city:{city} at {sampleDate} "));
            _mockTemperatureService.Verify(x => x.GetTemperature());
            Assert.Equal(expectedValue, msg);
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
            string message = _weatherService.GetClimate(city);

            //Assert
            _mockLoggerService.Verify(x => x.LogInfo($"This function called for city:{city} at {sampleDate} "));
            _mockTemperatureService.Verify(x => x.GetTemperature());
            Assert.Equal(expectedValue, message);
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
            string message = _weatherService.GetClimate(city);

            //Assert
            _mockLoggerService.Verify(x => x.LogInfo($"This function called for city:{city} at {sampleDate} "));
            _mockTemperatureService.Verify(x => x.GetTemperature());
            Assert.Equal(expectedValue, message);
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
            string message = _weatherService.GetClimate(city);

            //Assert
            _mockLoggerService.Verify(x => x.LogInfo($"This function called for city:{city} at {sampleDate} "));
            _mockTemperatureService.Verify(x => x.GetTemperature());
            Assert.Equal(expectedValue, message);
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

            //Act
            var exception = Assert.Throws<ArgumentNullException>(() => _weatherService.GetClimate(city));

            //Assert
            _mockLoggerService.Verify(x => x.LogInfo($"This function called for city:{city} at {sampleDate} "));
            _mockLoggerService.Verify(x => x.LogWarning(warningMsg));
            Assert.Equal("Provide city!", exception.ParamName);
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

            //Act
            var exception = Assert.Throws<ArgumentNullException>(() => _weatherService.GetClimate(city));

            //Assert
            _mockLoggerService.Verify(x => x.LogInfo($"This function called for city:{city} at {sampleDate} "));
            _mockLoggerService.Verify(x => x.LogWarning(warningMsg));
            Assert.Equal("Provide city!", exception.ParamName);
        }
    }
}