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
namespace AplicacionUI.Interfaz.Lista
{
    using System;
    using System.Windows.Forms;
    using AplicacionUI.Clases;
    using AplicacionUI.Recursos.UI;
    using AplicacionUI.Utilidades.Transversal;
    using AplicacionUI.Modelos.Lista;
    using AplicacionUI.Modelos.Transversal;

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
        /// The informacion lista
        /// </summary>
        private Informacion informacionLista;

        /// <summary>
        /// The seleccion destino
        /// </summary>
        private string seleccionDestino;

        /// <summary>
        /// The negocio lista
        /// </summary>
        private readonly NegocioLista negocioLista;

        /// <summary>
        /// The int destino
        /// </summary>
        private int intDestino;

        /// <summary>
        /// Initializes a new instance of the <see cref="Formulario"/> class.
        /// </summary>
        public Formulario()
        {
            InitializeComponent();
            this.validacion = new ValidacionCampos();
            this.negocioLista = new NegocioLista();
            this.CargarListaFormulario();
            this.intDestino = -1;
            this.lb_registros_actuales.Text = this.negocioLista.RetornarTotalRegistros().ToString();
        }

        /// <summary>
        /// Handles the Click event of the lb_regresar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void lb_regresar_Click(object sender, EventArgs e)
        {
            this.informacionLista = new Informacion();
            this.informacionLista.Show();
            this.Hide();
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
        /// Handles the Click event of the btn_eliminar_lista control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_eliminar_lista_Click(object sender, EventArgs e)
        {
            if (this.negocioLista.RetornarTotalRegistros() != 0)
            {
                if (this.ValidarDatoAEliminar())
                {
                    if (this.negocioLista.ValidarExistenciaRegistro(Convert.ToInt32(txt_codigo_reserva.Text)))
                    {
                        this.negocioLista.EliminarRegistro(Convert.ToInt32(txt_codigo_reserva.Text));
                        this.LimpiarInformacionFormulario();
                        this.LimpiarMensajesError();
                        this.lb_registros_actuales.Text = this.negocioLista.RetornarTotalRegistros().ToString();
                        this.CargarListaFormulario();
                    }
                    else
                    {
                        MessageBox.Show(rcsMensajesUI.MensajeErrorDatoNoExisteLista, rcsMensajesUI.ToolbarAlertaInformativa, MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show(rcsMensajesUI.MensajeErrorPilaVacia, rcsMensajesUI.ToolbarAlertaInformativa, MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Handles the Click event of the btn_guardar_lista control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_guardar_lista_Click(object sender, EventArgs e)
        {
            this.LimpiarMensajesError();
            if (this.ValidarInformacionFormulario())
            {
                Lista entidad = new Lista();
                entidad.CodigoReserva = Convert.ToInt32(txt_codigo_reserva.Text);
                entidad.Destino = seleccionDestino;
                entidad.FechaViaje = dtp_fechaviaje.Value;
                entidad.ValorTiquete = Convert.ToInt32(txt_valor.Text);

                if (!this.negocioLista.ValidarExistenciaRegistro(entidad.CodigoReserva))
                {
                    this.negocioLista.GuardarInformacion(entidad);
                    this.lb_registros_actuales.Text = this.negocioLista.RetornarTotalRegistros().ToString();
                    this.LimpiarInformacionFormulario();
                    this.CargarListaFormulario();
                }
                else
                {
                    MessageBox.Show(rcsMensajesUI.MensajeRegistroExistenteLista, rcsMensajesUI.ToolbarAlertaInformativa, MessageBoxButtons.OK);
                }
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the cb_destino control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cb_destino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_destino.SelectedIndex != -1)
            {
                this.intDestino = cb_destino.SelectedIndex;
                this.seleccionDestino = cb_destino.Text;
            }
        }

        /// <summary>
        /// Validars the informacion formulario.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        private bool ValidarInformacionFormulario()
        {
            bool validar = true;
            Respuesta<bool> validarReserva = this.validacion.ValidarCampoTextoVacio(txt_codigo_reserva.Text);
            if (!validarReserva.Resultado)
            {
                validar = false;
                ep_codigo_reserva.SetError(txt_codigo_reserva, validarReserva.Mensaje);
            }
            else
            {
                Respuesta<int> respuesta = this.validacion.ValidarCampoNumerico(txt_codigo_reserva.Text);
                if (!respuesta.Resultado)
                {
                    validar = false;
                    this.ep_codigo_reserva.SetError(txt_codigo_reserva, respuesta.Mensaje);
                }
            }

            Respuesta<bool> validarValor = this.validacion.ValidarCampoTextoVacio(txt_valor.Text);
            if (!validarValor.Resultado)
            {
                validar = false;
                ep_valor.SetError(txt_valor, validarValor.Mensaje);
            }
            else
            {
                Respuesta<int> respuesta = this.validacion.ValidarCampoNumerico(txt_valor.Text);
                if (!respuesta.Resultado)
                {
                    validar = false;
                    this.ep_valor.SetError(txt_valor, respuesta.Mensaje);
                }
            }

            if (this.intDestino == -1)
            {
                validar = false;
                this.ep_destino.SetError(cb_destino, rcsMensajesUI.ErrorProviderSeleccionDestino);
            }

            return validar;
        }

        /// <summary>
        /// Cargars the lista formulario.
        /// </summary>
        private void CargarListaFormulario()
        {
            this.grid_view_lista.DataSource = this.negocioLista.RetornarListaEncuesta().ToArray();
        }

        /// <summary>
        /// Limpiars the informacion formulario.
        /// </summary>
        private void LimpiarInformacionFormulario()
        {
            this.txt_codigo_reserva.Text = string.Empty;
            this.txt_valor.Text = string.Empty;
            this.cb_destino.SelectedIndex = -1;
            this.cb_destino.Text = "Seleccione un destino";
            this.dtp_fechaviaje.Value = DateTime.Now;

            this.intDestino = -1;
        }

        /// <summary>
        /// Limpiars the mensajes error.
        /// </summary>
        private void LimpiarMensajesError()
        {
            this.ep_codigo_reserva.Clear();
            this.ep_destino.Clear();
            this.ep_fecha.Clear();
            this.ep_fecha.Clear();
        }

        /// <summary>
        /// Validars the dato a eliminar.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        private bool ValidarDatoAEliminar()
        {
            bool validar = true;
            Respuesta<bool> validarReserva = this.validacion.ValidarCampoTextoVacio(txt_codigo_reserva.Text);
            if (!validarReserva.Resultado)
            {
                validar = false;
                ep_codigo_reserva.SetError(txt_codigo_reserva, validarReserva.Mensaje);
            }
            else
            {
                Respuesta<int> respuesta = this.validacion.ValidarCampoNumerico(txt_codigo_reserva.Text);
                if (!respuesta.Resultado)
                {
                    validar = false;
                    this.ep_codigo_reserva.SetError(txt_codigo_reserva, respuesta.Mensaje);
                }
            }

            return validar;
        }
    }
}