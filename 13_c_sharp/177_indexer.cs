using System;

// ------------------------------------------
// 독자 컬렉션클래스에 인덱서를 정의하면, 배열이나 List<T>와 같이 오브젝트에 
// 인덱스로 접근이 가능하다.
// - 인덱스는 정수일 필요가 없다. 문자열이나 다른 형도 가능.
// - get액세서로 값의 취득이 가능.
// - set액세서로 값 설정방법을 기술.
// 
// public 요소형 this[index형 index]
// {
//     get { ... }
//     set { ... }
// }
//

var books = new BookCollection();
books["978-4041099124"] = new Book("인간실격", "다자이 오사무", "978-4041099124");
books["978-4101010137"] = new Book("코코로", "나쓰메 소세키", "978-4101010137");

var book1 = books[0];
var book2 = books["978-4101010137"];

Console.WriteLine($"{book1.Title} {book1.Author} {book1.ISBN}");
Console.WriteLine($"{book2.Title} {book2.Author} {book2.ISBN}");

books["978-4101010137"].Author = "나츠메 소세끼";
Console.WriteLine($"{book2.Title} {book2.Author} {book2.ISBN}");

class BookCollection
{
    private List<Book> _books = new List<Book>();

    // 인덱서 정의. 읽기전용.
    public Book this[int index]=>_books.ElementAt(index);

    // 인덱서 정의. 쓰기가능.
    public Book this[string isbn]
    {
        get { return _books.First(x => x.ISBN == isbn); }
        set
        {
            var index = _books.FindIndex(x => x.ISBN == isbn);
            if (index < 0)
                _books.Add(value);
            else
                _books[index] = value;
        }
    }
}

class Book
{
    public Book(string title, string author, string isbn)   
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
}
// 인간실격 다자이 오사무 978-4041099124
// 코코로 나쓰메 소세키 978-4101010137
// 코코로 나츠메 소세끼 978-4101010137