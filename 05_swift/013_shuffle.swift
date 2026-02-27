
// shuffle()  : 대상 컬렉션의 요소의 순서를 바꿈
// shuffled() : 요소를 셔플한 후 새로운 컬렉션을 만들어 반환

var names = ["미츠키", "마미코", "마리코", "코호", "사토미", "유미"]
print(names) 
names.shuffle()
print(names) 

print("-----------------------------------")

let word = "SwiftUI"
let anagram = word.shuffled()
print ("word    : \(word)")
print ("anagram : \(anagram)")

print("-----------------------------------")
// range에 대해 shuffle()은 사용할 수 없다.
var aRange = 1 ... 10
let shuffledRange = aRange.shuffled()
print(shuffledRange)