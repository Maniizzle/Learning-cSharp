#pragma checksum "C:\Users\OLAMIDE ONAKOYA\source\repos\MyAspTestWork\MyAspTestWork\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abdf6559643d3a314dd03f348698cdae2d707f80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Home/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Home_Index))]
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
#line 1 "C:\Users\OLAMIDE ONAKOYA\source\repos\MyAspTestWork\MyAspTestWork\Areas\Admin\Views\_ViewImports.cshtml"
using MyAspTestWork.Areas.Admin.Controllers;

#line default
#line hidden
#line 2 "C:\Users\OLAMIDE ONAKOYA\source\repos\MyAspTestWork\MyAspTestWork\Areas\Admin\Views\_ViewImports.cshtml"
using MyAspTestWork.Areas.Admin;

#line default
#line hidden
#line 3 "C:\Users\OLAMIDE ONAKOYA\source\repos\MyAspTestWork\MyAspTestWork\Areas\Admin\Views\_ViewImports.cshtml"
using MyAspTestWork.Areas.Admin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abdf6559643d3a314dd03f348698cdae2d707f80", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7782b280276fc8c8d696738a150ad91af00ce24", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Person[]>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("panel-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\OLAMIDE ONAKOYA\source\repos\MyAspTestWork\MyAspTestWork\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(58, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(85, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abdf6559643d3a314dd03f348698cdae2d707f804256", async() => {
                BeginContext(91, 88, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title> Areas</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(186, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(188, 348, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abdf6559643d3a314dd03f348698cdae2d707f805531", async() => {
                BeginContext(213, 149, true);
                WriteLiteral("\r\n    <table class=\"table table-bordered table-striped table-condensed\">\r\n        <tr>\r\n        <th>Name</th>\r\n        <th>City</th>\r\n        </tr>\r\n");
                EndContext();
#line 18 "C:\Users\OLAMIDE ONAKOYA\source\repos\MyAspTestWork\MyAspTestWork\Areas\Admin\Views\Home\Index.cshtml"
         foreach(Person r in Model)
        {

#line default
#line hidden
                BeginContext(410, 22, true);
                WriteLiteral("            <tr> <td> ");
                EndContext();
                BeginContext(433, 6, false);
#line 20 "C:\Users\OLAMIDE ONAKOYA\source\repos\MyAspTestWork\MyAspTestWork\Areas\Admin\Views\Home\Index.cshtml"
                 Write(r.Name);

#line default
#line hidden
                EndContext();
                BeginContext(439, 20, true);
                WriteLiteral("</td>\r\n        <td> ");
                EndContext();
                BeginContext(460, 6, false);
#line 21 "C:\Users\OLAMIDE ONAKOYA\source\repos\MyAspTestWork\MyAspTestWork\Areas\Admin\Views\Home\Index.cshtml"
        Write(r.City);

#line default
#line hidden
                EndContext();
                BeginContext(466, 12, true);
                WriteLiteral("</td></tr>\r\n");
                EndContext();
#line 22 "C:\Users\OLAMIDE ONAKOYA\source\repos\MyAspTestWork\MyAspTestWork\Areas\Admin\Views\Home\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(489, 40, true);
                WriteLiteral("\r\n    </table>  \r\n    \r\n    \r\n    \r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(536, 21, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n</html>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Person[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
