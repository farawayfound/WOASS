#pragma checksum "C:\Users\david\source\MSSA\Project\WOASS\WOASS\Views\Shared\WorkSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfe828cb6d45a416047a2a0e204f34b2243bfd5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_WorkSummary), @"mvc.1.0.view", @"/Views/Shared/WorkSummary.cshtml")]
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
#line 1 "C:\Users\david\source\MSSA\Project\WOASS\WOASS\Views\_ViewImports.cshtml"
using WOASS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\david\source\MSSA\Project\WOASS\WOASS\Views\_ViewImports.cshtml"
using WOASS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfe828cb6d45a416047a2a0e204f34b2243bfd5c", @"/Views/Shared/WorkSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d5c59af7093303ff60c6355a8fe19e7153ce71f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_WorkSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Work>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card card-outline-primary\">\r\n<h3>ID: ");
#nullable restore
#line 4 "C:\Users\david\source\MSSA\Project\WOASS\WOASS\Views\Shared\WorkSummary.cshtml"
   Write(Model.WorkId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<div>Order Date: ");
#nullable restore
#line 5 "C:\Users\david\source\MSSA\Project\WOASS\WOASS\Views\Shared\WorkSummary.cshtml"
            Write(Model.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Priority: ");
#nullable restore
#line 6 "C:\Users\david\source\MSSA\Project\WOASS\WOASS\Views\Shared\WorkSummary.cshtml"
          Write(Model.Priority);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Work Type: ");
#nullable restore
#line 7 "C:\Users\david\source\MSSA\Project\WOASS\WOASS\Views\Shared\WorkSummary.cshtml"
           Write(Model.WorkType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Notes: ");
#nullable restore
#line 8 "C:\Users\david\source\MSSA\Project\WOASS\WOASS\Views\Shared\WorkSummary.cshtml"
       Write(Model.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Pay Status: ");
#nullable restore
#line 9 "C:\Users\david\source\MSSA\Project\WOASS\WOASS\Views\Shared\WorkSummary.cshtml"
            Write(Model.PayStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Gear ID: ");
#nullable restore
#line 10 "C:\Users\david\source\MSSA\Project\WOASS\WOASS\Views\Shared\WorkSummary.cshtml"
         Write(Model.GearId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>User ID: ");
#nullable restore
#line 11 "C:\Users\david\source\MSSA\Project\WOASS\WOASS\Views\Shared\WorkSummary.cshtml"
         Write(Model.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<hr />\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Work> Html { get; private set; }
    }
}
#pragma warning restore 1591
