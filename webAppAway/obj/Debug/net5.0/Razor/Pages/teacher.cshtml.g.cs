#pragma checksum "/home/jens/js_challenges/2.The-Hills/dotnet/webApp-project-dotnet/webAppAway/Pages/teacher.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bacdec5bde700655ffc10a5467cc18dc896efe7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(webAppAway.Pages.Pages_teacher), @"mvc.1.0.razor-page", @"/Pages/teacher.cshtml")]
namespace webAppAway.Pages
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
#line 1 "/home/jens/js_challenges/2.The-Hills/dotnet/webApp-project-dotnet/webAppAway/Pages/_ViewImports.cshtml"
using webAppAway;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/jens/js_challenges/2.The-Hills/dotnet/webApp-project-dotnet/webAppAway/Pages/teacher.cshtml"
using webAppAway.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bacdec5bde700655ffc10a5467cc18dc896efe7", @"/Pages/teacher.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"386e5ecc9a0a07d12408f3b2a022171ad4f719e1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_teacher : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table>\r\n");
#nullable restore
#line 7 "/home/jens/js_challenges/2.The-Hills/dotnet/webApp-project-dotnet/webAppAway/Pages/teacher.cshtml"
     foreach(var teacher in Model.teacherList)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n        <td>");
#nullable restore
#line 10 "/home/jens/js_challenges/2.The-Hills/dotnet/webApp-project-dotnet/webAppAway/Pages/teacher.cshtml"
       Write(teacher.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 11 "/home/jens/js_challenges/2.The-Hills/dotnet/webApp-project-dotnet/webAppAway/Pages/teacher.cshtml"
           Write(teacher.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 12 "/home/jens/js_challenges/2.The-Hills/dotnet/webApp-project-dotnet/webAppAway/Pages/teacher.cshtml"
           Write(teacher.ClassId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>                 \r\n");
#nullable restore
#line 14 "/home/jens/js_challenges/2.The-Hills/dotnet/webApp-project-dotnet/webAppAway/Pages/teacher.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<webAppAway.Pages.teacherModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<webAppAway.Pages.teacherModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<webAppAway.Pages.teacherModel>)PageContext?.ViewData;
        public webAppAway.Pages.teacherModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591