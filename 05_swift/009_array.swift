// 2025/12/14
//
// 배열
//
// let 배열: [요소형] = [요소1, 요소2, 요소3, ... ] 
// ↑ 배열의 요소값 변경불가
// var 배열: [요소형] = [요소1, 요소2, 요소3, ... ]
//
// 
//
//
import SwiftUI

let week: [String]
var nums: [Int]
var colors: [Color]
week = ["일", "월", "화", "수", "목", "금", "토"]
nums = [4, 8, 15, 16, 23, 42]
colors = [.red, .yellow, .green]

print(week)
print(nums)
print(colors)
print("---------------------------------------------")
let abcArray = ["a", "b", "c", "d"]
let lettor0 = abcArray[0]
let lettor1 = abcArray[1]

print(lettor0)
print(lettor1)
var colors2 = ["녹색", "빨강", "파랑", "핑크"]
print("---------------------------------------------")
print(colors2)
colors2[1...2] = ["red", "blue", "yellow"]
print(colors2)
print(colors2[2...3])
print("---------------------------------------------")
// 요소추가
var words: [String] = []
words.append("꽃")
words.append("새")
words.append("바람")
words.append("달")
print(words)
print("---------------------------------------------")
// 빈 배열만들기
// 방법1
// [요소의 형]()
// 방법2
// Array<요소의 형>()
var members = [String]()
members.append("str11")
members.append("str22")
members.append(contentsOf: ["str33", "str44", "str55", "str66"])
print(members)
print("---------------------------------------------")
let basicCourse = ["ラン", "スイム"]
let optionCourse = ["バイク", "カヌー"]
let fullCourse = basicCourse + optionCourse
print(fullCourse)
print("---------------------------------------------")
// 배열 소트
// import UIKit <-- 불필요

var data = Array<Double>()
let data1 = [3.6, 5.7, 2.2]
let data2 = [4.0, 3.1, 5.3]

data += data1
data += data2

print(data)

data.sort() // == data.sort(by:<)
print(data)

data.sort(by:>)
print(data)
print("---------------------------------------------")
// slice
let colorList = ["blue", "yellow", "red", "green", "pink"]
let myColor = colorList[1...3]
print(myColor)

let names = ["鈴木", "松原", "曽根", "安藤", "山田", "山本", "松田"]
let half = names.count / 2
let group1 = names[..<half]
let group2 = names[half...]

print(group1)
print(group2)
print("---------------------------------------------")
