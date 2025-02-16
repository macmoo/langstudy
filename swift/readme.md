```swift
순수하게 함수형 프로그래밍 패러다임으로 프로그램을 작성하면 다음 장점이 있습니다.
● 여러 가지 연산 처리 작업이 동시에 일어나는 프로그램을 만들기 쉽습니다.
● 멀티 코어 혹은 여러 개 연산 프로세서를 사용하는 시스템에서 효율적인 프로그램을 만들기 쉽습니다.
● 상태변화에 따른 부작용에서 자유로워지므로 순수하게 기능 구현에 초점을 맞추어 설계할 수 있습니다.
```

```swift
Any는 스위프트의 모든 데이터 타입을 사용할 수 있다는 뜻입니다. 변수 또는 상수의 데이터
타입이 Any로 지정되어 있다면 그 변수 또는 상수에는 어떤 종류의 데이터 타입이든지 상관없
이 할당할 수 있습니다.
AnyObject는 Any보다는 조금 한정된 의미로 클래스의 인스턴스만 할당할 수 있습니다.
ny와 AnyObject는 될 수 있으면 사용하지 않는 편이 좋습니다. 타입에 엄격한 스위프트의 특성
상 Any 또는 AnyObject로 선언된 변수의 값을 가져다 쓰려면 매번 타입 확인 및 변환을 해줘야 하는 불편
함이 있을뿐더러 예기치 못한 오류의 위험을 증가시키기 때문입니다. 앞서 타입 추론 때도 설명했지만, 타입
은 될 수 있는 한 명시하는 것이 좋습니다.
```

```swift
// - constant
let name: String = "yagom"           // 차후 변경하지 않는 값은 상수로 선언합니다.
var age:  Int    = 100
var job          = "iOS Programmer" // 타입 추론이 사용되었습니다.
let height       = 181.5            // 실수 타입은 타입 추론으로 어떤 타입이 지정되는지 확인해보세요.
age  = 99          // 변수는 값을 변경할 수 있습니다.
job  = "Writer"    // 값을 변경할 때는 기존과 동일한 타입의 값을 할당해야 합니다.
name = "야곰"       // 상수로 선언된 값은 변경할 수 없습니다. 오류가 발생합니다.
print("저의 이름은 \(name)이고, 나이는 \(age)세이며, 직업은 \(job)입니다. 비밀이지만, 키는
\(height)센티미터입니다.")
```

```swift
// [string]
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
```

```swift
// [alias]
typealias MyInt    = Int
typealias YourInt  = Int
typealias MyDouble = Double
let age: MyInt     = 100 
var year: YourInt  = 2080
// MyInt는 Int의 또 다른 이름입니다.
// YourInt도 Int의 또 다른 이름입니다.
// MyInt도, YourInt도 Int이기 때문에 같은 타입으로 취급합니다.
year = age
let month: Int = 7
let percentage: MyDouble = 99.9 // 물론 기존의 Int도 사용 가능합니다.
// Int 외에 다른 자료형도 모두 별칭 사용이 가능합니다.
```

```swift 
// [튜플]
// - 지정된 데이터 묶음
// - 개수
// ----------------
// String, Int, Double 타입을 갖는 튜플
var person: (String, Int, Double) = ("yagom", 100, 182.5)
// var person: (name: String, age: Int, height: Double) = ("yagom", 100, 182.5)

// 인덱스를 통해서 값을 빼 올 수 있습니다.
print("이름: \(person.0), 나이: \(person.1), 신장: \(person.2)")
// print("이름: \(person.name), 나이: \(person.age), 신장: \(person.height)")

person.1 = 99 person.2 = 178.5
// 인덱스를 통해 값을 할당할 수 있습니다.
print("이름: \(person.0), 나이: \(person.1), 신장: \(person.2)")
```

```swift
// [배열]
// 필요에 따라 자동으로 크리를 조정
// 요소의 삽입과 삭제가 자유
// 대괄호를 사용하여 배열임을 표현합니다. ①
var names: Array<String> = ["yagom", "chulsoo", "younghee", "yagom"]
// 위 선언과 정확히 동일한 표현입니다. [String]은 Array<String>의 축약 표현입니다.
var names: [String]   = ["yagom", "chulsoo", "younghee", "yagom"]
var emptyArray: [Any] = [Any]() // Any 데이터를 요소로 갖는 빈 배열을 생성합니다.
var emptyArray:ƒ [Any] = Array<Any>() // 위 선언과 정확히 같은 동작을 하는 코드입니다.
// 배열의 타입을 정확히 명시해줬다면 []만으로도 빈 배열을 생성할 수 있습니다.
var emptyArray: [Any] = []
print(emptyArray.isEmpty) // true
print(names.count) // 4
```

```swift  ```

```swift  ```

```swift  ```

```swift  ```

```swift  ```

```swift  ```

```swift  ```

```swift  ```






