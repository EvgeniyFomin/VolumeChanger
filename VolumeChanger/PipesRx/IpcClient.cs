using System;
using System.IO.Pipes;
using System.Threading;

namespace PipesRx
{
    public class IpcClient<T>
    {
        public IPipeStreamObserver<T> Observer { get; set; }
        private readonly AutoResetEvent _auto = new AutoResetEvent(false);
        private readonly string _server;
        private readonly string _name;


        public IpcClient(string server, string name, IPipeStreamObserver<T> observer)
        {
            Observer = observer;
            _server = server;
            _name = name;
        }

        public IDisposable Create()
        {

            NamedPipeClientStream pipe;
            var observable = PipeStreamObservable.Create<T>(out pipe, _server, _name, (sender, args) => _auto.Set());
            Observer.PipeStream = pipe;
            observable.Subscribe(
                                Observer.OnNext,
                                ex =>
                                {
                                    Observer.OnError(ex);
                                    pipe.Close();
                                    _auto.Set();
                                },
                                () =>
                                {
                                    Observer.OnCompleted();
                                    pipe.Close();
                                });
            _auto.WaitOne();
            if (pipe.IsConnected)
                Observer.OnConnected();
            return pipe;
        }
    }
   
}
