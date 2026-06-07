using System;

// ------------------------------------------
var names = new List<string> { "Apple", "Microsoft", "Google", "Oracle", "Facebook", "Adobe", "Amazon" };

var reversed = names.Reverse<string>();
// List<T>에 대해 Reverse()를 쓰면 List<T>에 정의된 Reverse()가 우선시 된다.
// 때문에 제너릭메소드형의 파라메타를 명시해서 Reverse()를 호출

Console.WriteLine(string.Join(", ", names));
Console.WriteLine(string.Join(", ", reversed));

// Apple, Microsoft, Google, Oracle, Facebook, Adobe, Amazon
// Amazon, Adobe, Facebook, Oracle, Google, Microsoft, Apple