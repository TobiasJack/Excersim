class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] {0,2,5,3,7,8,4};
    }

    public int Today()
    {
        Array.Reverse(birdsPerDay);
        return birdsPerDay[0];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[^1]++;
    }

    public bool HasDayWithoutBirds()
    {
        return birdsPerDay.Any(x => x<= 0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
        if(numberOfDays >7)
            numberOfDays = 7;
        return birdsPerDay[..numberOfDays].Sum();
    }

    public int BusyDays()
    {
        return birdsPerDay.Where(x => x >= 5).Count();
    }
}
