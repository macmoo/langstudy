package main

import "fmt"

func main() {
	fmt.Println("---------------------------------")
	i := 0 // 외부 변수
	f := func() {
		//  i값이 함수 리터럴이 정의되는 시점이 아닌 함수가 호출되는 시점 값으로 사용되는 것을 주의
		i += 10
	}
	fmt.Println(i)
	fmt.Println("---------------------------------")
	i++
	fmt.Println(i)
	fmt.Println("---------------------------------")
	f()
	fmt.Println(i)
	fmt.Println("---------------------------------")
}

// ---------------------------------
// 0
// ---------------------------------
// 1
// ---------------------------------
// 11
// ---------------------------------
