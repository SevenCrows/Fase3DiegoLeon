namespace AplicacionUI
{
    using System;
    using System.Windows.Forms;
    using AplicacionUI.Interfaz.Pila;
    using AplicacionUI.Interfaz.Seguridad;

    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Seguridad());
            //Application.Run(new Informacion());
        }
    }
}