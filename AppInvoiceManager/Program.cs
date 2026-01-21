using InvoiceDataAccess.Configuration;

namespace AppInvoiceManager
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
            try
            {
                using (var context = new Conn())
                {
                    context.Database.EnsureCreated();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao inicializar o banco de dados: " + ex.Message);
            }
            Application.Run(new Form1());
        }
    }
}