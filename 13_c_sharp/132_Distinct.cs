using System;

// ------------------------------------------
// Dictinct메소드는 시퀀스에서 중복요소를 제거한다.

var names = new[] { "Apple", "Microsoft", "Microsoft", "Google", "Google", "Oracle", "Facebook", "Adobe", "Amazon" };

var query = names.Distinct().OrderBy(x => x);
// OrderBy()->Distinct()순서로 쓰면 정렬순이 달라질수 있다.
Console.WriteLine(string.Join(", ", names)); 
Console.WriteLine(string.Join(", ", query));

// Apple, Microsoft, Microsoft, Google, Google, Oracle, Facebook, Adobe, Amazon
// Adobe, Amazon, Apple, Facebook, Google, Microsoft, Oracle
