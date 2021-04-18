﻿namespace AplicacionUI.Interfaz.Seguridad
{
    using System;
    using System.Windows.Forms;
    using AplicacionUI.Modelos.Transversal;
    using AplicacionUI.Recursos.UI;
    using AplicacionUI.Utilidades.Seguridad;
    using AplicacionUI.Utilidades.Transversal;

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

        public Seguridad()
        {
            InitializeComponent();
            this.validacionSeguridad = new ValidacionSeguridad();
            this.validacionCampos = new ValidacionCampos();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(rcsMensajesUI.MensajeConfirmarSalirPrograma, rcsMensajesUI.ToolbarSalirPrograma, MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                Environment.Exit(1);
            }
        }

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
                    //this.formularioReserva = new FormularioReserva(new Reserva());
                    //formularioReserva.Show();
                    //this.Hide();
                }
            }
        }
    }
}