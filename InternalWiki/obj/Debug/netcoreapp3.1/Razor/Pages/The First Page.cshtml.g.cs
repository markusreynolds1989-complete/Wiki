#pragma checksum "/home/mars/Documents/Code/C#/Wiki/InternalWiki/Pages/The First Page.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a48de167c4268a9717b52e3b7b435c39cf3c942"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(InternalWiki.Pages.Pages_The_First_Page), @"mvc.1.0.razor-page", @"/Pages/The First Page.cshtml")]
namespace InternalWiki.Pages
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
#line 1 "/home/mars/Documents/Code/C#/Wiki/InternalWiki/Pages/_ViewImports.cshtml"
using InternalWiki;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a48de167c4268a9717b52e3b7b435c39cf3c942", @"/Pages/The First Page.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"413fec48d248812a21845e8faaca7e338a11b485", @"/Pages/_ViewImports.cshtml")]
    public class Pages_The_First_Page : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/mars/Documents/Code/C#/Wiki/InternalWiki/Pages/The First Page.cshtml"
  ViewData["Title"] ="The First Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1> The First Page </h1><p> This is the first ever page added to this wiki. Conrats! </p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_The_First_Page> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_The_First_Page> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_The_First_Page>)PageContext?.ViewData;
        public Pages_The_First_Page Model => ViewData.Model;
    }
}
#pragma warning restore 1591
