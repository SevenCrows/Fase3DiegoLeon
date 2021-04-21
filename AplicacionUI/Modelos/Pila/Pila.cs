// ***********************************************************************
// Assembly         : AplicacionUI
// Author           : Diego Leon Torres
// Created          : 04-19-2021
//
// Last Modified By : Diego Leon Torres
// Last Modified On : 04-19-2021
// ***********************************************************************
// <copyright file="Pila.cs" company="SevenCrows">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace AplicacionUI.Modelos.Pila
{
    /// <summary>
    /// Class Pila.
    /// </summary>
    public class Pila
    {
        /// <summary>
        /// Gets or sets the identificacion.
        /// </summary>
        /// <value>The identificacion.</value>
        public int Identificacion { get; set; }

        /// <summary>
        /// Gets or sets the estrato.
        /// </summary>
        /// <value>The estrato.</value>
        public string Estrato { get; set; }

        /// <summary>
        /// Gets or sets the ubicacion.
        /// </summary>
        /// <value>The ubicacion.</value>
        public string Ubicacion { get; set; }

        /// <summary>
        /// Gets or sets the canal.
        /// </summary>
        /// <value>The canal.</value>
        public string Canal { get; set; }
    }
}