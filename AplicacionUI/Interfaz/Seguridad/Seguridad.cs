// ***********************************************************************
// Assembly         : AplicacionUI
// Author           : Diego Leon Torres
// Created          : 04-19-2021
//
// Last Modified By : Diego Leon Torres
// Last Modified On : 04-19-2021
// ***********************************************************************
// <copyright file="Seguridad.cs" company="SevenCrows">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace AplicacionUI.Interfaz.Seguridad
{
    using System;
    using System.Windows.Forms;
    using AplicacionUI.Interfaz.Pila;
    using AplicacionUI.Modelos.Transversal;
    using AplicacionUI.Recursos.UI;
    using AplicacionUI.Utilidades.Seguridad;
    using AplicacionUI.Utilidades.Transversal;

    /// <summary>
    /// Class Seguridad.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Seguridad : Form
    {
        /// <summary>
        /// The validacion seguridad
        /// </summary>
        private readonly ValidacionSeguridad validacionSeguridad;

        /// <summary>
        /// The validacion campos
        /// </summary>
        private readonly ValidacionCampos validacionCampos;

        /// <summary>
        /// The formulario reserva
        /// </summary>
        private Informacion informacionPila;

        /// <summary>
        /// Initializes a new instance of the <see cref="Seguridad"/> class.
        /// </summary>
        public Seguridad()
        {
            InitializeComponent();
            this.validacionSeguridad = new ValidacionSeguridad();
            this.validacionCampos = new ValidacionCampos();
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
        /// Handles the Click event of the btn_ingresar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            ep_password.Clear();
            string password = txt_password.Text;

            Respuesta<bool> respuestaValidacion = this.validacionCampos.ValidarCampoTextoVacio(password);

            if (!respuestaValidacion.Resultado)
            {
                txt_password.Focus();
                ep_password.SetError(txt_password, respuestaValidacion.Mensaje);
            }
            else
            {
                Respuesta<bool> respuestaSeguridad = this.validacionSeguridad.ValidarPasswordGenerico(password);

                if (!respuestaSeguridad.Resultado)
                {
                    txt_password.Focus();
                    txt_password.Clear();
                    MessageBox.Show(respuestaSeguridad.Mensaje, rcsMensajesUI.ToolbarAlertaBoxSeguridad);
                }
                else
                {
                    this.informacionPila = new Informacion();
                    this.informacionPila.Show();
                    this.Hide();
                }
            }
        }
    }
}