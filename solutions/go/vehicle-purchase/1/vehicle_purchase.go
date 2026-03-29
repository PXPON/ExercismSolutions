package purchase
import "fmt"

// NeedsLicense determines whether a license is needed to drive a type of vehicle. Only "car" and "truck" require a license.
func NeedsLicense(kind string) bool {
	if kind == "car" {
        return true
    }

    if kind == "bike" {
        return false
    }

    if kind == "truck" {
        return true
    }
    return false
}

// ChooseVehicle recommends a vehicle for selection. It always recommends the vehicle that comes first in lexicographical order.
func ChooseVehicle(option1, option2 string) string {
	if option1 > option2 {
        return fmt.Sprintf("%s is clearly the better choice.", option2)
    }

    return fmt.Sprintf("%s is clearly the better choice.", option1)
}

// CalculateResellPrice calculates how much a vehicle can resell for at a certain age.
func CalculateResellPrice(originalPrice, age float64) float64 {
    discountedRate := 1.0 
	if age < 3 {
        discountedRate *= 0.8
    }

    if age >= 3 && age < 10 {
        discountedRate *= 0.7
    }

    if age >= 10 {
        discountedRate *= 0.5
    }
    
	return originalPrice * discountedRate
}
