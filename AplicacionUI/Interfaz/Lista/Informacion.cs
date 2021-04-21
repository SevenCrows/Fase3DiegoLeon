namespace AplicacionUI.Interfaz.Lista
{
    using System;
    using System.Windows.Forms;
    using AplicacionUI.Recursos.UI;

    public partial class Informacion : Form
    {
        private Cola.Informacion informacionCola;
        private Pila.Informacion informacionPila;
        private Lista.Formulario formularioLista;

        public Informacion()
        {
            InitializeComponent();
        }

        private void btn_pila_Click(object sender, EventArgs e)
        {
            this.informacionPila = new Pila.Informacion();
            this.informacionPila.Show();
            this.Hide();
        }

        private void btn_colas_Click(object sender, EventArgs e)
        {
            this.informacionCola = new Cola.Informacion();
            this.informacionCola.Show();
            this.Hide();
        }

        private void btn_iniciar_lista_Click(object sender, EventArgs e)
        {
            this.formularioLista = new Lista.Formulario();
            this.formularioLista.Show();
            this.Hide();
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