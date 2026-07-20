using System;
using System.Text.RegularExpressions;

{
    // 正規表現を使い文字列の置換処理を行う
    var text = "The quick onyx goblin jumps over the lazy dwarf.";
    // 5자의 단어를 '[', ']'로 감쌈.
    var result = Regex.Replace(text, @"(\b)(\w{5})(\b)", @"$1[$2]$3");
    Console.WriteLine(result);
}


// 以降は、発展で示したコード
{

    var text = "The quick onyx goblin jumps over the lazy dwarf.";
    // 단어의 선두글자를 대문자로 바꿈.
    var result2 = Regex.Replace(text, @"\b\w+\b",
                                (Match m) => m.Value.Length > 1
                                             ? Char.ToUpper(m.Value[0]) + m.Value[1..^0]
                                             : m.Value.ToUpper()
    );
    Console.WriteLine(result2);
}

// The [quick] onyx goblin [jumps] over the lazy [dwarf].
// The Quick Onyx Goblin Jumps Over The Lazy Dwarf.
