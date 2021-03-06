#pragma checksum "C:\Users\flora\OneDrive\Week 1 MSSA\ASP.NET\ASP.NET-MVC\Projects\Asp.netFundamentals\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09bb991aca3dc0f3a976b69268a247647307e52b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\flora\OneDrive\Week 1 MSSA\ASP.NET\ASP.NET-MVC\Projects\Asp.netFundamentals\Views\_ViewImports.cshtml"
using Asp.netFundamentals;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\flora\OneDrive\Week 1 MSSA\ASP.NET\ASP.NET-MVC\Projects\Asp.netFundamentals\Views\_ViewImports.cshtml"
using Asp.netFundamentals.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09bb991aca3dc0f3a976b69268a247647307e52b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d4d5a04378e0648ef464e120825378a1da1e87f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\flora\OneDrive\Week 1 MSSA\ASP.NET\ASP.NET-MVC\Projects\Asp.netFundamentals\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome, Florabel</h1>
    <h2 class=""headline"">This is my first web application using ASP.NET</h2>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>

<div class=""search"">
    <center>
        <input type=""text"" placeholder=""What do you want to learn today?"" />
        <a id=""buttons"" href=""https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/overview/asp-net-mvc-overview"">
        </a>
        <button id=""searchbar"" type=""submit"">Search</button>
    </center>
</div>

<div class=""image"">
    <img src=""https://miro.medium.com/max/900/1*GWjlB9_708s3lbx8ufOYlw.jpeg"" />
</div>

<div class=""definition"">
    <h3 class=""aspnet"">What is ASP.NET MVC?</h3>
    <p>
        The Model-View-Controller (MVC) architectural pattern separates an application into three main components: the model, the view, and the controller.
        The ASP.NET MVC framework provide");
            WriteLiteral(@"s an alternative to the ASP.NET Web Forms pattern for creating MVC-based Web applications.
        The ASP.NET MVC framework is a lightweight, highly testable presentation framework that (as with Web Forms-based applications) is integrated with existing ASP.NET features, such as master pages and membership-based authentication.
        The MVC framework is defined in the System.Web.Mvc namespace and is a fundamental, supported part of the System.Web namespace.
    </p>
    <p>
        MVC is a standard design pattern that many developers are familiar with.
        Some types of Web applications will benefit from the MVC framework.
        Others will continue to use the traditional ASP.NET application pattern that is based on Web Forms and postbacks.
        Other types of Web applications will combine the two approaches; neither approach excludes the other.
    </p>
    <p>
        The MVC framework includes the following components:
    </p>
    <p>
        <img src=""https://docs.microsoft.com");
            WriteLiteral("/en-us/aspnet/mvc/overview/older-versions-1/overview/asp-net-mvc-overview/_static/image1.jpg\" />\r\n    </p>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
