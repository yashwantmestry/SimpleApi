using Microsoft.Extensions.Logging;
using Moq;
using SimpleAPI.Controllers;
using System;
using System.Linq;
using Xunit;

namespace ApiTest
{
    public class UnitTest1
    {

        [Fact]
        public void TestWeatherForecast()
        {
            var ilogMock = new Mock<ILogger<WeatherForecastController>>();
            WeatherForecastController controller = new WeatherForecastController(ilogMock.Object);
            var values = controller.Get(); 
            Assert.True(values.Any());
        }


        [Fact]
        public void Test1()
        {

        }
    }
}
