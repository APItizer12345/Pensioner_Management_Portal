#pragma checksum "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e76cf30f57ad38edca838ba960b53994ec49cb5c"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e76cf30f57ad38edca838ba960b53994ec49cb5c", @"/Views/Home/PensionervaluesDisplayed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b400d5a5f87039557bf567990e57177eea7b89f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PensionervaluesDisplayed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Pension_Management_Portal.Models.PensionDetail>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
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
            WriteLiteral("\r\n<h1>PensionervaluesDisplayed</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e76cf30f57ad38edca838ba960b53994ec49cb5c3860", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml"
           Write(Html.DisplayNameFor(model => model.serialNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml"
           Write(Html.DisplayNameFor(model => model.dateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml"
           Write(Html.DisplayNameFor(model => model.pan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml"
           Write(Html.DisplayNameFor(model => model.pensionType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml"
           Write(Html.DisplayNameFor(model => model.pensionAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml"
           Write(Html.DisplayFor(modelItem => item.serialNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml"
           Write(Html.DisplayFor(modelItem => item.dateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml"
           Write(Html.DisplayFor(modelItem => item.pan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml"
           Write(Html.DisplayFor(modelItem => item.pensionType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml"
           Write(Html.DisplayFor(modelItem => item.pensionAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 53 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 54 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 57 "C:\Users\SAHIL\source\repos\Pension_Management_Portal\Views\Home\PensionervaluesDisplayed.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Pension_Management_Portal.Models.PensionDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
