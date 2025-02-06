
>  Any는 스위프트의 모든 데이터 타입을 사용할 수 있다는 뜻입니다. 변수 또는 상수의 데이터
타입이 Any로 지정되어 있다면 그 변수 또는 상수에는 어떤 종류의 데이터 타입이든지 상관없
이 할당할 수 있습니다.
AnyObject는 Any보다는 조금 한정된 의미로 클래스의 인스턴스만 할당할 수 있습니다.
ny와 AnyObject는 될 수 있으면 사용하지 않는 편이 좋습니다. 타입에 엄격한 스위프트의 특성
상 Any 또는 AnyObject로 선언된 변수의 값을 가져다 쓰려면 매번 타입 확인 및 변환을 해줘야 하는 불편
함이 있을뿐더러 예기치 못한 오류의 위험을 증가시키기 때문입니다. 앞서 타입 추론 때도 설명했지만, 타입
은 될 수 있는 한 명시하는 것이 좋습니다.


```swift  
typealias MyInt = Int
typealias YourInt = Int
typealias MyDouble = Double
let age: MyInt = 100 
var year: YourInt = 2080
// MyInt는 Int의 또 다른 이름입니다.
// YourInt도 Int의 또 다른 이름입니다.
// MyInt도, YourInt도 Int이기 때문에 같은 타입으로 취급합니다.
year = age
90 1부 - 스위프트 기초
let month: Int = 7
let percentage: MyDouble = 99.9 // 물론 기존의 Int도 사용 가능합니다.
// Int 외에 다른 자료형도 모두 별칭 사용이 가능합니다.
```

```swift  ```
```swift  ```






