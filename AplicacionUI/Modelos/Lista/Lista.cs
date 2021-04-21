// ***********************************************************************
// Assembly         : AplicacionUI
// Author           : Diego Leon Torres
// Created          : 04-20-2021
//
// Last Modified By : Diego Leon Torres
// Last Modified On : 04-20-2021
// ***********************************************************************
// <copyright file="Lista.cs" company="SevenCrows">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace AplicacionUI.Modelos.Lista
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class Lista.
    /// </summary>
    public class Lista
    {
        /// <summary>
        /// Gets or sets the codigo reserva.
        /// </summary>
        /// <value>The codigo reserva.</value>
        public int CodigoReserva { get; set; }

        /// <summary>
        /// Gets or sets the destino.
        /// </summary>
        /// <value>The destino.</value>
        public string Destino { get; set; }

        /// <summary>
        /// Gets or sets the fecha viaje.
        /// </summary>
        /// <value>The fecha viaje.</value>
        public DateTime FechaViaje { get; set; }

        /// <summary>
        /// Gets or sets the valor tiquete.
        /// </summary>
        /// <value>The valor tiquete.</value>
        public long ValorTiquete { get; set; }
    }
}