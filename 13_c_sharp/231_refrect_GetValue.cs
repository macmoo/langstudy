
// PropertyInfo.GetValue()

using System;

var book = new Book
{
    Title = "吾輩は猫である",
    Author = "夏目漱石"
};
var title = GetPropertyValue(book, "Title");
Console.WriteLine(title);
var author = GetPropertyValue(book, "Author");
Console.WriteLine(author);

// objのnameプロパティの値を取得する
static object GetPropertyValue(object obj, string name)
{
    var type = obj.GetType(); // 1
    var propertyInfo = type.GetProperty(name); // 2
    return propertyInfo.GetValue(obj); // 3
}

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
}

// 吾輩は猫である
// 夏目漱石
