using System;

// 文字列で与えたプロパティに値をセットする
var book = new Book();
SetPropertyValue(book, "Title", "吾輩は猫である");
Console.WriteLine(book.Title);
SetPropertyValue(book, "Author", "夏目漱石");
Console.WriteLine(book.Author);

// objのnameプロパティに値(value)を設定する
static void SetPropertyValue(object obj, string name, object value)
{
    var type = obj.GetType();
    var propertyInfo = type.GetProperty(name);
    propertyInfo.SetValue(obj, value);
}

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
}

// 吾輩は猫である
// 夏目漱石