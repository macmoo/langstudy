import Foundation

// ------------------------
// tuple
var greeting1 = ("Hello", "안녕")
var greeting2 : (String, String) = ("Hello", "안녕")
var guest     : (String, String, Int) = ("aa", "bb", 22)
let (name, _ , age) = guest
let user = name + " " + "\(age)"
print (user)
// ------------------------
var user2 = (name: "cc", point: 30)
user2.point += 5
print (user2)
print (user2.point)
// ------------------------
var point : (x:Double, y:Double, z:Double)
point = (4.2, 3.5, 6.1)
print(point)
// ------------------------
var value = (100, 200, 300)
print (value.1)
// ------------------------
// aa 22
// (name: "cc", point: 35)
// 35
// (x: 4.2, y: 3.5, z: 6.1)
// 200
// ------------------------
