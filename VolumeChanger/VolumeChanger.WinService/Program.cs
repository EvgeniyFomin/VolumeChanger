using System.ServiceProcess;

namespace VolumeChanger.WinService
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static void Main()
        {
            var servicesToRun = new ServiceBase[]
                                {
                                    new VolumeService()
                                };
            ServiceBase.Run(servicesToRun);
        }
    }
}
