#pragma checksum "C:\Users\karlp\source\repos\net4.0\MVC\okta_core2\okta-dotnetcore3-webapp-quickstart\okta-dotnetcore3-mvc-webapp-quickstart-sample\Views\Home\Profile.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7ee5b113300c89db2802c810a18d8ba591954b9fc750dea1b05c313f1086679b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Profile), @"mvc.1.0.view", @"/Views/Home/Profile.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\karlp\source\repos\net4.0\MVC\okta_core2\okta-dotnetcore3-webapp-quickstart\okta-dotnetcore3-mvc-webapp-quickstart-sample\Views\_ViewImports.cshtml"
using okta_dotnetcore3_mvc_webapp_quickstart_sample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\karlp\source\repos\net4.0\MVC\okta_core2\okta-dotnetcore3-webapp-quickstart\okta-dotnetcore3-mvc-webapp-quickstart-sample\Views\_ViewImports.cshtml"
using okta_dotnetcore3_mvc_webapp_quickstart_sample.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"7ee5b113300c89db2802c810a18d8ba591954b9fc750dea1b05c313f1086679b", @"/Views/Home/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"489fb0dcd6377580c0a0d5251bb8070b9edaea85e7ef95924358f458f772f184", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<System.Security.Claims.Claim>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\karlp\source\repos\net4.0\MVC\okta_core2\okta-dotnetcore3-webapp-quickstart\okta-dotnetcore3-mvc-webapp-quickstart-sample\Views\Home\Profile.cshtml"
  
    ViewBag.Title = "View claims";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 7 "C:\Users\karlp\source\repos\net4.0\MVC\okta_core2\okta-dotnetcore3-webapp-quickstart\okta-dotnetcore3-mvc-webapp-quickstart-sample\Views\Home\Profile.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<dl class=\"dl-horizontal\">\r\n");
#nullable restore
#line 10 "C:\Users\karlp\source\repos\net4.0\MVC\okta_core2\okta-dotnetcore3-webapp-quickstart\okta-dotnetcore3-mvc-webapp-quickstart-sample\Views\Home\Profile.cshtml"
     foreach (var claim in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt");
            BeginWriteAttribute("title", " title=\"", 205, "\"", 224, 1);
#nullable restore
#line 12 "C:\Users\karlp\source\repos\net4.0\MVC\okta_core2\okta-dotnetcore3-webapp-quickstart\okta-dotnetcore3-mvc-webapp-quickstart-sample\Views\Home\Profile.cshtml"
WriteAttributeValue("", 213, claim.Type, 213, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            ");
#nullable restore
#line 13 "C:\Users\karlp\source\repos\net4.0\MVC\okta_core2\okta-dotnetcore3-webapp-quickstart\okta-dotnetcore3-mvc-webapp-quickstart-sample\Views\Home\Profile.cshtml"
       Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <button type=\"button\"\r\n                    class=\"btn btn-link btn-xs\"\r\n                    aria-label=\"Copy to clipboard\"\r\n                    title=\"Copy to clipboard\"\r\n                    data-clipboard-text=\"");
#nullable restore
#line 18 "C:\Users\karlp\source\repos\net4.0\MVC\okta_core2\okta-dotnetcore3-webapp-quickstart\okta-dotnetcore3-mvc-webapp-quickstart-sample\Views\Home\Profile.cshtml"
                                    Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                <span class=\"glyphicon glyphicon glyphicon-copy\" aria-hidden=\"true\"></span>\r\n            </button>\r\n        </dt>\r\n");
            WriteLiteral("        <dd");
            BeginWriteAttribute("id", " id=\"", 637, "\"", 681, 2);
            WriteAttributeValue("", 642, "claim-", 642, 6, true);
#nullable restore
#line 23 "C:\Users\karlp\source\repos\net4.0\MVC\okta_core2\okta-dotnetcore3-webapp-quickstart\okta-dotnetcore3-mvc-webapp-quickstart-sample\Views\Home\Profile.cshtml"
WriteAttributeValue("", 648, String.Format("{0}", claim.Type), 648, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 23 "C:\Users\karlp\source\repos\net4.0\MVC\okta_core2\okta-dotnetcore3-webapp-quickstart\okta-dotnetcore3-mvc-webapp-quickstart-sample\Views\Home\Profile.cshtml"
                                                    Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n");
#nullable restore
#line 24 "C:\Users\karlp\source\repos\net4.0\MVC\okta_core2\okta-dotnetcore3-webapp-quickstart\okta-dotnetcore3-mvc-webapp-quickstart-sample\Views\Home\Profile.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</dl>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<System.Security.Claims.Claim>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
