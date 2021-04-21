namespace AplicacionUI.Clases
{
    using System.Collections.Generic;
    using System.Linq;
    using AplicacionUI.Modelos.Lista;

    public class NegocioLista
    {
        private List<Lista> listaPasajero;

        public NegocioLista()
        {
            this.listaPasajero = new List<Lista>();
        }

        public void GuardarInformacion(Lista pasajero)
        {
            this.listaPasajero.Add(pasajero);
        }

        public int RetornarTotalRegistros()
        {
            return this.listaPasajero.Count();
        }

        public void EliminarRegistro(int reserva)
        {
            Lista elementoEliminar = this.RecuperarEntidad(reserva);
            this.listaPasajero.Remove(elementoEliminar);
        }

        public bool ValidarExistenciaRegistro(int reserva)
        {
            return this.listaPasajero.Where(x => x.CodigoReserva == reserva).Any();
        }

        public List<Lista> RetornarListaEncuesta()
        {
            return this.listaPasajero;
        }

        public Lista RecuperarEntidad(int valor)
        {
            return this.listaPasajero.Where(x => x.CodigoReserva == valor).FirstOrDefault();
        }
    }
}