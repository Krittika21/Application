#pragma checksum "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6076dc3d0b0cd4568f5f169a731412f75c8f45a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Delete), @"mvc.1.0.view", @"/Views/Main/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/Delete.cshtml", typeof(AspNetCore.Views_Main_Delete))]
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
#line 1 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6076dc3d0b0cd4568f5f169a731412f75c8f45a", @"/Views/Main/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.UserTestMapping>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Delete.cshtml"
  
    var fetchDate = (TestTypeMapping)ViewBag.typeMap;

#line default
#line hidden
#line 5 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(151, 77, true);
            WriteLiteral("\r\n<h2> CONFIRM </h2>\r\n\r\n<h3>Are you sure you want to delete this test?</h3>\r\n");
            EndContext();
#line 12 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Delete.cshtml"
 if (@ViewBag.Name == "100m Sprint Test")
{

#line default
#line hidden
            BeginContext(274, 145, true);
            WriteLiteral("    <div>\r\n        <h4>UserTestMapping</h4>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            \r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(420, 42, false);
#line 20 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.STTime));

#line default
#line hidden
            EndContext();
            BeginContext(462, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(518, 38, false);
#line 23 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Delete.cshtml"
           Write(Html.DisplayFor(model => model.STTime));

#line default
#line hidden
            EndContext();
            BeginContext(556, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(612, 46, false);
#line 26 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.TestDetail));

#line default
#line hidden
            EndContext();
            BeginContext(658, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(714, 45, false);
#line 29 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Delete.cshtml"
           Write(Html.DisplayFor(model => model.TestDetail.ID));

#line default
#line hidden
            EndContext();
            BeginContext(759, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(815, 41, false);
#line 32 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Users));

#line default
#line hidden
            EndContext();
            BeginContext(856, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(912, 40, false);
#line 35 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Users.ID));

#line default
#line hidden
            EndContext();
            BeginContext(952, 48, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n");
            EndContext();
#line 39 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Delete.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1012, 131, true);
            WriteLiteral("    <div>\r\n        <h4>UserTestMapping</h4>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1144, 46, false);
#line 47 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.CTDistance));

#line default
#line hidden
            EndContext();
            BeginContext(1190, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1246, 42, false);
#line 50 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Delete.cshtml"
           Write(Html.DisplayFor(model => model.CTDistance));

#line default
#line hidden
            EndContext();
            BeginContext(1288, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1344, 49, false);
#line 53 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.FitnessRating));

#line default
#line hidden
            EndContext();
            BeginContext(1393, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1449, 45, false);
#line 56 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Delete.cshtml"
           Write(Html.DisplayFor(model => model.FitnessRating));

#line default
#line hidden
            EndContext();
            BeginContext(1494, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1550, 46, false);
#line 59 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.TestDetail));

#line default
#line hidden
            EndContext();
            BeginContext(1596, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1652, 45, false);
#line 62 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Delete.cshtml"
           Write(Html.DisplayFor(model => model.TestDetail.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1697, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1753, 41, false);
#line 65 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Users));

#line default
#line hidden
            EndContext();
            BeginContext(1794, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1850, 40, false);
#line 68 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Users.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1890, 48, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n");
            EndContext();
#line 72 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Delete.cshtml"
}

#line default
#line hidden
            BeginContext(1941, 11, true);
            WriteLiteral("<div>\r\n    ");
            EndContext();
            BeginContext(1952, 225, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4748d77b46a341d09b043a889ca926c8", async() => {
                BeginContext(1978, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1988, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ae98cb86a34d4bd49e424e4e8de11739", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 75 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2024, 78, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Yes\" class=\"btn btn-default\" >\r\n        ");
                EndContext();
                BeginContext(2102, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0150550a1da4a59a6d0f29c4cc3cd38", async() => {
                    BeginContext(2153, 2, true);
                    WriteLiteral("No");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2164, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2177, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.UserTestMapping> Html { get; private set; }
    }
}
#pragma warning restore 1591
