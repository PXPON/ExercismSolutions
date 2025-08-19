class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() {
        return 40;
    }
    
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int timeElapsed) {
        int remainingMinutes = ExpectedMinutesInOven() - timeElapsed;
        return remainingMinutes;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers) {
        return 2*layers;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int timeInOven) {
        return timeInOven + 2*layers;
    }
}
