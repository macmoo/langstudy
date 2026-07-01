using System;
using System.ComponentModel;

// System.ComponentModel이름공간의 BackgroundWorker클래스를 사용하면,
// 간단히 백그라운드에서 처리를 실행할 수 있다.
// 
// BackgroundWorker클래스의 RunWorkerAsync()를 호출하면, 
// 백그라운드 처리가 시작되어, 처리가 진행될때마다 ProgressChanged이벤트가 발생한다.
// 처리가 종료되면, RunWorkerCompleted이벤트가 발생한다.
//
// DoWork가 백그라운드에서 실행되는 메소드. b를 출력.
// Main()에서는 백그라운드의 처리가 종료되거나, 아무 키가 입력될 때 까지 F를 출력.
//
// 아무 키가 눌리면, BackgroundWorker.CancelAsync()를 호출해 처리를 취소한다.
// 한편, DoWork()에서는 BackgroundWorker.CancellationPending프로퍼티를 참조해서,
// 처리가 취소되었나늘 확인해서 true이면 처리를 중단함.
//
class Program
{
    static void Main()
    {
        var bw = new BackgroundWorker();
        bw.WorkerSupportsCancellation = true;
        bw.WorkerReportsProgress = true;
        bw.DoWork += DoWork;
        bw.ProgressChanged += ProgressChanged;
        bw.RunWorkerCompleted += WorkerCompleted;
        bw.RunWorkerAsync();
        while (bw.IsBusy)
        {
            if (Console.KeyAvailable)
            {
                bw.CancelAsync();
                break;
            }
            Console.Write("F");
            System.Threading.Thread.Sleep(600);
        }
        System.Threading.Thread.Sleep(500);
        Console.WriteLine("end");              
    }
    private static void DoWork(object sender, DoWorkEventArgs e)
    {
        var bw = sender as BackgroundWorker;
        for (int i = 1; i <= 20; i++)
        {
            if (bw.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            System.Threading.Thread.Sleep(350);
            // ProgressChanged이벤트를 발생시킴.
            bw.ReportProgress(i, null);
        }

    }
    private static void WorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
        if (e.Cancelled)
            Console.WriteLine("\nCanceled");
        else
            Console.WriteLine("\nCompleted");
    }
    private static void ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
        Console.Write("b");
    }
}

// FbFbbFbbFbFbbFbFbbFbbFbFbbFbbFbFb
// Completed
// end
// --------------
// FbFbbb
// Canceled
// end


