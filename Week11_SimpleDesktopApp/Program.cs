using Week5_DataLayer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Week11_SimpleDesktopApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

            // Create the Host for Dependency Injection
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    // Register DbContext
                    services.AddDbContext<LibraryDbContext>();

                    // Register your forms
                    services.AddTransient<Form1>(); // Ensure MainForm uses DI
                })
                .Build();

            // Resolve and run the MainForm using DI
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using var scope = host.Services.CreateScope();
            var mainForm = scope.ServiceProvider.GetRequiredService<Form1>();
            Application.Run(mainForm);
        }
    }
}