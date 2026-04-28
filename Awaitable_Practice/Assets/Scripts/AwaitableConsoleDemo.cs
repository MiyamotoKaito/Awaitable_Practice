using System.Threading;
using UnityEngine;

public class AwaitableConsoleDemo : MonoBehaviour
{
    async void Start()
    {
        Debug.Log($"Step 0 : {nameof(this.Start)}");

        Debug.Log("Step 1 : Wating 3 second...");

        await Awaitable.WaitForSecondsAsync(3, CancellationToken.None);

        Debug.Log("Step 2 : Done!");
    }
}
