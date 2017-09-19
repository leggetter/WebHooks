﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.AspNetCore.WebHooks.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.AspNetCore.WebHooks.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} property must not be set to &apos;{1}&apos;..
        /// </summary>
        internal static string ActionAttribute_UnsupportedValue {
            get {
                return ResourceManager.GetString("ActionAttribute_UnsupportedValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not add configuration for receiver &apos;{0}&apos; and id &apos;{1}&apos;: {2}.
        /// </summary>
        internal static string Config_AddFailure {
            get {
                return ResourceManager.GetString("Config_AddFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; application setting must have a comma-separated value of one or more secrets of the form &amp;lt;secret&amp;gt; or &amp;lt;id&amp;gt;=&amp;lt;secret&amp;gt;..
        /// </summary>
        internal static string Config_BadValue {
            get {
                return ResourceManager.GetString("Config_BadValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value cannot be null or empty..
        /// </summary>
        internal static string General_ArgumentCannotBeNullOrEmpty {
            get {
                return ResourceManager.GetString("General_ArgumentCannotBeNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enum type {0} has no defined &apos;{1}&apos; value..
        /// </summary>
        internal static string General_InvalidEnumValue {
            get {
                return ResourceManager.GetString("General_InvalidEnumValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; query parameter provided in the HTTP request did not match the expected value..
        /// </summary>
        internal static string Receiver_BadCode {
            get {
                return ResourceManager.GetString("Receiver_BadCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expecting exactly one &apos;{0}&apos; header field in the WebHook request but found {1}. Please ensure that the request contains exactly one &apos;{0}&apos; header field..
        /// </summary>
        internal static string Receiver_BadHeader {
            get {
                return ResourceManager.GetString("Receiver_BadHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The HTTP &apos;{0}&apos; method is not supported by the &apos;{1}&apos; WebHook receiver..
        /// </summary>
        internal static string Receiver_BadMethod {
            get {
                return ResourceManager.GetString("Receiver_BadMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find a valid configuration for WebHook receiver &apos;{0}&apos; and instance &apos;{1}&apos;. The setting must be set to a value between {2} and {3} characters long..
        /// </summary>
        internal static string Receiver_BadSecret {
            get {
                return ResourceManager.GetString("Receiver_BadSecret", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook signature provided by the &apos;{0}&apos; header field does not match the value expected by the &apos;{1}&apos; receiver. WebHook request is invalid..
        /// </summary>
        internal static string Receiver_BadSignature {
            get {
                return ResourceManager.GetString("Receiver_BadSignature", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook verification request must contain a &apos;{0}&apos; query parameter..
        /// </summary>
        internal static string Receiver_NoCode {
            get {
                return ResourceManager.GetString("Receiver_NoCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook receiver &apos;{0}&apos; requires HTTPS in order to be secure. Please register a WebHook URI of type &apos;{1}&apos;..
        /// </summary>
        internal static string Receiver_NoHttps {
            get {
                return ResourceManager.GetString("Receiver_NoHttps", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error has occurred..
        /// </summary>
        internal static string ResultUtilities_GenericError {
            get {
                return ResourceManager.GetString("ResultUtilities_GenericError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} and {1} were applied to the same action. {0} must not be combined with another attribute that provides a route template..
        /// </summary>
        internal static string RoutingConvention_MixedRouteWithWebHookAttribute {
            get {
                return ResourceManager.GetString("RoutingConvention_MixedRouteWithWebHookAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook request must contain an entity body formatted as HTML Form Data..
        /// </summary>
        internal static string VerifyBody_NoFormData {
            get {
                return ResourceManager.GetString("VerifyBody_NoFormData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook request must contain an entity body formatted as JSON..
        /// </summary>
        internal static string VerifyBody_NoJson {
            get {
                return ResourceManager.GetString("VerifyBody_NoJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The WebHook request must contain an entity body formatted as XML..
        /// </summary>
        internal static string VerifyBody_NoXml {
            get {
                return ResourceManager.GetString("VerifyBody_NoXml", resourceCulture);
            }
        }
    }
}
