//
//  main.swift
//  test_260223
//
//  Created by kaku on 2026/02/23.
//

import Foundation

// ------------------------------------------
struct Member {
    let name: String
    var level = 1
    var age: Int
}

// var 변수 = 구조체명( 변수1: 값, 변수2: 값, 변수3: 값 ...)
var member1 = Member(name: "스즈키", level: 99, age: 43)
var member2 = Member(name: "kaku", age: 43)

let text1 = "\(member1.name)씨 \(member1.age)세 레벨:\(member1.level)"
member2.level += 1
let text2 = "\(member2.name)씨 \(member2.age)세 레벨:\(member2.level)"
print(text1)
print(text2)

let ageSum = member1.age + member2.age
let text3 = "연령의 합계는 \(ageSum)세"
print(text3)
// ------------------------------------------
// 구조체 이니셜라이저 init()
struct Box {
    let width: Int
    let height: Int
    let size: String

    init(width: Int, height: Int) {
        self.width = width
        self.height = height
        if (width + height) < 120 {
            size = "M"
        } else {
            size = "L"
        }
    }
}
let box1 = Box(width: 50, height: 50)
let box2 = Box(width: 40, height: 100)
print(box1)
print(box2)
// ------------------------------------------
// 프로토콜 = 규격같은 것으로 구현하지 않으면 안되는 프로퍼티(변수), 메소드(함수)가 정해져 있다.
//struct 구조체명: 프로토콜{
//    var 변수
//}
//struct ContentView: View{
//    // View프로토콜에 따라서 body변수가 필수.
//    var body: some View{
//        Text("hello world.").padding()
//    }
//}
// ------------------------------------------
// 유저 함수
//func 함수명(인수명1: 형, 인수명2: 형, ...) -> 반환값의 형{
//    구문
//    return 반환값
//}
func calc(adult: Int, child: Int) -> Int {
    let money = adult * 1200 + child * 500
    return money
}
let price = calc(adult: 3, child: 2)
print(price)
//let price2 = calc(3,2) // error
//print(price2)
// ------------------------------------------
// 인수 초기값 설정. 생략가능한 인수
//func 함수명(인수명1: 형 = 초기값, 인수명2: 형 = 초기값, ...) -> 반환값의 형{
//    구문
//    return 반환값
//}
func calc2(adult: Int = 0, child: Int = 0) -> Int {
    let money = adult * 1200 + child * 500
    return money
}
let price2 = calc2(adult: 2)
let price3 = calc2(child: 2)
print(price2)
print(price3)
// ------------------------------------------
// 값 반환 하지 않는 함수
//func 함수명(인수명1: 형 = 초기값, 인수명2: 형 = 초기값, ...) -> Void {
//    구문
//} // return문이 없음
var isPlay = false
func play() {
    isPlay = true
}
play()
print(isPlay)
// ------------------------------------------
