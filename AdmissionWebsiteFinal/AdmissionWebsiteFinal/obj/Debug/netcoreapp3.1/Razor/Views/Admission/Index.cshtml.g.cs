#pragma checksum "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcab5aca8305726ae32bc468368bad7c62fea29a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admission_Index), @"mvc.1.0.view", @"/Views/Admission/Index.cshtml")]
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
#line 1 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\_ViewImports.cshtml"
using AdmissionWebsiteFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\_ViewImports.cshtml"
using AdmissionWebsiteFinal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcab5aca8305726ae32bc468368bad7c62fea29a", @"/Views/Admission/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75a5eb55211a67d80d48cd85c91b956bab80c59e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admission_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AdmissionWebsiteFinal.Models.DepartmentViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Departments\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 13 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\Index.cshtml"
         foreach (var department in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 16 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\Index.cshtml"
               Write(department.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 18 "C:\Dev\AdmissionWebsite\AdmissionWebsiteFinal\AdmissionWebsiteFinal\Views\Admission\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AdmissionWebsiteFinal.Models.DepartmentViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
