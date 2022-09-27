public class FerryKata {
    private int numberOfCarsAllowed;
    private int numberOfPeopleAllowed;
    private int peopleCount;
    private List<Car> carCount = new List<Car>();

    public FerryKata(int numberOfCarsAllowed, int numberOfPeopleAllowed)
    {
        this.numberOfCarsAllowed = numberOfCarsAllowed;
        this.numberOfPeopleAllowed = numberOfPeopleAllowed;
    }

    public String Board(Car car, int peopleBoarding)
    {
        if(numberOfCarsAllowed > 5 || numberOfPeopleAllowed > 10)
        {
            return "Rejected";
        }
        else 
        {
            peopleCount += peopleBoarding;
            carCount.Add(car);
            return "Allowed";
        }
    }

    public int GetCarCount() {
        return carCount.Count;
    }

    public int GetPeopleCount() {
        return peopleCount;
    }

}