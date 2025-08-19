package techpalace
import "strings"

// WelcomeMessage returns a welcome message for the customer.
func WelcomeMessage(customer string) string {
    return "Welcome to the Tech Palace, " + strings.ToUpper(customer) 
}

// AddBorder adds a border to a welcome message.
func AddBorder(welcomeMsg string, numStarsPerLine int) string {
    borderString := 
    	strings.Repeat("*", numStarsPerLine) + "\n" +
    	welcomeMsg +
    	"\n" + strings.Repeat("*", numStarsPerLine)

    return borderString
}

// CleanupMessage cleans up an old marketing message.
func CleanupMessage(oldMsg string) string {
    newMessage := strings.ReplaceAll(oldMsg, "*", "")
    newMessage = strings.ReplaceAll(newMessage, "\n", "")
	// Trim the whitespace
    newMessage = strings.Trim(newMessage, " ")
    
    return newMessage
}
