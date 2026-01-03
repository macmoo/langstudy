import Foundation

// ------------------------------
let numList = [4, 8, 15, 16, 23, 42]
var sum = 0
for num in numList {
    sum += num
}
print ("합계 : \(sum)")
// ------------------------------
// for x in 0 ... 360 * 2 {
for x in 0 ..< 360 * 2 {
    let radian = Double(x) * Double.pi / 180
    let y = sin(radian)
    print (x,y)
}
// ------------------------------
var stars = ""
for _ in 1 ... 5 {
    stars += "*"
    print (stars)
}
// ------------------------------
