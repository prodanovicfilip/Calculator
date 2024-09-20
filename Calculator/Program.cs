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
            form = Services.BuildServiceProvider().GetRequiredService<Form1>();
            Application.Run(form);
        }
        private static IServiceCollection Services { get; set; } = new ServiceCollection();

    }
}