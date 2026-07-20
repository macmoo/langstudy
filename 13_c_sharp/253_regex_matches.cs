using System;
using System.Text.RegularExpressions;

// 正規表現を使い大文字小文字を区別せずマッチさせる 

var text = @"The quick onyx goblin jumps over the lazy dwarf.";
var ms = Regex.Matches(text, @"\bthe\b", RegexOptions.IgnoreCase);
foreach (Match m in ms)
{
    Console.WriteLine($"{m.Value} : {m.Index}");
}

// The: 0
// the: 33