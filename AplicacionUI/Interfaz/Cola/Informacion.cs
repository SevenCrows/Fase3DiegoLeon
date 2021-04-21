namespace AplicacionUI.Interfaz.Cola
{
    using System;
    using System.Windows.Forms;
    using AplicacionUI.Recursos.UI;

    public partial class Informacion : Form
    {
        private Pila.Informacion informacionPila;
        private Cola.Formulario formularioCola;
        private Lista.Informacion informacionLista;

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

        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(rcsMensajesUI.MensajeConfirmarSalirPrograma, rcsMensajesUI.ToolbarSalirPrograma, MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                Environment.Exit(1);
            }
        }

        private void btn_iniciar_cola_Click(object sender, EventArgs e)
        {
            this.formularioCola = new Cola.Formulario();
            this.formularioCola.Show();
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