﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.PowerToys.PreviewHandler.Pdf.Properties
{
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
    internal class Resources
    {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources()
        {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.PowerToys.PreviewHandler.Pdf.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to This pdf could not be preview due to an internal error..
        /// </summary>
        internal static string PdfNotPreviewedError
        {
            get
            {
                return ResourceManager.GetString("PdfNotPreviewedError", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Can't preview pdf. This pdf is password protected..
        /// </summary>
        internal static string PdfPasswordProtectedError
        {
            get
            {
                return ResourceManager.GetString("PdfPasswordProtectedError", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to This PDF contains more pages, this preview only shows the first 10 pages. Open PDF to view all pages..
        /// </summary>
        internal static string PdfMorePagesMessage
        {
            get
            {
                return ResourceManager.GetString("PdfMorePagesMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string for an error when Gpo has the utility disabled.
        /// </summary>
        internal static string GpoDisabledErrorText {
            get {
                return ResourceManager.GetString("GpoDisabledErrorText", resourceCulture);
            }
        }
    }
}
