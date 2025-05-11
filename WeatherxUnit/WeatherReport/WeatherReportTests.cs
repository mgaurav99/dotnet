using Moq;
using WeatherxUnit;

namespace WeatherReportTest
{
    public class WeatherReportTests
    {
        [Fact]
        public void GetWeatherMessage_ReturnsWarm_WhenTempAbove25()
        {
            var mockService = new Mock<IWeatherService>();
            mockService.Setup(x => x.GetTemperature("NYC")).Returns(30);
            
            var report = new WeatherReport(mockService.Object);
            var result = report.GetWeatherMessage("NYC");

            Assert.Equal("Warm", result);
        }
    }

}