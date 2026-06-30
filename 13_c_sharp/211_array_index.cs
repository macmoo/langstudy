using System;

// 배열의 인덱스
//
// ^n   : 뒤에서부터의 인덱스
// ^1   : 가장 마지막
// ^2   : 마지막에서 두번째
// n..m : 범위
//
var words = new[] { "If", "you", "can", "dream", "you", "can", "do", "it" };
string last = words[^1];            // "it"
string[] candream = words[2..4];    // { "can", "dreeam" }
string[] doit = words[^2..^0];      // { "do", "it" } // 뒤에서 세서 2~0의 범위
string[] first4 = words[..4];       // { "If", "you", "can", "dream" } // 선두~4의 범위
string[] from4 = words[4..];        // { "you", "can", "do", "it" }    // 4~마지막의 범위
Range range = 3..^2; // 3~마지막에서 2번째까지의 범위
string[] items = words[range];      // { "dream", "you", "can" }

Console.WriteLine(last);
Console.WriteLine(string.Join(",", candream));
Console.WriteLine(string.Join(",", doit));
Console.WriteLine(string.Join(",", first4));
Console.WriteLine(string.Join(",", from4));
Console.WriteLine(string.Join(",", items));
