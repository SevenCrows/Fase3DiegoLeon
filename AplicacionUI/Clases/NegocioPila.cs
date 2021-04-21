namespace AplicacionUI.Clases
{
    using System.Collections.Generic;
    using System.Linq;
    using AplicacionUI.Modelos.Pila;

    public class NegocioPila
    {
        private Stack<Pila> stackEncuesta;

        public NegocioPila()
        {
            this.stackEncuesta = new Stack<Pila>();
        }

        public void GuardarInformacion(Pila encuesta)
        {
            this.stackEncuesta.Push(encuesta);
        }

        public int RetornarTotalRegistros()
        {
            return this.stackEncuesta.Count();
        }

        public void EliminarRegistro()
        {
            this.stackEncuesta.Pop();
        }

        public bool ValidarExistenciaRegistro(int identificacion)
        {
            return this.stackEncuesta.Where(x => x.Identificacion == identificacion).Any();
        }

        public Stack<Pila> RetornarStockEncuesta()
        {
            return this.stackEncuesta;
        }

        public Pila RecuperarEntidad(long valor)
        {
            return this.stackEncuesta.Where(x => x.Identificacion == valor).FirstOrDefault();
        }
    }
}