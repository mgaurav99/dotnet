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
    /// DateTimeServiceTest
    /// This class contains test cases for DateTimeService
    /// </summary>
    public class DateTimeServiceTest
    {
        readonly IDateTimeService _dateTimeService;

        /// <summary>
        /// Constructor
        /// </summary>
        public DateTimeServiceTest()
        {
            _dateTimeService = new DateTimeService();
        }

        /// <summary>
        /// Test case to check if GetCurrentDateTime() functon returns correct time. 
        /// </summary>
        [Fact]
        void GetCurrentDateTime_ReturnsCurrentDateTime()
        {
            //Arrange
            DateTime expectedDateTime = DateTime.UtcNow;
            DateTime actualDateTime;

            //Act
            actualDateTime = _dateTimeService.GetCurrentDateTime();

            //Assert
            actualDateTime.Should().HaveYear(expectedDateTime.Year);
            actualDateTime.Should().HaveMonth(expectedDateTime.Month);
            actualDateTime.Should().HaveDay(expectedDateTime.Day);
            actualDateTime.Should().HaveHour(expectedDateTime.Hour);
            actualDateTime.Should().HaveMinute(expectedDateTime.Minute);
            actualDateTime.Should().HaveSecond(expectedDateTime.Second);   
        }
    }
}
