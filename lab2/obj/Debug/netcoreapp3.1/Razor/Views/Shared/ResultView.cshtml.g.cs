#pragma checksum "C:\Users\appac\Desktop\прога2\lab2\Views\Shared\ResultView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03d51ca94ec6c7aebaa6bbb10385390c25bc3f76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ResultView), @"mvc.1.0.view", @"/Views/Shared/ResultView.cshtml")]
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
#line 1 "C:\Users\appac\Desktop\прога2\lab2\Views\_ViewImports.cshtml"
using lab2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\appac\Desktop\прога2\lab2\Views\_ViewImports.cshtml"
using lab2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03d51ca94ec6c7aebaa6bbb10385390c25bc3f76", @"/Views/Shared/ResultView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35562084dafa27f7016e0bcf8256da711a5019f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ResultView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\appac\Desktop\прога2\lab2\Views\Shared\ResultView.cshtml"
  
    ViewData["Title"] = "Result";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Result</h1>\n<br>\n<h4>");
#nullable restore
#line 7 "C:\Users\appac\Desktop\прога2\lab2\Views\Shared\ResultView.cshtml"
Write(ViewData["result"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n");
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
