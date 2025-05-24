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
    /// TemperatureServiceTest 
    /// contains test cases for TemperatureService.
    /// </summary>
    public class TemperatureServiceTest
    {
        readonly ITemperatureService _temperatureService;
        /// <summary>
        /// Constructor
        /// </summary>
        public TemperatureServiceTest()
        {
            _temperatureService = new TemperatureService();
        }

        /// <summary>
        /// Test case to check if returned temperature is between 10 and 50
        /// </summary>
        [Fact]
        void GetTemperature_ReturnsRandomTemperatureBetween10And50()
        {
            //Arrange
            int temp = 0;

            //Act
            temp = _temperatureService.GetTemperature();

            //Assert
            temp.Should().BeInRange(10, 50);
        }
    }
}
