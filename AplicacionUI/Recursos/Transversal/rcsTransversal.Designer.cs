// ***********************************************************************
// Assembly         : AplicacionUI
// Author           : Diego Leon Torres
// Created          : 04-18-2021
//
// Last Modified By : Diego Leon Torres
// Last Modified On : 04-18-2021
// ***********************************************************************
// <copyright file="rcsTransversal.Designer.cs" company="SevenCrows">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace AplicacionUI.Recursos.Transversal {
    using System;


    /// <summary>
    /// Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class rcsTransversal {

        /// <summary>
        /// The resource man
        /// </summary>
        private static global::System.Resources.ResourceManager resourceMan;

        /// <summary>
        /// The resource culture
        /// </summary>
        private static global::System.Globalization.CultureInfo resourceCulture;

        /// <summary>
        /// Initializes a new instance of the <see cref="rcsTransversal"/> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal rcsTransversal() {
        }

        /// <summary>
        /// Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        /// <value>The resource manager.</value>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AplicacionUI.Recursos.Transversal.rcsTransversal", typeof(rcsTransversal).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        /// Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        /// búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        /// <value>The culture.</value>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }

        /// <summary>
        /// Busca una cadena traducida similar a El valor debe ser un campo numérico..
        /// </summary>
        /// <value>The error campo no numerico.</value>
        internal static string ErrorCampoNoNumerico {
            get {
                return ResourceManager.GetString("ErrorCampoNoNumerico", resourceCulture);
            }
        }

        /// <summary>
        /// Busca una cadena traducida similar a El campo no puede estar vacío..
        /// </summary>
        /// <value>The error campo vacio.</value>
        internal static string ErrorCampoVacio {
            get {
                return ResourceManager.GetString("ErrorCampoVacio", resourceCulture);
            }
        }

        /// <summary>
        /// Busca una cadena traducida similar a El numero digitado debe ser mayor a 0..
        /// </summary>
        /// <value>The error valor inferior0.</value>
        internal static string ErrorValorInferior0 {
            get {
                return ResourceManager.GetString("ErrorValorInferior0", resourceCulture);
            }
        }
    }
}
