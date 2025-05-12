using Moq;
using WeatherxUnit.Classes;
using WeatherxUnit.Interfaces;

namespace WeatherReportTest
{
    /// <summary>
    /// WeatherReportServiceTests
    /// Testing WeatherReportService..
    /// </summary>
    public class WeatherReportServiceTests
    {

        readonly Mock<ILogger> _mockLogger;
        readonly Mock<ITemperature> _mockTemperature;
        readonly IWeatherService _weatherService;

        /// <summary>
        /// Constructor
        /// </summary>
        public  WeatherReportServiceTests()
        {
            _mockLogger = new Mock<ILogger>();
            _mockTemperature = new Mock<ITemperature>();
            _weatherService = new WeatherReportService(_mockLogger.Object, _mockTemperature.Object);
        }

        /// <summary>
        /// Testing for cold condition
        /// </summary>
        [Fact]
        public void GetClimate_LocationIsMumbai_Returnscold() /// check name convention *
        {
            //Arrange
            _mockTemperature.Setup(x => x.GetTemperature()).Returns(9);
            string city = "mumbai";
            string expectedValue = $"The climate of the {city} is cold";

            //Act
            string msg = _weatherService.GetClimate(city);

            //Assert
            _mockLogger.Verify(x => x.LogInfo(It.Is<string>(msg => msg.Contains($"This function called for city:{city}"))));
            //_mockLogger.Verify(x => x.LogInfo($"This function called for city:{city} at {DateTime.Now} "));
            _mockTemperature.Verify(x => x.GetTemperature());
            Assert.Equal(expectedValue, msg);
        }

        /// <summary>
        /// Testing for warm condition
        /// </summary>
        [Fact]
        public void GetClimate_LocationIsDelhi_Returnswarm()
        {
            //Arrange
            _mockTemperature.Setup(x => x.GetTemperature()).Returns(11);
            string city = "delhi";
            string expectedValue = $"The climate of the {city} is warm";

            //Act
            string message = _weatherService.GetClimate(city);

            //Assert
            _mockLogger.Verify(x => x.LogInfo(It.Is<string>(msg => msg.Contains($"This function called for city:{city}"))));
            _mockTemperature.Verify(x => x.GetTemperature());
            Assert.Equal(expectedValue, message);

        }
    }
}