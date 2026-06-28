using System;
using System.IO;

// IDisposable
// IDisposable인터페이스는 리소스를 해제하기 위한 메카니즘을 제공.
//
// 클래스에 정의된 필드의 형이 IDisposable인터페이스를 구현한 경우,
// 그 클래스도 IDisposable를 구현해, 필드가 가리키는 오브젝트를 안전하고 확실히 
// 파기할 필요가 있다.
//
// IDispos패턴

using (var obj = new DisposableType())
{
    // ここでobjを使った処理を記述
}


// IDisposableインターフェイスの実装例
// Stream클래스는 IDisposable인터페이스를 구현함.
public class DisposableType : IDisposable // *
{
    private bool _disposed;  // 破棄済みかどうかを示す
    private Stream _stream;

    public DisposableType()
    {
        _stream = new FileStream(@"example.txt", FileMode.Open);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
            return;
        if (disposing)
            _stream.Dispose();
        _disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    ~DisposableType() => Dispose(false);
}

// 以下、発展で示したコード
public class DelivedType : DisposableType
{
    bool _disposed = false;
    private Stream _stream;
    public DelivedType(string path)
    {
        _stream = File.Open(path, FileMode.Open);
    }

    ~DelivedType() => Dispose(false);

    // Disposeメソッドをオーバーライドする
    protected override void Dispose(bool disposing)
    {
        if (_disposed)
            return;
        if (disposing)
            _stream.Dispose();
        _disposed = true;
        base.Dispose(disposing);  // 基底クラスのリソースを破棄する
    }
}

