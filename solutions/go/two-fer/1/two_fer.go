// Package twofer should have a package comment that summarizes what it's about.
package twofer
import "fmt"

// Replacing blank strings with "you"
// Then, using Sprintf to return a string with the name 
// variable in it
func ShareWith(name string) string {
	if name == "" {
        name = "you"
    }
    
	return fmt.Sprintf("One for %s, one for me.", name)
}
