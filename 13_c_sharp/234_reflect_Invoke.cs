
// 리플렉션으로 메소드 호출
//
// public object Invoke(object obj, object[] parameters);
// - 인수1 : 호출할 대상 오브젝트
// - 인수2 : 멘소드의 인수를 오브젝트의 배열로 넘김.
using System;

var date = new DateTime(2020, 12, 1);

var type = date.GetType();
var methodInfo = type.GetMethod("AddDays");
var result = methodInfo.Invoke(date, new object[] { 3 });
Console.WriteLine(result);

// 2020-12-04 오전 12:00:00