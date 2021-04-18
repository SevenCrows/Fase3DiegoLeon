namespace AplicacionUI.Interfaz.Pila
{
    using System;
    using System.Windows.Forms;
    using AplicacionUI.Recursos.UI;

    public partial class Informacion : Form
    {
        public Informacion()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(rcsMensajesUI.MensajeConfirmarSalirPrograma, rcsMensajesUI.ToolbarSalirPrograma, MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                Environment.Exit(1);
            }
        }
    }
}