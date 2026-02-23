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
var 변수명 = 값
var 변수명 : 형
var 변수명 : 형 = 초기ㅣ값

// 상수
let 변수명 = 초기값
let 변수명 : 형
```

```swift
let time = 9.95
let result = "시간은 \(time)초."
```

### access권
| access권      | 설명 |
| -            | -|
| open         | 모듈외에서도 자유롭게 액세스가능 |
| public       | 모듈외에서도 액세스가능하나, 계승이나 override는 불가능 |
| internal     | 동일 모듈안이라면 다른 파일에서도 액세스가능(디폴트) |
| fileprivate  | 동일 파일안에서만 액세스가능 |
| private      | 정의된 스코프안에서만 액세스가능 |

구조체명의 첫글자는 대문자

```swift

```
```swift

```
```swift

```
```swift

```
```swift

```
```swift

```
```swift

```
```swift

```
```swift

```
```swift

```
```swift

```
```swift
defaults write -g KeyRepeat -int 1 
defaults write -g InitialKeyRepeat -int 10

defaults write -g KeyRepeat -int 6
defaults write -g InitialKeyRepeat -int 68

KeyRepeat = 6
InitialKeyRepeat = 68

```

```swift 
// [튜플]
// - 지정된 데이터 묶음
// - 개수
// ----------------
// String, Int, Double 타입을 갖는 튜플
var person: (String, Int, Double) = ("yagom", 100, 182.5)
print("이름: \(person.0), 나이: \(person.1), 신장: \(person.2)")

person.1 = 99 person.2 = 178.5
print("이름: \(person.0), 나이: \(person.1), 신장: \(person.2)")

var person: (name: String, age: Int, height: Double) = ("yagom", 100, 182.5)
print("이름: \(person.name), 나이: \(person.age), 신장: \(person.height)")
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
var emptyArray: [Any] = Array<Any>() // 위 선언과 정확히 같은 동작을 하는 코드입니다.
// 배열의 타입을 정확히 명시해줬다면 []만으로도 빈 배열을 생성할 수 있습니다.
var emptyArray: [Any] = []
print(emptyArray.isEmpty) // true
print(names.count) // 4
```


```swift  ```
xcrun swift -version


xcode-select: error: tool 'xcodebuild' requires Xcode, but active developer directory '/Library/Developer/CommandLineTools' is a command line tools instance
sudo xcode-select -s /Applications/Xcode.app/Contents/Developer
->
swift update
https://www.swift.org/install/macos/


vscode 
https://zenn.dev/aromarious/articles/sweetpad-extension-introduction

```swift  ```

```swift  ```

```swift  ```

```swift  ```
```swift  ```
