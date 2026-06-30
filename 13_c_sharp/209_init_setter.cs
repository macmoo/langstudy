using System;

// init 전용세터를 사용하면, 프로퍼티의 초기화를
// 오브젝트초기화에서의 초기화로 한정할 수 있다.
// 초기화후에는 읽기전용이 된다.

// オブジェクト初期化子での初期化はOK
var book = new Book
{
    Title = "겐지이야기",
    Author = "시키부"
};

// 以下のコードはエラー
// book.Author = "清少納言";

public class Book
{
    public string Title { get; init; }
    public string Author { get; init; }
}
