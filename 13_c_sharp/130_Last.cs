using System;

// ------------------------------------------
var names = new[] { "Apple", "Microsoft", "Google", "Oracle", "Facebook", "Adobe", "Amazon" };

var name1 = names.Last();
var name2 = names.LastOrDefault();
var name3 = names.Last(n => n.Length >= 8);
var name4 = names.LastOrDefault(n=>n.Length> 10);

Console.WriteLine(name1);
Console.WriteLine(name2 ?? "<Not Found>");
Console.WriteLine(name3);
Console.WriteLine(name4 ?? "<Not Found>");

// Amazon
// Amazon
// Facebook
// <Not Found>