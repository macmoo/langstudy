using System;
using System.Text.RegularExpressions;
using System.Linq;

var text = "Regex.GroupNumberFromName(String)";
var items = Regex.Split(text, @"([A-Z]+[a-z0-9]*)|\W");
// 次のWhereメソッドでから文字列を取り除いている。
// 「I01 条件に該当する要素だけ取得したい(Where)」を参照
foreach (var s in items.Where(x => x != ""))
{
    Console.WriteLine(s);
}


// Regex
// Group
// Number
// From
// Name
// String
