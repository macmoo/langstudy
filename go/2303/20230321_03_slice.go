package main

import "fmt"

func main() {
	var slice []int
	if len(slice) == 0 {
		fmt.Println("slice is empty", slice)
	}
	// slice[1] = 10 // 에러
	fmt.Println(slice)
	fmt.Println("---------------------------------")
}

// slice is empty []
// []
// ---------------------------------
