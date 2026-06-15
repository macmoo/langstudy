using System;

// ------------------------------------------
var name1 = new[] { "Apple", "MS", "Google", "Oracle" };
var name2 = new[] { "MS", "Adobe", "Facebook", "Amazon" };

Console.WriteLine(string.Join(", ", name1));
Console.WriteLine(string.Join(", ", name2));
Console.WriteLine();
//
// Union : 합집합
// 
var query1 = name1.Union(name2).OrderBy(x => x);
Console.WriteLine(string.Join(", ", query1));
Console.WriteLine();
// 
// Intersect : 교집합
//
var query2 = name1.Intersect(name2).OrderBy(x => x);
Console.WriteLine(string.Join(", ", query2));
Console.WriteLine();
// 
// Except : 교집합
//
var query3 = name1.Except(name2).OrderBy(x => x);
Console.WriteLine(string.Join(", ", query3));
Console.WriteLine();
// ------------------------------------------
// Apple, MS, Google, Oracle
// MS, Adobe, Facebook, Amazon
// 
// Adobe, Amazon, Apple, Facebook, Google, MS, Oracle
// 
// MS
// 
// Apple, Google, Oracle