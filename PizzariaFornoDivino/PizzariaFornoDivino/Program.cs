using Microsoft.VisualBasic.Logging;
using PizzariaFornoDivino.Views;

namespace PizzariaFornoDivino
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Login login = new Login();

            DialogResult result = login.ShowDialog();

            if (result == DialogResult.OK)
            {
                Application.Run(new Dashboard());
            }
            
        }


    }
}