namespace AplicacionUI.Interfaz.Pila
{
    using System;
    using System.Windows.Forms;
    using AplicacionUI.Clases;
    using AplicacionUI.Modelos.Transversal;
    using AplicacionUI.Recursos.UI;
    using AplicacionUI.Utilidades.Transversal;
    using AplicacionUI.Modelos.Pila;
    using System.Collections.Generic;

    public partial class Formulario : Form
    {
        /// <summary>
        /// The validacion
        /// </summary>
        private readonly ValidacionCampos validacion;

        private readonly NegocioPila negocioPila;
        private Informacion informacionPila;

        private string seleccionEstrato, seleccionUbicacion, seleccionCanal;

        private int intEstrato, intUbicacion, intCanal;

        public Formulario()
        {
            InitializeComponent();
            this.validacion = new ValidacionCampos();
            this.negocioPila = new NegocioPila();
            this.CargarStackEncuesta();
            this.intEstrato = -1;
            this.intUbicacion = -1;
            this.intCanal = -1;
            this.lb_registros_actuales.Text = this.negocioPila.RetornarTotalRegistros().ToString();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(rcsMensajesUI.MensajeConfirmarSalirPrograma, rcsMensajesUI.ToolbarSalirPrograma, MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                Environment.Exit(1);
            }
        }

        private void cb_estrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_estrato.SelectedIndex != -1)
            {
                this.intEstrato = cb_estrato.SelectedIndex;
                this.seleccionEstrato = cb_estrato.Text;
            }
        }

        private void cb_ubicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_ubicacion.SelectedIndex != -1)
            {
                this.intUbicacion = cb_ubicacion.SelectedIndex;
                this.seleccionUbicacion = cb_ubicacion.Text;
            }
        }

        private void cb_canal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_canal.SelectedIndex != -1)
            {
                this.intCanal = cb_canal.SelectedIndex;
                this.seleccionCanal = cb_canal.Text;
            }
        }

        private void btn_guardar_pila_Click(object sender, EventArgs e)
        {
            this.LimpiarMensajesError();
            if (this.ValidarInformacionFormulario())
            {
                Pila pila = new Pila();
                pila.Identificacion = Convert.ToInt32(txt_identificacion.Text);
                pila.Estrato = seleccionEstrato;
                pila.Ubicacion = seleccionUbicacion;
                pila.Canal = seleccionCanal;

                if (!this.negocioPila.ValidarExistenciaRegistro(pila.Identificacion))
                {
                    this.negocioPila.GuardarInformacion(pila);
                    this.lb_registros_actuales.Text = this.negocioPila.RetornarTotalRegistros().ToString();
                    this.LimpiarInformacionFormulario();
                    this.CargarStackEncuesta();
                }
                else
                {
                    MessageBox.Show(rcsMensajesUI.MensajeRegistroExistentePila, rcsMensajesUI.ToolbarAlertaInformativa, MessageBoxButtons.OK);
                }
            }
        }

        private void lb_regresar_Click(object sender, EventArgs e)
        {
            this.informacionPila = new Informacion();
            this.informacionPila.Show();
            this.Hide();
        }

        private void btn_eliminar_pila_Click(object sender, EventArgs e)
        {
            if (this.negocioPila.RetornarTotalRegistros() == 0)
            {
                MessageBox.Show(rcsMensajesUI.MensajeErrorPilaVacia, rcsMensajesUI.ToolbarAlertaInformativa, MessageBoxButtons.OK);
            }
            else
            {
                this.negocioPila.EliminarRegistro();
                this.lb_registros_actuales.Text = this.negocioPila.RetornarTotalRegistros().ToString();
                this.CargarStackEncuesta();
            }
        }

        private bool ValidarInformacionFormulario()
        {
            bool validar = true;
            Respuesta<bool> validarIdentificacion = this.validacion.ValidarCampoTextoVacio(txt_identificacion.Text);

            if (!validarIdentificacion.Resultado)
            {
                validar = false;
                ep_identificacion.SetError(txt_identificacion, validarIdentificacion.Mensaje);
            }
            else
            {
                Respuesta<int> respuesta = this.validacion.ValidarCampoNumerico(txt_identificacion.Text);
                if (!respuesta.Resultado)
                {
                    validar = false;
                    this.ep_identificacion.SetError(txt_identificacion, respuesta.Mensaje);
                }
            }

            if (this.intEstrato == -1)
            {
                validar = false;
                this.ep_estrato.SetError(cb_estrato, rcsMensajesUI.ErrorProviderSeleccionEstrato);
            }

            if (this.intUbicacion == -1)
            {
                validar = false;
                this.ep_ubicacion.SetError(cb_ubicacion, rcsMensajesUI.ErrorProviderSeleccionUbicacion);
            }

            if (this.intCanal == -1)
            {
                validar = false;
                this.ep_canal.SetError(cb_canal, rcsMensajesUI.ErrorProviderSeleccionCanal);
            }

            return validar;
        }

        private void LimpiarMensajesError()
        {
            this.ep_identificacion.Clear();
            this.ep_estrato.Clear();
            this.ep_ubicacion.Clear();
            this.ep_canal.Clear();
        }

        private void LimpiarInformacionFormulario()
        {
            this.txt_identificacion.Text = string.Empty;
            this.cb_estrato.SelectedIndex = -1;
            this.cb_estrato.Text = "Seleccione su estrato";
            this.cb_ubicacion.SelectedIndex = -1;
            this.cb_ubicacion.Text = "Seleccione una ubicación";
            this.cb_canal.SelectedIndex = -1;
            this.cb_canal.Text = "Seleccione un canal";
            this.intEstrato = -1;
            this.intUbicacion = -1;
            this.intCanal = -1;
        }

        private void CargarStackEncuesta()
        {
            this.grid_view_pila.DataSource = this.negocioPila.RetornarStockEncuesta().ToArray();
        }
    }
}