﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Architecs.Dominio {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class resMensajes {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal resMensajes() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Architecs.Dominio.resMensajes", typeof(resMensajes).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to !Registro de {0}, se ha actualizado con exito.!.
        /// </summary>
        public static string msjActualizadoOK {
            get {
                return ResourceManager.GetString("msjActualizadoOK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to !Registro de {0}, se ha eliminado con exito.!.
        /// </summary>
        public static string msjEliminadoOK {
            get {
                return ResourceManager.GetString("msjEliminadoOK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to !Registro de {0}, se ha guardado con exito.!.
        /// </summary>
        public static string msjGuardadoOK {
            get {
                return ResourceManager.GetString("msjGuardadoOK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to !No se ha encontrado el registro de {0}. !.
        /// </summary>
        public static string msjNoBuscado {
            get {
                return ResourceManager.GetString("msjNoBuscado", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to !No se ha podido eliminar registro de {0}. !.
        /// </summary>
        public static string msjNoEliminado {
            get {
                return ResourceManager.GetString("msjNoEliminado", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to !No se ha podido realizar el listado de {0}. !.
        /// </summary>
        public static string msjNoListado {
            get {
                return ResourceManager.GetString("msjNoListado", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to !Registro de {0}, no se ha guardado con exito.!.
        /// </summary>
        public static string msjNoRegistrado {
            get {
                return ResourceManager.GetString("msjNoRegistrado", resourceCulture);
            }
        }
    }
}
