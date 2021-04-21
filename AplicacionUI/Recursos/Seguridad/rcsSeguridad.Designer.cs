// ***********************************************************************
// Assembly         : AplicacionUI
// Author           : Diego Leon Torres
// Created          : 04-18-2021
//
// Last Modified By : Diego Leon Torres
// Last Modified On : 04-18-2021
// ***********************************************************************
// <copyright file="rcsSeguridad.Designer.cs" company="SevenCrows">
//     Copyright ©  2021
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace AplicacionUI.Recursos.Seguridad {
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
    internal class rcsSeguridad {

        /// <summary>
        /// The resource man
        /// </summary>
        private static global::System.Resources.ResourceManager resourceMan;

        /// <summary>
        /// The resource culture
        /// </summary>
        private static global::System.Globalization.CultureInfo resourceCulture;

        /// <summary>
        /// Initializes a new instance of the <see cref="rcsSeguridad"/> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal rcsSeguridad() {
        }

        /// <summary>
        /// Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        /// <value>The resource manager.</value>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AplicacionUI.Recursos.Seguridad.rcsSeguridad", typeof(rcsSeguridad).Assembly);
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
        /// Busca una cadena traducida similar a La contraseña es incorrecta..
        /// </summary>
        /// <value>The error password no valido.</value>
        internal static string ErrorPasswordNoValido {
            get {
                return ResourceManager.GetString("ErrorPasswordNoValido", resourceCulture);
            }
        }

        /// <summary>
        /// Busca una cadena traducida similar a 123.
        /// </summary>
        /// <value>The generic password.</value>
        internal static string GenericPassword {
            get {
                return ResourceManager.GetString("GenericPassword", resourceCulture);
            }
        }

        /// <summary>
        /// Busca una cadena traducida similar a La validación de la contraseña fue exitosa..
        /// </summary>
        /// <value>The password valido.</value>
        internal static string PasswordValido {
            get {
                return ResourceManager.GetString("PasswordValido", resourceCulture);
            }
        }
    }
}
