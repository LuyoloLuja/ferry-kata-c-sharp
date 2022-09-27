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
    
    public String GetCarsOfTheSameColor(Car car) {
        int count = 0;
        String color = "";
        
        for (int i = 0; i < carCount.Count; i++)
        {
            String currentColor = carCount[i].GetColor();
            
            if(car.GetColor().Equals(currentColor))
            {
                count++;
                color = carCount[i].GetColor();
            }
        }
        return $"{count} {color} car(s)";
    }

    public String GiveDiscount(Car car)
    {
        int count = 0;
        
        foreach(Car currentCar in carCount) {
            if(currentCar == car)
            {
                count++;
            }
        }
        
        if(count > 0 && count > 3 && count <= 7) 
        {
            return "Half Price";
        }
        else{
            return "You go free";
        }
    }
}