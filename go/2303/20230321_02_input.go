package main

import (
	"bufio"
	"fmt"
	"math/rand"
	"os"
	"time"
)

var stdin = bufio.NewReader(os.Stdin)

func InputIntValue() (int, error) {
	var n int
	_, err := fmt.Scanln(&n)
	if err != nil {
		stdin.ReadString('\n')
	}
	return n, err
}

func main() {
	fmt.Println("---------------------------------")
	rand.Seed(time.Now().UnixNano())

	r := rand.Intn(10)
	cnt := 1
	for {
		fmt.Printf("숫자 값을 입력해라:")
		n, err := InputIntValue()
		if err != nil {
			fmt.Println("숫자만 입력하세요.")
		} else {
			fmt.Println("입력하신 숫자는 ", n, " 입니다.")
			if n > r {
				fmt.Println("입력하신 숫자가 더 큽니다.")
			} else if n < r {
				fmt.Println("입력하신 숫자가 더 작습니다.")
			} else {
				fmt.Println("숫자를 맞췄습니다. 축하합니다. 시도횟수:", cnt)
			}
		}
		cnt++
	}
}
