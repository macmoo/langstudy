using System;
using System.Dynamic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;

// ------------------------------------------
var s1 = "";
var s2 = " ";

if (string.IsNullOrEmpty(s1)) Console.WriteLine("s1-1 null or empty");
if (string.IsNullOrEmpty(s2)) Console.WriteLine("s2-2 null or empty");
if (string.IsNullOrWhiteSpace(s1)) Console.WriteLine("s1-3 null or empty");
if (string.IsNullOrWhiteSpace(s2)) Console.WriteLine("s2-4 null or empty");
Console.WriteLine();
// ------------------------------------------
var quote = "Peace begins with a smile.";
var word = "smile";
var contains = quote.Contains(word);
Console.WriteLine(contains);
Console.WriteLine();
// ------------------------------------------
var s = "hello world";
Console.WriteLine(s);
if (s.StartsWith("hello")) Console.WriteLine(" starts with hello");
if (s.EndsWith("world")) Console.WriteLine(" end with world");
Console.WriteLine();
// ------------------------------------------
var s3 = "The quick brown fox jumps over a lazy dog.";
var s4 = "The quick onyx goblin jumps over the lazy dwarf.";
Console.WriteLine(s3);
Console.WriteLine(s4);
if (string.Compare(s3, 0, s4, 0, 10) == 0)
    Console.WriteLine("선두 10문자까지 일치.");
Console.WriteLine();
// ------------------------------------------
var s5 = "Hello World.";
var s6 = "HELLO WORLD.";

Console.WriteLine(s5);
Console.WriteLine(s6);
if (s5.Equals(s6, StringComparison.OrdinalIgnoreCase))
    Console.WriteLine("일치");
Console.WriteLine();
// ------------------------------------------
var word1 = " brown  ";
var trim1 = word1.Trim();
var trim2 = word1.TrimStart();
var trim3 = word1.TrimEnd();

