namespace AplicacionUI.Clases
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using AplicacionUI.Modelos.Cola;

    public class NegocioCola
    {
        private Queue<Cola> queueTurista;

        public NegocioCola()
        {
            this.queueTurista = new Queue<Cola>();
        }

        public void GuardarInformacion(Cola turista)
        {
            this.queueTurista.Enqueue(turista);
        }

        public int RetornarTotalRegistros()
        {
            return this.queueTurista.Count();
        }

        public void EliminarRegistro()
        {
            this.queueTurista.Dequeue();
        }

        public bool ValidarExistenciaRegistro(long pasaporte)
        {
            return this.queueTurista.Where(x => x.NumeroPasaporte == pasaporte).Any();
        }

        public Queue<Cola> RetornarQueueEncuesta()
        {
            return this.queueTurista;
        }
    }
}