﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GodotPCKExplorer.UI.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GodotPCKExplorer.UI.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Godot can embed &apos;.pck&apos; files into other files.
        ///Therefore, GodotPCKExplorer.UI can open both &apos;.pck&apos; and files with embedded &apos;pck&apos;.
        ///Encryption is only verified with PCK for Godot 4.
        ///&quot;&quot; - Paths and other arguments must be without spaces or inside quotes.
        ///{} - Optional arguments
        ///
        ///Examples of valid commands:
        ///-o	Open pack file
        ///	-o [path to pack] {[encryption key]}
        ///	-o C:/Game.exe
        ///	-o C:/Game.pck
        ///
        ///-i	Show pack file info
        ///	-i [path to pack]
        ///	-i C:/Game.exe
        ///	-i C:/Game.pck
        ///	
        ///-l	Show pack file info wi [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string HelpText {
            get {
                return ResourceManager.GetString("HelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon icon {
            get {
                object obj = ResourceManager.GetObject("icon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap pckAbout {
            get {
                object obj = ResourceManager.GetObject("pckAbout", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
