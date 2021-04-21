namespace AplicacionUI.Interfaz.Pila
{
    using System;
    using System.Windows.Forms;
    using AplicacionUI.Recursos.UI;

    public partial class Informacion : Form
    {
        private Formulario formularioPila;
        private Cola.Informacion informacionCola;
        private Lista.Informacion informacionLista;

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

        private void btn_iniciar_pila_Click(object sender, EventArgs e)
        {
            this.formularioPila = new Formulario();
            this.formularioPila.Show();
            this.Hide();
        }

        private void btn_colas_Click(object sender, EventArgs e)
        {
            this.informacionCola = new Cola.Informacion();
            this.informacionCola.Show();
            this.Hide();
        }

        private void btn_listas_Click(object sender, EventArgs e)
        {
            this.informacionLista = new Lista.Informacion();
            this.informacionLista.Show();
            this.Hide();
        }
    }
}