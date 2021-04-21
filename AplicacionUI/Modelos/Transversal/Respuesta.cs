// ***********************************************************************
// Assembly         : AplicacionUI
// Author           : Diego Leon Torres
// Created          : 04-18-2021
//
// Last Modified By : Diego Leon Torres
// Last Modified On : 04-18-2021
// ***********************************************************************
// <copyright file="Respuesta.cs" company="SevenCrows">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace AplicacionUI.Modelos.Transversal
{
    /// <summary>
    /// Class Respuesta.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Respuesta<T>
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Respuesta{T}" />.
        /// </summary>
        public Respuesta()
        {
        }

        /// <summary>
        /// Obtiene o establece la entidad.
        /// </summary>
        /// <value>The entidad.</value>
        public T Entidad { get; set; }

        /// <summary>
        /// Obtiene o establece un valor que indica si tiene resultado.
        /// </summary>
        /// <value><c>true</c> if resultado; otherwise, <c>false</c>.</value>
        public bool Resultado { get; set; }

        /// <summary>
        /// Obtiene o establece el mensaje.
        /// </summary>
        /// <value>The mensaje.</value>
        public string Mensaje { get; set; }
    }
}