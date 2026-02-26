import Foundation

struct Robbot{
    var num = 0
    // 구조체 자신(self)의 프로퍼티(변수)를 변경하기 위해서는
    // swiftui의 경우에는 프로퍼티의 선언에 @State를 붙이면 되지만
    // swiftui를 사용하지 않는 경우에는
    // 프로퍼티를 변경하는 함수정의 앞에 mutating를 붙인다.
    mutating func update(){
        num = Int.random(in: 0 ... 100)
    }
}

var roboSora = Robbot()
roboSora.update()
print(roboSora.num)
