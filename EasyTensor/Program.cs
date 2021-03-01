using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace EasyTensor
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = RegisterServices();
            Application.Run(services.GetRequiredService<MainForm>());
            ((IDisposable)services).Dispose();
        }

        static IServiceProvider RegisterServices()
        {
            var serviceCollection = new ServiceCollection()
                .AddSingleton<MainForm>()
                .AddSingleton<ILayerControlFactory, LayerControlFactory>();
            return serviceCollection.BuildServiceProvider(false);
        }
    }
}
