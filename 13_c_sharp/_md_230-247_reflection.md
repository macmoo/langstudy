| #   | name                                          | -                                                    | biko               |
| --- | --------------------------------------------- | ---------------------------------------------------- | ------------------ |
| 230 | Object.GetType()                              | 오브젝트의 형정보를 취득                             |                    |
| 231 | Type.GetProperty()                            | 프로퍼티의 정보를 취득                               |                    |
| -   | PropertyInfo.GetValue()                       | 프로퍼티의 값을 취득                                 |                    |
| 232 | PropertyInfo.SetValue()                       | 프로퍼티의 값을 설정                                 |                    |
| 233 | Type.GetProperties()                          | 프로퍼티의 리스트를 취득                             | BindingFlags       |
| 234 | Type.GetMethod()                              | MethodInfo 인스턴스취득                              |                    |
| -   | MethodInfo.Invoke()                           | 메소드 호출                                          |                    |
| 235 | Type.GetMethods()                             | 메소드 리스트 취득                                   |                    |
| 236 | Type.GetConstructor()                         | ConstructorInfo 인스턴스취득                         |                    |
| -   | ConstructorInfo.Invoke()                      | 생성자 호출                                          | 생성자 동적 호출   |
| 237 | Type.GetConstructors()                        | Typed의 생성자 리스트 취득                           | 인스턴스 동적 생성 |
| 238 | MethodBase.GetCurrentMethod()                 | 현재 실행중의 메소드명 취득                          |                    |
| -   | Type DeclaringType                            | 현재 실행중인 메소드의 클래스명 취득                 |                    |
| 239 | Type.IsValueType                              | 값형인가                                             |                    |
| -   | Type.IsEnum                                   | 열거형인가                                           |                    |
| -   | Type.IsArray                                  | 배열인가                                             |                    |
| -   | Type.IsClass                                  | 클래스인가                                           |                    |
| -   | Type.IsGenericType                            | 제너릭형인가                                         |                    |
| -   | Type.GenericTypeArguments                     | 제너릭형의 인수를 조사                               |                    |
| 240 | CustomAttributeExtensions.IsDefined           | 인수로 지정한 속성이 프로퍼티에 부가되어 있는지 조사 |                    |
| 241 | CustomAttributeExtensions.GetCustomAttribute  | 프로퍼티에 부가되어 있는 속성의 값을 취득            |                    |
| 242 | CustomAttributeExtensions.GetCustomAttributes | 메소드에 부가되어 있는 속성의 값을 취득              |                    |
| 243 | Type.GetField                                 | FieldInfo 인스턴스취득                               |                    |
