using System;
using Microsoft.Extensions.DependencyInjection;
using Calculator.Infrastructure;
using Calculator.Services;

namespace Calculator
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
            ApplicationConfiguration.Initialize();

            Form1 form = null;
            Services.AddTransient<Form1>();
            Services.AddSingleton<IMathService, MathService>();
            BuildServiceProvider(out form);
            Application.Run(form);
        }
        private static IServiceCollection Services { get; set; } = new ServiceCollection();
        private static ServiceProvider ServiceProvider { get; set; }

        public static void BuildServiceProvider(out Form1 form)
        {
            ServiceProvider = Services.BuildServiceProvider();
            form = ServiceProvider.GetRequiredService<Form1>();
        }
        public static T GetService<T>()
        {
            return (T)ServiceProvider.GetRequiredService<T>();
        }
    }
}