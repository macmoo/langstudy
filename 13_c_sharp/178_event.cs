using System;
using System.Data.SqlClient;

// ------------------------------------------
// 독자 이벤트를 정의할 때는, 
// 이벤트를 발생시키는 클래스와 
// 이벤트를 받아들이는 클래스가 필요하다.
// 
// 이벤트를 발생시키는 클래스는 필요에 따라서 이벤트 정보를 보관할
// 커스텀EventArgs클래스도 정의한다.
// 이벤트를 발생시키는 클래스는 다음 3개를 구현한다.
// 1. event 키워드를 사용한 이벤트
// 2. 이벤트를 발생할 On으로 시작하는 private메소드
// 3. 특정 사상이 발생했을 때, 위의 2개를 호출할 코드.
// 
// 
// 
// 

// 이벤트 이용
var obj = new EventSample();
obj.Changed += OnChangedHandler;
obj.Add(1);
obj.Add(4);
obj.Add(6);
obj.Add(7);
obj.Add(2);

// 이벤트 핸들러
static void OnChangedHandler(Object sender, SampleEventArgs e)
{
    Console.WriteLine($"Total = {e.Total}");
}

// 이벤트 정의
class EventSample
{
    // 이벤트를 정의. EventHandler<TEventArgs>형을 이용.
    public event EventHandler<SampleEventArgs> Changed;

    // 이벤트핸드러를 호출할 내부메소드
    private void OnChanged(SampleEventArgs e)
    {
        // Invoke메소드롤 이벤트핸들러를 호출.
        Changed?.Invoke(this, e);
    }

    private int _total = 0;
    public void Add(int n)
    {
        _total += 5;
        if (_total % 5 == 0)
        {
            // 5로 나누어 떨어지면 이벤트 발생.
            var args = new SampleEventArgs { Total = _total };
            OnChanged(args);
        }
    }
}

// 이벤트핸들러가 받는 파라메터의 형을 정의
class SampleEventArgs : EventArgs
{
    public int Total { get; set; }
}


// Total = 5
// Total = 10
// Total = 15
// Total = 20
// Total = 25
