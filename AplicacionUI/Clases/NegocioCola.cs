// ***********************************************************************
// Assembly         : AplicacionUI
// Author           : Diego Leon Torres
// Created          : 04-20-2021
//
// Last Modified By : Diego Leon Torres
// Last Modified On : 04-20-2021
// ***********************************************************************
// <copyright file="NegocioCola.cs" company="SevenCrows">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace AplicacionUI.Clases
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using AplicacionUI.Modelos.Cola;

    /// <summary>
    /// Class NegocioCola.
    /// </summary>
    public class NegocioCola
    {
        /// <summary>
        /// The queue turista
        /// </summary>
        private Queue<Cola> queueTurista;

        /// <summary>
        /// Initializes a new instance of the <see cref="NegocioCola"/> class.
        /// </summary>
        public NegocioCola()
        {
            this.queueTurista = new Queue<Cola>();
        }

        /// <summary>
        /// Guardars the informacion.
        /// </summary>
        /// <param name="turista">The turista.</param>
        public void GuardarInformacion(Cola turista)
        {
            this.queueTurista.Enqueue(turista);
        }

        /// <summary>
        /// Retornars the total registros.
        /// </summary>
        /// <returns>System.Int32.</returns>
        public int RetornarTotalRegistros()
        {
            return this.queueTurista.Count();
        }

        /// <summary>
        /// Eliminars the registro.
        /// </summary>
        public void EliminarRegistro()
        {
            this.queueTurista.Dequeue();
        }

        /// <summary>
        /// Validars the existencia registro.
        /// </summary>
        /// <param name="pasaporte">The pasaporte.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool ValidarExistenciaRegistro(long pasaporte)
        {
            return this.queueTurista.Where(x => x.NumeroPasaporte == pasaporte).Any();
        }

        /// <summary>
        /// Retornars the queue encuesta.
        /// </summary>
        /// <returns>Queue&lt;Cola&gt;.</returns>
        public Queue<Cola> RetornarQueueEncuesta()
        {
            return this.queueTurista;
        }

        /// <summary>
        /// Recuperars the entidad.
        /// </summary>
        /// <param name="valor">The valor.</param>
        /// <returns>Cola.</returns>
        public Cola RecuperarEntidad(long valor)
        {
            return this.queueTurista.Where(x => x.NumeroPasaporte == valor).FirstOrDefault();
        }
    }
}