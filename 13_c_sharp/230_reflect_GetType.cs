
// public Type GetType()
//
// 프로그램 실행시에 지정한 오브젝트의 형정보를 취득할 수 있다.
// 
// 리플렉션은 형체크, 시큐리티체크등 다양한 처리가 일어나기 때문에,
// 실행 속도가 빠르지 않다.
// 실행 속도가 요구되는 상황에서는 빈번히 부르지 않는것이 좋다.

using System;

var objects = new object[]
{
    10,
    1.5,
    100M,
    DateTime.Now,
    "Hello",
    new System.ArgumentException(),
};
foreach (var obj in objects)
{
    // オブジェクトの型情報を得る得る
    var type = obj.GetType();
    Console.WriteLine($"{type.Namespace}, {type.Name}, {type.FullName}");
}

// System, Int32, System.Int32
// System, Double, System.Double
// System, Decimal, System.Decimal
// System, DateTime, System.DateTime
// System, String, System.String
// System, ArgumentException, System.ArgumentException