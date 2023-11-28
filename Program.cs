
using SagitarioRH.Models;
using SagitarioRHDesktop.Infraestrutura.Services;
using SagitarioRHDesktop.Models;

namespace SagitarioRHDesktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

           
            FuncionarioModel funcionarioModel = new FuncionarioModel();
            ImpostoINSSModel iNSSModel = new ImpostoINSSModel();
            EventosModel eventosModel = new EventosModel();

           
            CalculoINSS calculoINSS = new CalculoINSS();
            calculoINSS.CalculoInSS(funcionarioModel);




           
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}