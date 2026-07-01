using System.Text.RegularExpressions;

// 비동기메소드를 동기처리하듯이 기술하기 위한 연산자가 await 연산자다.
// await연산자는 async키워드로 수식된 메소드 안에서만 사용가능하다.
// 메소드의 반환값도 통상의 메소드와 같이 받는게 가능하다.

class Program
{
    static async Task Main()
    {
        // 비동기 메소드 호출
        await DownloadPageAsync("https://docs.microsoft.com/ko-kr/");
    }

    private static HttpClient _client = new HttpClient();

    // 비동기 메소드
    static async Task DownloadPageAsync(string url)
    {
        var text = await _client.GetStringAsync(url);
        var m = Regex.Match(text, @"<title>([^<]+)</title>");
        Console.WriteLine(m.Groups[1]);
    }
}