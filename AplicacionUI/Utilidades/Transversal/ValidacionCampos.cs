namespace AplicacionUI.Utilidades.Transversal
{
    using System.Threading.Tasks;
    using AplicacionUI.Modelos.Transversal;
    using AplicacionUI.Recursos.Transversal;

    /// <summary>
    /// Clase ValidacionCampos.
    /// </summary>
    public class ValidacionCampos
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="ValidacionCampos"/>.
        /// </summary>
        public ValidacionCampos()
        {
        }

        /// <summary>
        /// Validar los campos de texto vacio.
        /// </summary>
        /// <param name="texto">Texto a validar.</param>
        /// <returns>Respuestade tipo bool.</returns>
        public Respuesta<bool> ValidarCampoTextoVacio(string texto)
        {
            return new Respuesta<bool>
            {
                Resultado = !string.IsNullOrEmpty(texto),
                Mensaje = rcsTransversal.ErrorCampoVacio
            };
        }

        /// <summary>
        /// Validar campos numericos.
        /// </summary>
        /// <param name="texto">Texto a validar.</param>
        /// <returns>Respuesta de tipo numerico.</returns>
        public Respuesta<int> ValidarCampoNumerico(string texto)
        {
            return new Respuesta<int>
            {
                Resultado = int.TryParse(texto, out int valor),
                Entidad = valor,
                Mensaje = rcsTransversal.ErrorCampoNoNumerico
            };
        }

        /// <summary>
        /// Validar el valor superior a cero.
        /// </summary>
        /// <param name="numero">El numero a validar.</param>
        /// <returns>Respuesta de tipo numerico.</returns>
        public Respuesta<int> ValidarValorSuperiorACero(int numero)
        {
            return new Respuesta<int>
            {
                Resultado = numero > 0,
                Entidad = numero,
                Mensaje = rcsTransversal.ErrorValorInferior0
            };
        }
    }
}