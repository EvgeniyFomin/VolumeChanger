using System;
using System.IO.Pipes;

namespace PipesRx
{
    public interface IPipeStreamObserver<in T> : IObserver<T>
    {
        PipeStream PipeStream { get; set; }
        void OnConnected();
    }
}
