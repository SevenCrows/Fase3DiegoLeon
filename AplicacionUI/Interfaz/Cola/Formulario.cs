// ***********************************************************************
// Assembly         : AplicacionUI
// Author           : Diego Leon Torres
// Created          : 04-20-2021
//
// Last Modified By : Diego Leon Torres
// Last Modified On : 04-20-2021
// ***********************************************************************
// <copyright file="Formulario.cs" company="SevenCrows">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
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

    /// <summary>
    /// Class Formulario.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Formulario : Form
    {
        /// <summary>
        /// The validacion
        /// </summary>
        private readonly ValidacionCampos validacion;

        /// <summary>
        /// The negocio cola
        /// </summary>
        private readonly NegocioCola negocioCola;

        /// <summary>
        /// The informacion cola
        /// </summary>
        private Informacion informacionCola;

        /// <summary>
        /// The seleccion genero
        /// </summary>
        private string seleccionGenero, seleccionPais;

        /// <summary>
        /// The int genero
        /// </summary>
        private int intGenero, intPais;

        /// <summary>
        /// Initializes a new instance of the <see cref="Formulario"/> class.
        /// </summary>
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

        /// <summary>
        /// Handles the Click event of the btn_salir control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(rcsMensajesUI.MensajeConfirmarSalirPrograma, rcsMensajesUI.ToolbarSalirPrograma, MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                Environment.Exit(1);
            }
        }

        /// <summary>
        /// Handles the Click event of the btn_eliminar_cola control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the btn_guardar_cola control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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
                    MessageBox.Show(rcsMensajesUI.MensajeRegistroExistenteCola, rcsMensajesUI.ToolbarAlertaInformativa, MessageBoxButtons.OK);
                }
            }
        }

        /// <summary>
        /// Validars the informacion formulario.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
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

        /// <summary>
        /// Cargars the queue encuesta.
        /// </summary>
        private void CargarQueueEncuesta()
        {
            this.grid_view_cola.DataSource = this.negocioCola.RetornarQueueEncuesta().ToList();
        }

        /// <summary>
        /// Limpiars the mensajes error.
        /// </summary>
        private void LimpiarMensajesError()
        {
            this.ep_pasaporte.Clear();
            this.ep_nombre.Clear();
            this.ep_genero.Clear();
            this.ep_residencia.Clear();
            this.ep_fecha.Clear();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the cb_genero control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cb_genero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_genero.SelectedIndex != -1)
            {
                this.intGenero = cb_genero.SelectedIndex;
                this.seleccionGenero = cb_genero.Text;
            }
        }

        /// <summary>
        /// Handles the Click event of the lb_regresar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void lb_regresar_Click(object sender, EventArgs e)
        {
            this.informacionCola = new Informacion();
            this.informacionCola.Show();
            this.Hide();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the cb_pais control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cb_pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_pais.SelectedIndex != -1)
            {
                this.intPais = cb_pais.SelectedIndex;
                this.seleccionPais = cb_pais.Text;
            }
        }

        /// <summary>
        /// Limpiars the informacion formulario.
        /// </summary>
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