﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CDF.Net.Exceptions {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class StandardExceptionMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal StandardExceptionMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CDF.Net.Exceptions.StandardExceptionMessages", typeof(StandardExceptionMessages).Assembly);
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
        ///   Looks up a localized string similar to The user failed authentication cannot continue the current operation..
        /// </summary>
        public static string AuthenticationException {
            get {
                return ResourceManager.GetString("AuthenticationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The user is not authorized to execute the current operation..
        /// </summary>
        public static string AuthorizationException {
            get {
                return ResourceManager.GetString("AuthorizationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A communication error has occured within the application..
        /// </summary>
        public static string CommunicationsException {
            get {
                return ResourceManager.GetString("CommunicationsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuration information for the application could not be found or was invalid..
        /// </summary>
        public static string ConfigurationException {
            get {
                return ResourceManager.GetString("ConfigurationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error has occured while processing data in the application..
        /// </summary>
        public static string DataException {
            get {
                return ResourceManager.GetString("DataException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected data was not provided or the data is invalid. .
        /// </summary>
        public static string DataValidationException {
            get {
                return ResourceManager.GetString("DataValidationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not access external resources for this system, access was denied..
        /// </summary>
        public static string ExternalAccessDeniedException {
            get {
                return ResourceManager.GetString("ExternalAccessDeniedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current operation could not be completed, an internal error has occured..
        /// </summary>
        public static string LogicException {
            get {
                return ResourceManager.GetString("LogicException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An internal application error has occured..
        /// </summary>
        public static string ManagedException {
            get {
                return ResourceManager.GetString("ManagedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A security error has occured within the application..
        /// </summary>
        public static string SecurityException {
            get {
                return ResourceManager.GetString("SecurityException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current operation has timed out and could not be completed..
        /// </summary>
        public static string TimeoutException {
            get {
                return ResourceManager.GetString("TimeoutException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An unknown error has occured and the current process could not continue..
        /// </summary>
        public static string UnhandledLogicException {
            get {
                return ResourceManager.GetString("UnhandledLogicException", resourceCulture);
            }
        }
    }
}
