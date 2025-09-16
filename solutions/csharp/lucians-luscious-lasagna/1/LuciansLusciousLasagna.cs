class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
        => 40;

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int passedTime)
        => ExpectedMinutesInOven() - passedTime;

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int numOfLayers)
        => numOfLayers * 2;

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numOfLayers, int passedTime)
        => PreparationTimeInMinutes(numOfLayers) + passedTime;
}
