package main

import (
	"fmt"
	"math/rand"
	"time"
)

func main() {
	fmt.Println("---------------------------------")
	rand.Seed(time.Now().UnixNano())

	n := rand.Intn(100)
	fmt.Println(n)
}
