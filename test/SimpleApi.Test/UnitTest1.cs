using System;
using Xunit;
using SimpleAPI.Controllers;
namespace SimpleApi.Test
{
    public class UnitTest1
    {

        WeatherForecastController weatherForecastController = new WeatherForecastController();

        [Fact]
        public void getReturnValueHello()
        {
            var result = weatherForecastController.getNewValue(1);
            Assert.Equal("Hello", result.ToString());
        }
        [Fact]
        public void Test1()
        {

        }
    }
}
