﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Albedo.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Albedo.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to {
        ///	&quot;energize&quot;: {
        ///		&quot;state&quot;: {
        ///			&quot;1&quot;: {
        ///				&quot;bri&quot;: 254,
        ///				&quot;ct&quot;: 155
        ///			}
        ///		},
        ///		&quot;name&quot;: &quot;Energize&quot;,
        ///		&quot;tilecolor&quot;: -1
        ///	},
        ///	&quot;concentrate&quot;: {
        ///		&quot;state&quot;: {
        ///			&quot;1&quot;: {
        ///				&quot;bri&quot;: 254,
        ///				&quot;ct&quot;: 231
        ///			}
        ///		},
        ///		&quot;name&quot;: &quot;Concentrate&quot;,
        ///		&quot;tilecolor&quot;: -2
        ///	},
        ///	&quot;reading&quot;: {
        ///		&quot;state&quot;: {
        ///			&quot;1&quot;: {
        ///				&quot;bri&quot;: 240,
        ///				&quot;ct&quot;: 343
        ///			}
        ///		},
        ///		&quot;name&quot;: &quot;Reading&quot;,
        ///		&quot;tilecolor&quot;: -3
        ///	},
        ///	&quot;relax_&quot;: {
        ///		&quot;state&quot;: {
        ///			&quot;1&quot;: {
        ///				&quot;bri&quot;: 144,
        ///				&quot;ct&quot;: 467
        ///			}
        ///		},
        ///		&quot;name&quot;: &quot;Relax&quot;,
        ///		&quot;til [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string defaultScenesJSON {
            get {
                return ResourceManager.GetString("defaultScenesJSON", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///    &quot;latitude&quot;:[42.5,24.0,33.0,17.1,18.2,41.0,40.0,-12.5,-34.0,-14.3,47.3,-25.0,12.5,40.5,44.3,13.2,24.0,50.8,13.0,43.0,26.0,-3.5,9.5,17.9,32.3,4.5,-17.0,12.2,-10.0,24.0,27.5,-54.4,-22.0,53.0,17.3,60.0,-12.0,0.0,7.0,-1.0,47.0,8.0,-16.1,-30.0,6.0,35.0,4.0,10.0,22.0,16.0,12.2,-10.5,35.0,49.8,51.5,11.5,56.0,15.5,19.0,28.0,-2.0,59.0,27.0,25.0,15.0,40.0,8.0,64.0,-18.0,-51.8,5.0,62.0,46.0,-1.0,54.0,12.1,42.0,4.0,49.6,8.0,36.1,72.0,13.5,11.0,16.3,2.0,39.0,-56.0,15.5,13.4,12.0,5.0,22.3,-53.0,15.0,45.2,19.0,47.0, [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string latitude {
            get {
                return ResourceManager.GetString("latitude", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon taskbarIcon {
            get {
                object obj = ResourceManager.GetObject("taskbarIcon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
    }
}