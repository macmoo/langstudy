import Foundation

// ------------------------------------------------
// 상수로 선언된 문자열은 변경이 불가능합니다.
let name: String = "yagom"
// 이니셜라이저를 사용하여 빈 문자열을 생성할 수 있습니다.
// var 키워드를 사용하여 변수를 생성했으므로 문자열의 수정 및 변경이 가능합니다.
var introduce: String = String()
// append() 메서드를 사용하여 문자열을 이어붙일 수 있습니다.
introduce.append("제 이름은")
// + 연산자를 통해서도 문자열을 이어붙일 수 있습니다.
introduce = introduce + " " + name + "입니다."
print(introduce)
// name에 해당하는 문자의 수를 셀 수 있습니다.
print("name의 글자 수: \(name.count)")
// 빈 문자열인지 확인해볼 수 있습니다.
print("introduce가 비어있습니까?: \(introduce.isEmpty)")
// 유니코드의 스칼라값을 사용하면 값에 해당하는 표현이 출력됩니다 - 어떤 모양이 출력되나요?
let unicodeScalarValue: String = "\u{2665}"
// ------------------------------------------------
// 제 이름은 yagom입니다.
// name의 글자 수          : 5
// introduce가 비어있습니까? : false
// ------------------------------------------------
// 연산자를 통한 문자열 결합
let hello: String = "Hello"
let yagom: String = "yagom"
var greeting: String = hello + " " + yagom + "!"
print(greeting) // Hello yagom!
greeting = hello
greeting += " "
greeting += yagom
greeting += "!"
print(greeting) // Hello yagom!
// ----------------------------
// 연산자를 통한 문자열 비교
print(hello == "Hello") // true
// ----------------------------
print(hello == "hello") // false
// ----------------------------
print(yagom == "yagom") // true
// ----------------------------
print(yagom == hello) // false
// ----------------------------
// 메서드를 통한 접두어, 접미어 확인
print(hello.hasPrefix("He")) // true
// ----------------------------
print(hello.hasPrefix("HE")) // false
// ----------------------------
print(greeting.hasPrefix("Hello ")) // true
// ----------------------------
print(yagom.hasPrefix("gom")) // false
// ----------------------------
print(hello.hasPrefix("Hello")) // true
// ----------------------------
print(hello.hasSuffix("He")) // false
// ----------------------------
print(hello.hasSuffix("llo")) // true
// ----------------------------
print(hello.hasSuffix("He")) // false
// ----------------------------
print(greeting.hasSuffix("yagom")) // false
// ----------------------------
print(greeting.hasSuffix("yagom!")) // true
// ----------------------------
print(yagom.hasSuffix("gom")) // true
// ----------------------------
// 메서드를 통한 대소문자 변환
var convertedString: String = ""
convertedString = hello.uppercased()
print(convertedString) // HELLO
// ----------------------------
convertedString = hello.lowercased()
print(convertedString) // hello
// ----------------------------
convertedString = yagom.uppercased()
print(convertedString) // YAGOM
// ----------------------------
convertedString = greeting.uppercased()
print(convertedString) // HELLO YAGOM!
// ----------------------------
convertedString = greeting.lowercased()
print(convertedString) // hello yagom!
// ----------------------------
// 프로퍼티를 통한 빈 문자열 확인
print(greeting.isEmpty) // false
// ----------------------------
greeting = "안녕"
print(greeting.isEmpty) // false
// ----------------------------
greeting = ""
print(greeting.isEmpty) // true
// ----------------------------
// 프로퍼티를 이용해 문자열 길이 확인
print(greeting.count) // 0
// ----------------------------
greeting = "안녕하세요"
print(greeting.count) // 5
// ----------------------------
greeting = "안녕!"
print(greeting.count) // 3
// ----------------------------
// 코드상에서 여러 줄의 문자열을 직접 쓰고 싶다면 큰따옴표 세 개를 사용하면 됩니다.
// 큰따옴표 세 개를 써주고 한 줄을 내려써야 합니다.
// 마지막 줄도 큰따옴표 세 개는 한 줄 내려써야 합니다.
greeting = """
안녕하세요 저는 야곰입니다.
스위프트 잘하고 싶어요!
잘 부탁합니다!
"""
print(greeting)
// ------------------------------------------------
// Hello yagom!
// Hello yagom!
// true
// false
// true
// false
// true
// false
// true
// false
// true
// false
// true
// false
// false
// true
// true
// HELLO
// hello
// YAGOM
// HELLO YAGOM!
// hello yagom!
// false
// false
// true
// 0
// 5
// 3
// 안녕하세요 저는 야곰입니다.
// 스위프트 잘하고 싶어요!
// 잘 부탁합니다!
// ------------------------------------------------
