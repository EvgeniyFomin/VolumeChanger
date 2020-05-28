using PipesRx;
using System;
using System.IO.Pipes;
using System.Windows;


namespace VolumeControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void slValue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txtVolumeValue.Text = slValue.Value.ToString();
        }
     
        private void Apply_Click(object sender, RoutedEventArgs e)
        {
            txtVolumeValue.Text = "Apply button clicked";
            var client = new IpcClient<string>(".", "test", new ClientObserver()).Create();

            Console.ReadLine();
            client.Dispose();
            Console.WriteLine("Client1 disposed!");
        }
    }
    class ClientObserver : IPipeStreamObserver<string>
    {

        public void OnNext(string value)
        {
            Console.WriteLine(value);

            PipeStream.Write("Hello ");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine(error);
        }

        public void OnCompleted()
        {

        }

        public PipeStream PipeStream { get; set; }

        public void OnConnected()
        {
            PipeStream.Write("Hello ");
        }
    }
}