Console.WriteLine($"[{trim1}]");
Console.WriteLine($"[{trim2}]");
Console.WriteLine($"[{trim3}]");
Console.WriteLine();
// ------------------------------------------
var s7 = "안녕하세요. 좋은 날씨네요.";
var s8 = "좋은 날씨";
var index = s7.IndexOf(s8);
Console.WriteLine(s7);
Console.WriteLine(s8);
Console.WriteLine(index);
Console.WriteLine();
// ------------------------------------------
var s9 = "DOM: Document Object Model";
var index2 = s9.IndexOf(": ");
var left = s9.Substring(0, index2);
var right = s9.Substring(index2 + 2);
Console.WriteLine(s9);
Console.WriteLine(index2);
Console.WriteLine(left);
Console.WriteLine(right);
Console.WriteLine($"{left} - {right}");
Console.WriteLine();
// ------------------------------------------
var text1 = "안녕하세요. 좋은 날씨네요.";
var newtext = text1.Remove(6, 3);
Console.WriteLine("0 1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 ");
Console.WriteLine(text1);
Console.WriteLine(newtext);
Console.WriteLine();
// ------------------------------------------
var text2 = "안녕하세요. 좋은 날씨네요.";
var newtext2 = text2.Replace("좋은 날씨", "따뜻한 날씨");
Console.WriteLine(text2);
Console.WriteLine(newtext2);
Console.WriteLine();
// ------------------------------------------
var text3 = "안녕하세요. 좋은 날씨네요.";
var newtext3 = text3.Insert(7, "오늘은 ");
Console.WriteLine(text3);
Console.WriteLine(newtext3);
Console.WriteLine();
// ------------------------------------------
var text4 = "Microsoft Windows";
var uppper1 = text4.ToUpper();
var lower1 = text4.ToLower();
Console.WriteLine(text4);
Console.WriteLine(uppper1);
Console.WriteLine(lower1);
Console.WriteLine();
// ------------------------------------------
var text5 = "Hello world!";
foreach (var ch in text5)
{
    Console.Write($"{ch}_");
}
Console.WriteLine();
// ------------------------------------------
var text6 = "12345";
var text7 = text6.PadLeft(5 + text6.Length);
Console.WriteLine("<0123456789>");
Console.WriteLine($"<{text7}>");
Console.WriteLine();
// ------------------------------------------
// StringSplitOptions.RemoveEmptyEntries -> 빈요소 제외
var text8 = "Truth is stranger than fiction.";
var array8 = text8.Split(new[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
foreach (var item in array8)
    Console.WriteLine($"[{item}]");
Console.WriteLine();
// ------------------------------------------
var sb9 = new StringBuilder();
//var sb9 = new StringBuilder(2000); // 초기사이즈 지정
string[] strs9 = {
    "aa bb",
    "cc dd",
    "ee ff",
    "gg hh"
};

foreach (var tmp in strs9)
    sb9.AppendLine(tmp); // "+" 보다 빠르다.

var text9 = sb9.ToString();
Console.WriteLine(text9);
Console.WriteLine();
// ------------------------------------------
var text10 = "The quick brown fox jumps over a lazy dog.";
var sb10 = new StringBuilder(text10);
sb10.Replace("fox", "hare");
sb10.Replace("dog", "turtle");
sb10.Replace("brown", "white");
var text11 = sb10.ToString();
Console.WriteLine(text10);
Console.WriteLine(text11);
Console.WriteLine();
// ------------------------------------------
var dirname = "chap_1";
var path = $@"C:\Temp\{dirname}";
var path2 = $"C:\\Temp\\{dirname}";
Console.WriteLine(path);
Console.WriteLine(path2);
Console.WriteLine();
// ------------------------------------------
//public static string Join<T>(char separator, IEnumerable<T> values);
var nums11 = new int[] { 123, 456, 789 };
var s11 = string.Join('-', nums11);
var s12 = string.Join(',', nums11);
Console.WriteLine(s11);
Console.WriteLine(s12);
Console.WriteLine();
// ------------------------------------------
// public static TSource[] ToArray<TSource>(this IEnumerable<TSource> source);
var text12 = "안녕하세요. 오늘은 춥네요.";
// 문자열을 배열로 변환.
char[] array12 = text12.ToArray();
Console.WriteLine(text12);
Console.WriteLine(array12);
Console.WriteLine(string.Join("_", array12));
// 문자배열을 문자열로 변환.
var newstr12 = new String(array12);
Console.WriteLine(newstr12);
Console.WriteLine();
// ------------------------------------------
var text13 = "abcde";
// 문자열을 byte배열로 변환
var bytes13 = Encoding.Unicode.GetBytes(text13);
foreach (var b in bytes13)
    Console.Write("{0:x2} ", b);
Console.WriteLine();

// byte배열을 문자열로 변환
var str13 = Encoding.Unicode.GetString(bytes13);
Console.WriteLine(str13);
Console.WriteLine();
// ------------------------------------------
// Compare의 반환값은 인수1,인수2의 순서의 대소를 나타냄
// 0 이면 같은 순서
// 음수이면 인수1가 앞
// 양수이면 인수2가 뒤
var str14 = "Ｗｉｎｄｏｗｓ";
var str15 = "Windows";

Console.WriteLine(str14);
Console.WriteLine(str15);
Console.WriteLine("----------");
Console.WriteLine(str14 == str15);
Console.WriteLine(str14.Equals(str15));
Console.WriteLine(string.Compare(str14, str15));
Console.WriteLine(string.Compare(str14, str15, StringComparison.Ordinal));
Console.WriteLine("----------");
Console.WriteLine(str14.StartsWith("Win"));
Console.WriteLine(str15.StartsWith("Win"));
Console.WriteLine("----------");
Console.WriteLine(str14.StartsWith("Win", StringComparison.Ordinal));
Console.WriteLine(str15.StartsWith("Win", StringComparison.Ordinal));
Console.WriteLine("----------");
Console.WriteLine(str14.StartsWith("WIN", StringComparison.OrdinalIgnoreCase));
Console.WriteLine(str15.StartsWith("WIN", StringComparison.OrdinalIgnoreCase));
Console.WriteLine();
// ------------------------------------------
//s1 - 1 null or empty
//s1 - 3 null or empty
//s2-4 null or empty

//True

//hello world
// starts with hello
// end with world

//The quick brown fox jumps over a lazy dog.
//The quick onyx goblin jumps over the lazy dwarf.
//선두 10문자까지 일치.

//Hello World.
//HELLO WORLD.
//일치

//[brown]
//[brown]
//[brown]

//안녕하세요.좋은 날씨네요.
//좋은 날씨
//7

//DOM: Document Object Model
//3
//DOM
//Document Object Model
//DOM - Document Object Model

//0 1 2 3 4 5 6 7 8 9 0 1 2 3 4 5
//안녕하세요. 좋은 날씨네요.
//안녕하세요. 날씨네요.

//안녕하세요. 좋은 날씨네요.
//안녕하세요. 따뜻한 날씨네요.

//안녕하세요. 좋은 날씨네요.
//안녕하세요. 오늘은 좋은 날씨네요.

//Microsoft Windows
//MICROSOFT WINDOWS
//microsoft windows

//H_e_l_l_o_ _w_o_r_l_d_!_
//<0123456789>
//<     12345>

//[Truth]
//[is]
//[stranger]
//[than]
//[fiction]

//aa bb
//cc dd
//ee ff
//gg hh


//The quick brown fox jumps over a lazy dog.
//The quick white hare jumps over a lazy turtle.

//C:\Temp\chap_1
//C:\Temp\chap_1

//123-456-789
//123,456,789

//안녕하세요. 오늘은 춥네요.
//안녕하세요. 오늘은 춥네요.
//안_녕_하_세_요_._ _오_늘_은_ _춥_네_요_.
//안녕하세요. 오늘은 춥네요.

//61 00 62 00 63 00 64 00 65 00
//abcde

//Ｗｉｎｄｏｗｓ
//Windows
//----------
//False
//False
//1
//65248
//----------
//False
//True
//----------
//False
//True
//----------
//False
//True