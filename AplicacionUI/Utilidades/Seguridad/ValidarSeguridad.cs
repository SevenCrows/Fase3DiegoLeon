// ***********************************************************************
// Assembly         : AplicacionUI
// Author           : Diego Leon Torres
// Created          : 04-18-2021
//
// Last Modified By : Diego Leon Torres
// Last Modified On : 04-18-2021
// ***********************************************************************
// <copyright file="ValidarSeguridad.cs" company="SevenCrows">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace AplicacionUI.Utilidades.Seguridad
{
    using AplicacionUI.Modelos.Transversal;
    using AplicacionUI.Recursos.Seguridad;

    /// <summary>
    /// Clase ValidacionSeguridad.
    /// </summary>
    public class ValidacionSeguridad
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="ValidacionSeguridad" />.
        /// </summary>
        public ValidacionSeguridad()
        {
        }

        /// <summary>
        /// Validar la contraseña.
        /// </summary>
        /// <param name="password">La contraseña</param>
        /// <returns>Respuesta de tipo bool.</returns>
        public Respuesta<bool> ValidarPasswordGenerico(string password)
        {
            Respuesta<bool> respuesta = new Respuesta<bool>
            {
                Resultado = true,
                Mensaje = rcsSeguridad.PasswordValido
            };

            if (!password.Equals(rcsSeguridad.GenericPassword))
            {
                respuesta.Mensaje = rcsSeguridad.ErrorPasswordNoValido;
                respuesta.Resultado = false;
                return respuesta;
            }

            return respuesta;
        }
    }
}