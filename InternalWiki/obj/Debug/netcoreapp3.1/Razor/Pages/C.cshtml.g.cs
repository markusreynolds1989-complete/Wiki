#pragma checksum "C:\Users\MR071411\Desktop\FunCode\CSharp\Wiki\InternalWiki\InternalWiki\Pages\C.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e5fec2e248a586628a1be1336e7e22c1e8bbf9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(InternalWiki.Pages.Pages_C), @"mvc.1.0.razor-page", @"/Pages/C.cshtml")]
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
#line 1 "C:\Users\MR071411\Desktop\FunCode\CSharp\Wiki\InternalWiki\InternalWiki\Pages\_ViewImports.cshtml"
using InternalWiki;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e5fec2e248a586628a1be1336e7e22c1e8bbf9b", @"/Pages/C.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79b23258dcb9c77ee4f6560083efbe2007a455bc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_C : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\MR071411\Desktop\FunCode\CSharp\Wiki\InternalWiki\InternalWiki\Pages\C.cshtml"
  ViewData["Title"] = "C";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""title""> <h1> C </h1> </div>
<div id=""content"">
    <p> Here is the first page of some information about the C language. I can't guarantee this will expand out at all , but, for now this is just the beginning and we can always program a way to move everything to the right spot later. </p>
<pre>
<code class=""language-c""> 
#include &lt;stdio.h&gt;
#include &lt;stdint.h&gt;
int32_t main() {
        printf(""Hello, World!"");
        return 0;
}
</code>
</pre>
    <p> A simple hello world program </p>
    <p> C is a great and simple language. It's lighting fast to compile, and allows you to do almost anything you want in it. That means it allows you to make as many mistakes as you want. I will write more about C in later pages. </p>
</div>
<button class=""btn-secondary""> Modify </button>
<div id=""tags""> Clang, </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_C> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_C> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_C>)PageContext?.ViewData;
        public Pages_C Model => ViewData.Model;
    }
}
#pragma warning restore 1591
