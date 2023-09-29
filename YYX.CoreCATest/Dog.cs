namespace YYX.CoreCATest;

public class DateRange
{
    public DateRange(DateTime startTime, DateTime endTime)
    {
        StartTime = startTime;
        EndTime = endTime;
    }

    public DateTime StartTime { get; private set; }
     
    public DateTime EndTime { get; private set; }
}

public class Dog
{
    private readonly string yellowDog;

    public Dog(string yellowDog)
    {
        this.yellowDog = yellowDog;
    }

    public static void GetDog(DateRange dateRange)
    {
        var dog = new Dog("Yellow Dog");
    }
}