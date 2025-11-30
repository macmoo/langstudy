import Foundation

// ------------------------------
//var 변수명 : 형 {
//    식
//    return 값
//}
var num : Int {
    let result = 2 * 5
    return result
}
print (num)
// ------------------------------
// 식이 한줄이면 return 생략가능
var num2 : Int {
    2  * 5
}
print (num2)
// ------------------------------
//  Computed 프로퍼티
//var 변수명 : 형 {
//    get { // get문만이라면 get{}는 생략가능
//        식
//        return 값
//    }
//}
var num3 : Int {
    get{
        return 2 * 5
    }
}
print (num3)
//num3 = 22 // error
//print (num3)
// ------------------------------
//var 변수명 : 형 {
//    get {
//        식
//        return 값
//    }
//    set (인수){
//        식
//    }
//}
var radius = 10.0
var diameter : Double {
    get {
        radius * 2
    }
    set (length) {
        radius = length / 2
    }
}
var around : Double{
    get{
        let length = 2 * radius * Double.pi
        return length
    }
    set(length){
        radius = length / (2 * Double.pi)
    }
}

print ("반경이 \(radius)일때, 직경은 \(diameter)이다.")
radius = 30
print ("직경이 \(diameter)일때, 반경은 \(radius)이다.")
around = 100
print ("원주가 \(around)일때, 반경은 \(radius)이다.")
// ------------------------------
//10
//10
//10
//반경이 10.0일때, 직경은 20.0이다.
//직경이 60.0일때, 반경은 30.0이다.
//원주가 100.0일때, 반경은 15.915494309189533이다.
