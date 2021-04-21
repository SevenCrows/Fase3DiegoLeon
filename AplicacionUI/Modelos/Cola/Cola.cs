// ***********************************************************************
// Assembly         : AplicacionUI
// Author           : Diego Leon Torres
// Created          : 04-19-2021
//
// Last Modified By : Diego Leon Torres
// Last Modified On : 04-19-2021
// ***********************************************************************
// <copyright file="Cola.cs" company="SevenCrows">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace AplicacionUI.Modelos.Cola
{
    using System;

    /// <summary>
    /// Class Cola.
    /// </summary>
    public class Cola
    {
        /// <summary>
        /// Gets or sets the numero pasaporte.
        /// </summary>
        /// <value>The numero pasaporte.</value>
        public long NumeroPasaporte { get; set; }

        /// <summary>
        /// Gets or sets the nombre completo.
        /// </summary>
        /// <value>The nombre completo.</value>
        public string NombreCompleto { get; set; }

        /// <summary>
        /// Gets or sets the genero.
        /// </summary>
        /// <value>The genero.</value>
        public string Genero { get; set; }

        /// <summary>
        /// Gets or sets the pais residencia.
        /// </summary>
        /// <value>The pais residencia.</value>
        public string PaisResidencia { get; set; }

        /// <summary>
        /// Gets or sets the fecha registra.
        /// </summary>
        /// <value>The fecha registra.</value>
        public DateTime FechaRegistra { get; set; }
    }
}