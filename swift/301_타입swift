import Foundation

// ------------------------------------------------
var integer: Int = -100
let unsignedInteger: UInt = 50 // UInt 타입에는 음수값을 할당할 수 없습니다.
print("integer 값  : \(integer), unsignedInteger 값: \(unsignedInteger)")
print("Int 최댓값   : \(Int.max), Int 최솟값: \(Int.min)")
print("UInt 최댓값  : \(UInt.max), UInt 최솟값: \(UInt.min)")
// ------------------------------------------------
let largeInteger: Int64         = Int64.max
let smallUnsignedInteger: UInt8 = UInt8.max
print("Int64 최댓값 : \(largeInteger), UInt8 최댓값: \(smallUnsignedInteger)")
// ------------------------------------------------
// integer 값  : -100, unsignedInteger 값: 50
// Int 최댓값   : 9223372036854775807, Int 최솟값: -9223372036854775808
// UInt 최댓값  : 18446744073709551615, UInt 최솟값: 0
// Int64 최댓값 : 9223372036854775807, UInt8 최댓값: 255
// ------------------------------------------------
// Int의 표현 범위를 초과하므로 오류를 냅니다.
// let tooLarge: Int           = Int.max + 1
// let cannotBeNegetive: UInt  = -5 
//
// UInt는 음수가 될 수 없으므로 오류를 냅니다.
// integer = unsignedInteger integer = Int(unsignedInteger)
// 오류! 스위프트에서 Int와 UInt는 다른 타입입
// ------------------------------------------------
var boolean: Bool = true
boolean.toggle()

let iLoveYou: Bool        = true
let isTimeUnlimited: Bool = false
print("시간은 무한합니까?: \(isTimeUnlimited)")
// 시간은 무한합니까?: false
// ------------------------------------------------
// Float이 수용할 수 있는 범위를 넘어섭니다.
// 자신이 감당할 수 있는 만큼만 남기므로 정확도가 떨어집니다.
var floatValue: Float = 1234567890.1
// Double은 충분히 수용할 수 있습니다.
let doubleValue: Double = 1234567890.1
print("floatValue: \(floatValue) doubleValue : \(doubleValue)")
// floatValue: 1.234568e+09 doubleValue : 1234567890.1
// ------------------------------------------------
// Float이 수용할 수 있는 범위의 수로 변경합니다.
floatValue = 123456.1
// 문자열 보간법을 사용하지 않고 단순히 변수 또는 상수의 값만 보고 싶으면
// print 함수의 전달인자로 변수 또는 상수를 전달하면 됩니다.
print(floatValue)
// 123456.1
// ------------------------------------------------
let var1 = Int.random(in: -100...100)
let var2 = UInt.random(in: 1...30)
let var3 = Double.random(in: 1.5...4.3)
let var4 = Float.random(in: -0.5...1.5)
print("var1 : \(var1)")
print("var2 : \(var2)")
print("var3 : \(var3)")
print("var4 : \(var4)")
// var1 : 86
// var2 : 7
// var3 : 3.547939478184688
// var4 : 0.6619849
// ------------------------------------------------
let alphaA: Character = "A"
print(alphaA)
// Character 값에 유니코드 문자를 사용할 수 있습니다.
let commandCharacter: Character = "♡"
print(commandCharacter)
let 한글변수이름: Character = "ㄱ"
// 한글도 유니코드 문자에 속하므로 스위프트 코드의 변수 이름으로 사용할 수 있습니다.
print("한글의 첫 자음: \(한글변수이름)")
// A
// ♡
// 한글의 첫 자음: ㄱ
// ------------------------------------------------
