using System;
using System.Text;
using System.Threading;


// 확장메소드
// static class 클래스명
// {
//     public static 형 메소드명(this 형 인수, ...) { }
// }
//
// 기존의 클래스, 구조체에 손대지 않고 새로운 메소드를 추가할 수 있다.
// 확장메소드를 정의하는 클래스는 반드시 정적 클래스로 할 필요가 있다.
// 당연히 확장메소드도 정적메소드.
//
//

// 확장메소드 이용
var name = "hello";
Console.WriteLine(name.ToTitleCase());
Console.WriteLine("world".ToTitleCase());
Console.WriteLine("ｗｏｒｌｄ".ToTitleCase());

var base64str = "C# Programming".ToBase64String();
Console.WriteLine(base64str);
var original = base64str.FromBase64String();
Console.WriteLine(original);

// 확장메소드 정의
// string클래스를 확장
static class StringExtensions
{
    public static string ToTitleCase(this string str)
    {
        var cultureInfo = Thread.CurrentThread.CurrentCulture;
        var textInfo = cultureInfo.TextInfo;
        return textInfo.ToTitleCase(str);
    }

    public static string ToBase64String(this string str, Encoding encoding = null)
    {
        var bytes = (encoding ?? Encoding.UTF32).GetBytes(str);
        return Convert.ToBase64String(bytes);
    }

    public static string FromBase64String(this string base64String, Encoding encoding = null)
    {
        var bytes = Convert.FromBase64String(base64String);
        return (encoding ?? Encoding.UTF32).GetString(bytes);
    }
}

// Hello
// World
// Ｗｏｒｌｄ
// QwAAACMAAAAgAAAAUAAAAHIAAABvAAAAZwAAAHIAAABhAAAAbQAAAG0AAABpAAAAbgAAAGcAAAA=
// C# Programming