using System.Threading;
using UnityEngine;

public class AwaitableConsoleDemo : MonoBehaviour
{
    async void Start()
    {
        Debug.Log($"{nameof(this.Start)}メソッドを実行");

        Debug.Log("3秒待つ");

        await Awaitable.WaitForSecondsAsync(3, CancellationToken.None);

        Debug.Log("3秒待った");

        Debug.Log("次のフレームまで待つ");

        await Awaitable.NextFrameAsync(CancellationToken.None);

        Debug.Log("次のフレームまで待った");

        Debug.Log("フレームの最後まで待つ");

        await Awaitable.EndOfFrameAsync(CancellationToken.None);

        Debug.Log("次のフレームまで待った");
    }

    async Awaitable ThreadSwichDemo()
    {

    }

}
