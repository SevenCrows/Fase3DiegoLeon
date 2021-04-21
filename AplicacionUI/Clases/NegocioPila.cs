// ***********************************************************************
// Assembly         : AplicacionUI
// Author           : Diego Leon Torres
// Created          : 04-20-2021
//
// Last Modified By : Diego Leon Torres
// Last Modified On : 04-20-2021
// ***********************************************************************
// <copyright file="NegocioPila.cs" company="SevenCrows">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace AplicacionUI.Clases
{
    using System.Collections.Generic;
    using System.Linq;
    using AplicacionUI.Modelos.Pila;

    /// <summary>
    /// Class NegocioPila.
    /// </summary>
    public class NegocioPila
    {
        /// <summary>
        /// The stack encuesta
        /// </summary>
        private Stack<Pila> stackEncuesta;

        /// <summary>
        /// Initializes a new instance of the <see cref="NegocioPila"/> class.
        /// </summary>
        public NegocioPila()
        {
            this.stackEncuesta = new Stack<Pila>();
        }

        /// <summary>
        /// Guardars the informacion.
        /// </summary>
        /// <param name="encuesta">The encuesta.</param>
        public void GuardarInformacion(Pila encuesta)
        {
            this.stackEncuesta.Push(encuesta);
        }

        /// <summary>
        /// Retornars the total registros.
        /// </summary>
        /// <returns>System.Int32.</returns>
        public int RetornarTotalRegistros()
        {
            return this.stackEncuesta.Count();
        }

        /// <summary>
        /// Eliminars the registro.
        /// </summary>
        public void EliminarRegistro()
        {
            this.stackEncuesta.Pop();
        }

        /// <summary>
        /// Validars the existencia registro.
        /// </summary>
        /// <param name="identificacion">The identificacion.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool ValidarExistenciaRegistro(int identificacion)
        {
            return this.stackEncuesta.Where(x => x.Identificacion == identificacion).Any();
        }

        /// <summary>
        /// Retornars the stock encuesta.
        /// </summary>
        /// <returns>Stack&lt;Pila&gt;.</returns>
        public Stack<Pila> RetornarStockEncuesta()
        {
            return this.stackEncuesta;
        }

        /// <summary>
        /// Recuperars the entidad.
        /// </summary>
        /// <param name="valor">The valor.</param>
        /// <returns>Pila.</returns>
        public Pila RecuperarEntidad(long valor)
        {
            return this.stackEncuesta.Where(x => x.Identificacion == valor).FirstOrDefault();
        }
    }
}