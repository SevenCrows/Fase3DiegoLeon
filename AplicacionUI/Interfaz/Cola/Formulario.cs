namespace AplicacionUI.Interfaz.Cola
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using AplicacionUI.Clases;
    using AplicacionUI.Modelos.Transversal;
    using AplicacionUI.Recursos.UI;
    using AplicacionUI.Utilidades.Transversal;
    using AplicacionUI.Modelos.Cola;

    public partial class Formulario : Form
    {
        /// <summary>
        /// The validacion
        /// </summary>
        private readonly ValidacionCampos validacion;

        private readonly NegocioCola negocioCola;

        private Informacion informacionCola;

        private string seleccionGenero, seleccionPais;

        private int intGenero, intPais;

        public Formulario()
        {
            InitializeComponent();
            this.validacion = new ValidacionCampos();
            this.negocioCola = new NegocioCola();
            this.CargarQueueEncuesta();
            this.intGenero = -1;
            this.intPais = -1;
            this.lb_registros_actuales.Text = this.negocioCola.RetornarTotalRegistros().ToString();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(rcsMensajesUI.MensajeConfirmarSalirPrograma, rcsMensajesUI.ToolbarSalirPrograma, MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                Environment.Exit(1);
            }
        }

        private void btn_eliminar_cola_Click(object sender, EventArgs e)
        {
            if (this.negocioCola.RetornarTotalRegistros() == 0)
            {
                MessageBox.Show(rcsMensajesUI.MensajeErrorPilaVacia, rcsMensajesUI.ToolbarAlertaInformativa, MessageBoxButtons.OK);
            }
            else
            {
                this.negocioCola.EliminarRegistro();
                this.lb_registros_actuales.Text = this.negocioCola.RetornarTotalRegistros().ToString();
                this.CargarQueueEncuesta();
            }
        }

        private void btn_guardar_cola_Click(object sender, EventArgs e)
        {
            this.LimpiarMensajesError();
            if (this.ValidarInformacionFormulario())
            {
                Cola cola = new Cola();
                cola.NumeroPasaporte = Convert.ToInt32(txt_pasaporte.Text);
                cola.NombreCompleto = txt_nombres.Text;
                cola.Genero = seleccionGenero;
                cola.PaisResidencia = seleccionPais;
                cola.FechaRegistra = dtp_registro.Value;

                if (!this.negocioCola.ValidarExistenciaRegistro(cola.NumeroPasaporte))
                {
                    this.negocioCola.GuardarInformacion(cola);
                    this.lb_registros_actuales.Text = this.negocioCola.RetornarTotalRegistros().ToString();
                    this.LimpiarInformacionFormulario();
                    this.CargarQueueEncuesta();
                }
                else
                {
                    MessageBox.Show(rcsMensajesUI.MensajeRegistroExistentePila, rcsMensajesUI.ToolbarAlertaInformativa, MessageBoxButtons.OK);
                }
            }
        }

        private bool ValidarInformacionFormulario()
        {
            bool validar = true;
            Respuesta<bool> validarPasaporte = this.validacion.ValidarCampoTextoVacio(txt_pasaporte.Text);
            if (!validarPasaporte.Resultado)
            {
                validar = false;
                ep_pasaporte.SetError(txt_pasaporte, validarPasaporte.Mensaje);
            }
            else
            {
                Respuesta<int> respuesta = this.validacion.ValidarCampoNumerico(txt_pasaporte.Text);
                if (!respuesta.Resultado)
                {
                    validar = false;
                    this.ep_pasaporte.SetError(txt_pasaporte, respuesta.Mensaje);
                }
            }

            Respuesta<bool> validarNombres = this.validacion.ValidarCampoTextoVacio(txt_nombres.Text);
            if (!validarNombres.Resultado)
            {
                validar = false;
                ep_nombre.SetError(txt_nombres, validarNombres.Mensaje);
            }

            if (this.intGenero == -1)
            {
                validar = false;
                this.ep_genero.SetError(cb_genero, rcsMensajesUI.ErrorProviderSeleccionGenero);
            }

            if (this.intPais == -1)
            {
                validar = false;
                this.ep_pasaporte.SetError(cb_pais, rcsMensajesUI.ErrorProviderSeleccionPaisResidencia);
            }

            return validar;
        }

        private void CargarQueueEncuesta()
        {
            this.grid_view_cola.DataSource = this.negocioCola.RetornarQueueEncuesta().ToList();
        }

        private void LimpiarMensajesError()
        {
            this.ep_pasaporte.Clear();
            this.ep_nombre.Clear();
            this.ep_genero.Clear();
            this.ep_residencia.Clear();
            this.ep_fecha.Clear();
        }

        private void cb_genero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_genero.SelectedIndex != -1)
            {
                this.intGenero = cb_genero.SelectedIndex;
                this.seleccionGenero = cb_genero.Text;
            }
        }

        private void lb_regresar_Click(object sender, EventArgs e)
        {
            this.informacionCola = new Informacion();
            this.informacionCola.Show();
            this.Hide();
        }

        private void cb_pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_pais.SelectedIndex != -1)
            {
                this.intPais = cb_pais.SelectedIndex;
                this.seleccionPais = cb_pais.Text;
            }
        }

        private void LimpiarInformacionFormulario()
        {
            this.txt_nombres.Text = string.Empty;
            this.txt_pasaporte.Text = string.Empty;
            this.cb_genero.SelectedIndex = -1;
            this.cb_genero.Text = "Seleccione un genero";
            this.cb_pais.SelectedIndex = -1;
            this.cb_pais.Text = "Seleccione un país";
            this.dtp_registro.Value = DateTime.Now;

            this.intGenero = -1;
            this.intPais = -1;
        }
    }
}