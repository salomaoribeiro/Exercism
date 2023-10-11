class Lasagna
{
    private const int TIME = 40;
    private const int MINUTES_FOR_LAYERS = 2;

    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => TIME;

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int value) => TIME - value;

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers) => layers * MINUTES_FOR_LAYERS;

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int minutes) => PreparationTimeInMinutes(layers) + minutes;
}
