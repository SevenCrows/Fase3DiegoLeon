// ***********************************************************************
// Assembly         : AplicacionUI
// Author           : Diego Leon Torres
// Created          : 04-20-2021
//
// Last Modified By : Diego Leon Torres
// Last Modified On : 04-20-2021
// ***********************************************************************
// <copyright file="NegocioLista.cs" company="SevenCrows">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace AplicacionUI.Clases
{
    using System.Collections.Generic;
    using System.Linq;
    using AplicacionUI.Modelos.Lista;

    /// <summary>
    /// Class NegocioLista.
    /// </summary>
    public class NegocioLista
    {
        /// <summary>
        /// The lista pasajero
        /// </summary>
        private List<Lista> listaPasajero;

        /// <summary>
        /// Initializes a new instance of the <see cref="NegocioLista"/> class.
        /// </summary>
        public NegocioLista()
        {
            this.listaPasajero = new List<Lista>();
        }

        /// <summary>
        /// Guardars the informacion.
        /// </summary>
        /// <param name="pasajero">The pasajero.</param>
        public void GuardarInformacion(Lista pasajero)
        {
            this.listaPasajero.Add(pasajero);
        }

        /// <summary>
        /// Retornars the total registros.
        /// </summary>
        /// <returns>System.Int32.</returns>
        public int RetornarTotalRegistros()
        {
            return this.listaPasajero.Count();
        }

        /// <summary>
        /// Eliminars the registro.
        /// </summary>
        /// <param name="reserva">The reserva.</param>
        public void EliminarRegistro(int reserva)
        {
            Lista elementoEliminar = this.RecuperarEntidad(reserva);
            this.listaPasajero.Remove(elementoEliminar);
        }

        /// <summary>
        /// Validars the existencia registro.
        /// </summary>
        /// <param name="reserva">The reserva.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool ValidarExistenciaRegistro(int reserva)
        {
            return this.listaPasajero.Where(x => x.CodigoReserva == reserva).Any();
        }

        /// <summary>
        /// Retornars the lista encuesta.
        /// </summary>
        /// <returns>List&lt;Lista&gt;.</returns>
        public List<Lista> RetornarListaEncuesta()
        {
            return this.listaPasajero;
        }

        /// <summary>
        /// Recuperars the entidad.
        /// </summary>
        /// <param name="valor">The valor.</param>
        /// <returns>Lista.</returns>
        public Lista RecuperarEntidad(int valor)
        {
            return this.listaPasajero.Where(x => x.CodigoReserva == valor).FirstOrDefault();
        }
    }
}