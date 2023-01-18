namespace SimpleAPI.Test;
using SimpleAPI.Controllers;

public class UnitTest1
{
    WeatherForecastController wfc = new WeatherForecastController();

    [Fact]
    public void GetControllerResult()
    {
        var output1 = wfc.Get(1) ;
        Assert.Equal("mathews",output1.Value);
    }

    [Fact]
    public void Test1()
    {

    }
}