#pragma checksum "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67252708ce3f9e7f0a4b9e71da390605842b7b31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PensionervaluesDisplayed), @"mvc.1.0.view", @"/Views/Home/PensionervaluesDisplayed.cshtml")]
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
#line 1 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\_ViewImports.cshtml"
using Pension_Management_Portal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\_ViewImports.cshtml"
using Pension_Management_Portal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67252708ce3f9e7f0a4b9e71da390605842b7b31", @"/Views/Home/PensionervaluesDisplayed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b400d5a5f87039557bf567990e57177eea7b89f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PensionervaluesDisplayed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pension_Management_Portal.Models.PensionDetail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml"
  
    ViewData["Title"] = "PensionervaluesDisplayed";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>\r\n    <h5>Pensioner Detail</h5>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml"
       Write(Html.DisplayNameFor(model => model.serialNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml"
       Write(Html.DisplayFor(model => model.serialNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml"
       Write(Html.DisplayNameFor(model => model.dateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml"
       Write(Html.DisplayFor(model => model.dateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml"
       Write(Html.DisplayNameFor(model => model.pan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml"
       Write(Html.DisplayFor(model => model.pan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml"
       Write(Html.DisplayNameFor(model => model.pensionType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml"
       Write(Html.DisplayFor(model => model.pensionType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml"
       Write(Html.DisplayNameFor(model => model.pensionAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml"
       Write(Html.DisplayFor(model => model.pensionAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        \r\n    </dl>\r\n</div>\r\n<div>\r\n");
            WriteLiteral("</div>\r\n<div>\r\n    <table>\r\n        <tr>\r\n            <td>\r\n\r\n                <input type=\"submit\" value=\"Get Details of Another Pensioner\" class=\"btn btn-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1665, "\"", 1744, 2);
#nullable restore
#line 54 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml"
WriteAttributeValue("", 1675, "window.location.href='"+Url.Action("PensionerValues","Home")+"'", 1675, 68, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1743, ";", 1743, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />&nbsp;&nbsp;&nbsp;\r\n\r\n\r\n\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pension_Management_Portal.Models.PensionDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
