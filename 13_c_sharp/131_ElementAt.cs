using System;

// ------------------------------------------
// 지정한 위치의 요소를 취득.

var names = new[] { "Apple", "Microsoft", "Google", "Oracle", "Facebook", "Adobe", "Amazon" };

var name1 = names.OrderBy(n => n.Length);
var name2 = names.OrderBy(n => n.Length).ElementAt(1);

Console.WriteLine(string.Join(", ", name1));
Console.WriteLine(string.Join(", ", name2));

// Apple, Adobe, Google, Oracle, Amazon, Facebook, Microsoft
// Adobe