using System;

// is연산자로 패턴매칭 //
var c = 'Q';
var letterOrSeparator =
    c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',';
Console.WriteLine(letterOrSeparator);

var pos = new { X = 1, Y = 5 };
var notnull = pos is not null;
Console.WriteLine(notnull);

// True
// True
