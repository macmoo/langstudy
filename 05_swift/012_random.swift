
print("-----------------------------------")
for _ in 1 ... 5 { // 5번 반복
    let num = Int.random(in: 1 ... 10) // 난수생성
    print(num)
}

print("-----------------------------------")
for _ in 1 ... 5 { // 5번 반복
    let num2 = Double.random(in: 0 ..< 1) // 0 포함, 1 미포함
    print(num2)
}

print("-----------------------------------")
for _ in 1 ... 5 { // 5번 반복
    print(Bool.random())
}

print("-----------------------------------")
let colors = ["green", "red", "blue", "pink", "orange"]
for _ in 1 ... 5 {
    let item = colors.randomElement()
    // item은 Optional()로 wrap된 Optional형의 값이라서
    // 값을 사용할 경우에는 Optional을 업랩해서 사용한다
    print(item!) // 강제언랩
}

print("-----------------------------------")
let letters = "ABCDEFGHIJKLMN"
for _ in 1 ... 5 {
    let item = letters.randomElement()
    print(item!)    
}

print("-----------------------------------")

