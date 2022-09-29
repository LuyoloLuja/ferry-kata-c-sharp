namespace Ferry.Tests;
using Xunit;

public class FerryTests
{

    [Fact]
    public void ShouldBeAbleToBoard()
    {
        FerryKata ferryKata = new FerryKata(2, 2);
        Car car = new Car("red", 2);

        String result = ferryKata.Board(car, 2);

        Assert.Equal("Allowed", result);
    }

    [Fact]
    public void ShouldRejectCarIfNumberIsExceeded()
    {
        // number of cars should be 5 or less
        FerryKata ferryKata = new FerryKata(6, 5);
        Car car = new Car("red", 4);
        
        String result = ferryKata.Board(car, 4);
        
        Assert.Equal("Rejected", result);
    }

    [Fact]
    public void ShouldRejectPeopleIfNumberIsExceeded()
    {
        FerryKata ferryKata = new FerryKata(10, 5);
        Car car = new Car("red", 5);
        
        String result = ferryKata.Board(car, 6);
        
        Assert.Equal("Rejected", result);
    }
}