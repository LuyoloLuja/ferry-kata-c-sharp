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
        Assert.Equal(1, ferryKata.GetCarCount());
        Assert.Equal(2, ferryKata.GetPeopleCount());
    }

    [Fact]
    public void ShouldRejectCarIfNumberIsExceeded()
    {
        // number of cars should be 10 or less, for now since the condition for numberOfCarsAllowed is hard coded
        FerryKata ferryKata = new FerryKata(11, 5);
        Car car = new Car("red", 4);
        
        String result = ferryKata.Board(car, 4);
        
        Assert.Equal("Rejected", result);
        Assert.Equal(0, ferryKata.GetCarCount());
        Assert.Equal(0, ferryKata.GetPeopleCount());
    }

    [Fact]
    public void ShouldRejectPeopleIfNumberIsExceeded()
    {
        FerryKata ferryKata = new FerryKata(4, 5);
        Car car = new Car("red", 5);

        // peopleBoarding should be less than numberOfPeopleAllowed
        String result = ferryKata.Board(car, 6);
        
        Assert.Equal("Rejected", result);
        Assert.Equal(0, ferryKata.GetCarCount());
        Assert.Equal(0, ferryKata.GetPeopleCount());
    }

    [Fact]
    public void ShouldBeAbleToGiveDiscount()
    {
        FerryKata ferryKata = new FerryKata(10, 15);
        Car car = new Car("red", 5);

        ferryKata.Board(car, 1);
        ferryKata.Board(car, 1);
        ferryKata.Board(car, 1);
        ferryKata.Board(car, 1);
        ferryKata.Board(car, 1);

        Assert.Equal("Half Price", ferryKata.GiveDiscount(car));
        Assert.Equal(5, ferryKata.GetCarCount());
        Assert.Equal(5, ferryKata.GetPeopleCount());
    }

    [Fact]
    public void ShouldBeAbleToGiveFreeRides()
    {
        FerryKata ferryKata = new FerryKata(10, 15);
        Car car = new Car("red", 10);

        ferryKata.Board(car, 1);
        ferryKata.Board(car, 1);
        ferryKata.Board(car, 1);
        ferryKata.Board(car, 1);
        ferryKata.Board(car, 1);
        ferryKata.Board(car, 1);
        ferryKata.Board(car, 1);
        ferryKata.Board(car, 1);

        Assert.Equal("You go free", ferryKata.GiveDiscount(car));
        Assert.Equal(8, ferryKata.GetCarCount());
        Assert.Equal(8, ferryKata.GetPeopleCount());
    }

    [Fact]
    public void ShouldGetNumberOfCarsWithSameColor()
    {
        FerryKata ferryKata = new FerryKata(10, 15);

        Car redCar = new Car("red", 10);        
        Car blueCar = new Car("blue", 10);

        ferryKata.Board(redCar, 1);
        ferryKata.Board(redCar, 1);
        ferryKata.Board(blueCar, 1);
        ferryKata.Board(blueCar, 1);

        Assert.Equal("2 red car(s)", ferryKata.GetCarsOfTheSameColor(redCar));
        Assert.Equal("2 blue car(s)", ferryKata.GetCarsOfTheSameColor(blueCar));
        Assert.Equal(4, ferryKata.GetCarCount());
        Assert.Equal(4, ferryKata.GetPeopleCount());
    }
}