namespace AplicacionUI.Modelos.Lista
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Lista
    {
        public int CodigoReserva { get; set; }
        public string Destino { get; set; }
        public DateTime FechaViaje { get; set; }
        public long ValorTiquete { get; set; }
    }
}