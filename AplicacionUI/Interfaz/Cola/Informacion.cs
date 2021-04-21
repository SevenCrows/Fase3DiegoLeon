// ***********************************************************************
// Assembly         : AplicacionUI
// Author           : Diego Leon Torres
// Created          : 04-20-2021
//
// Last Modified By : Diego Leon Torres
// Last Modified On : 04-20-2021
// ***********************************************************************
// <copyright file="Informacion.cs" company="SevenCrows">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace AplicacionUI.Interfaz.Cola
{
    using System;
    using System.Windows.Forms;
    using AplicacionUI.Recursos.UI;

    /// <summary>
    /// Class Informacion.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Informacion : Form
    {
        /// <summary>
        /// The informacion pila
        /// </summary>
        private Pila.Informacion informacionPila;

        /// <summary>
        /// The formulario cola
        /// </summary>
        private Cola.Formulario formularioCola;

        /// <summary>
        /// The informacion lista
        /// </summary>
        private Lista.Informacion informacionLista;

        /// <summary>
        /// Initializes a new instance of the <see cref="Informacion"/> class.
        /// </summary>
        public Informacion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the btn_pila control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_pila_Click(object sender, EventArgs e)
        {
            this.informacionPila = new Pila.Informacion();
            this.informacionPila.Show();
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
        /// Handles the Click event of the btn_iniciar_cola control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_iniciar_cola_Click(object sender, EventArgs e)
        {
            this.formularioCola = new Cola.Formulario();
            this.formularioCola.Show();
            this.Hide();
        }

        /// <summary>
        /// Handles the Click event of the btn_listas control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_listas_Click(object sender, EventArgs e)
        {
            this.informacionLista = new Lista.Informacion();
            this.informacionLista.Show();
            this.Hide();
        }
    }
}