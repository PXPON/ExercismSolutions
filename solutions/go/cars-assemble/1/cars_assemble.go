package cars

// CalculateWorkingCarsPerHour calculates how many working cars are
// produced by the assembly line every hour.
func CalculateWorkingCarsPerHour(productionRate int, successRate float64) float64 {
	var rate float64 = float64(productionRate) * successRate * 0.01
    return rate
}

// CalculateWorkingCarsPerMinute calculates how many working cars are
// produced by the assembly line every minute.
func CalculateWorkingCarsPerMinute(productionRate int, successRate float64) int {
    var floatRate float64 = float64(productionRate) * successRate * 0.01 / 60
    var rate int = int(floatRate)
	return rate
}

// CalculateCost works out the cost of producing the given number of cars.
func CalculateCost(carsCount int) uint {
    groupsOfTen := carsCount / 10
    individuals := carsCount % 10
	return uint(groupsOfTen*95000 + individuals*10000)
}
