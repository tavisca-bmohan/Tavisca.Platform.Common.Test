﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tavisca.Libraries.Logging.Tests
{
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
    internal class Resource
    {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource()
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Tavisca.Platform.Common.Logging.Tests.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to {
        ///&quot;sessionId&quot;: &quot;11c3a5f0-21c3-406a-a4d2-03a15787b9ea&quot;,
        ///&quot;hotelId&quot;: &quot;1417498&quot;,
        ///&quot;rooms&quot;: [
        ///{
        ///&quot;roomRefId&quot;: &quot;8cf6060f-4093-4579-aef7-bdcba75548b4&quot;,
        ///&quot;rateRefId&quot;: &quot;8eebdd38-e903-4f00-b606-6683e4a73df2_1mgtzvkzaio_1417498_0##3008bd14-9793-4a8a-b537-0d49943f2fc4&quot;,
        ///&quot;guests&quot;: [
        ///{
        ///&quot;type&quot;: &quot;adult&quot;,
        ///&quot;name&quot;: {
        ///&quot;title&quot;: &quot;mr&quot;,
        ///&quot;first&quot;: &quot;Cletus&quot;,
        ///&quot;middle&quot;: &quot;TestTavisca&quot;,
        ///&quot;last&quot;: &quot;Cletus&quot;,
        ///&quot;suffix&quot;: &quot;Jr&quot;
        ///},
        ///&quot;age&quot;: 25
        ///},
        ///{
        ///&quot;type&quot;: &quot;adult&quot;,
        ///&quot;name&quot;: {
        ///&quot;title&quot;: &quot;mr&quot;,
        ///&quot;first&quot;: &quot;Cletus&quot;,
        ///&quot;middle&quot;: &quot;TestTavis [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string BookInitRequest
        {
            get
            {
                return ResourceManager.GetString("BookInitRequest", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to &lt;note&gt;
        ///&lt;to&gt;Tove&lt;/to&gt;
        ///&lt;from&gt;Jani&lt;/from&gt;
        ///&lt;heading&gt;Reminder&lt;/heading&gt;
        ///&lt;body&gt;Don&apos;t forget me this weekend!&lt;/body&gt;
        ///&lt;/note&gt;.
        /// </summary>
        internal static string XmlData
        {
            get
            {
                return ResourceManager.GetString("XmlData", resourceCulture);
            }
        }
    }
}
