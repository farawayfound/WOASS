#pragma checksum "C:\Users\guohe\Source\Repos\WOASS\WOASS\Views\Work\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d3230946014f30f50294056b96f51a8e964d16f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Work_Search), @"mvc.1.0.view", @"/Views/Work/Search.cshtml")]
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
#line 1 "C:\Users\guohe\Source\Repos\WOASS\WOASS\Views\_ViewImports.cshtml"
using WOASS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\guohe\Source\Repos\WOASS\WOASS\Views\_ViewImports.cshtml"
using WOASS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d3230946014f30f50294056b96f51a8e964d16f", @"/Views/Work/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d5c59af7093303ff60c6355a8fe19e7153ce71f", @"/Views/_ViewImports.cshtml")]
    public class Views_Work_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Work>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<hr/>\r\n");
#nullable restore
#line 4 "C:\Users\guohe\Source\Repos\WOASS\WOASS\Views\Work\Search.cshtml"
 foreach (Work w in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h3>ID: ");
#nullable restore
#line 6 "C:\Users\guohe\Source\Repos\WOASS\WOASS\Views\Work\Search.cshtml"
                   Write(w.WorkId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <h4>");
#nullable restore
#line 7 "C:\Users\guohe\Source\Repos\WOASS\WOASS\Views\Work\Search.cshtml"
               Write(w.WorkType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <h4>Customer: ");
#nullable restore
#line 8 "C:\Users\guohe\Source\Repos\WOASS\WOASS\Views\Work\Search.cshtml"
                         Write(w.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <p>");
#nullable restore
#line 9 "C:\Users\guohe\Source\Repos\WOASS\WOASS\Views\Work\Search.cshtml"
              Write(w.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 10 "C:\Users\guohe\Source\Repos\WOASS\WOASS\Views\Work\Search.cshtml"
            }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Work>> Html { get; private set; }
    }
}
#pragma warning restore 1591
