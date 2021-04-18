namespace AplicacionUI.Modelos.Transversal
{
    public class Respuesta<T>
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Respuesta{T}"/>.
        /// </summary>
        public Respuesta()
        {
        }

        /// <summary>
        /// Obtiene o establece la entidad.
        /// </summary>
        public T Entidad { get; set; }

        /// <summary>
        /// Obtiene o establece un valor que indica si tiene resultado.
        /// </summary>
        public bool Resultado { get; set; }

        /// <summary>
        /// Obtiene o establece el mensaje.
        /// </summary>
        public string Mensaje { get; set; }
    }
}