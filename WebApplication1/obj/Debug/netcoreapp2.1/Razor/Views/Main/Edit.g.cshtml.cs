#pragma checksum "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38b952ad21d36d83384adddbdf616f6a7639a7e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Edit), @"mvc.1.0.view", @"/Views/Main/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/Edit.cshtml", typeof(AspNetCore.Views_Main_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38b952ad21d36d83384adddbdf616f6a7639a7e1", @"/Views/Main/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.UserTestMapping>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TestAthleteDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:right; text-decoration-color:crimson"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PutEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteAthlete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(89, 19, true);
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n");
            EndContext();
            BeginContext(108, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99f85631b3c04b9f93c94f684a5fc464", async() => {
                BeginContext(223, 5, true);
                WriteLiteral("close");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 9 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Edit.cshtml"
                                     WriteLiteral(Model.TestId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(232, 96, true);
            WriteLiteral("\r\n<hr />\r\n\r\n\r\n<div class=\"row\" style=\"align-items:center\">\r\n    <div class=\"col-md-4\">\r\n        ");
            EndContext();
            BeginContext(328, 1410, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21df8497d9d74952a1fb401c205a4398", async() => {
                BeginContext(355, 157, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label for=\"AName\" style=\"text-align:center\"> Name </label>\r\n                <br />\r\n                ");
                EndContext();
                BeginContext(513, 16, false);
#line 19 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Edit.cshtml"
           Write(Model.Users.Name);

#line default
#line hidden
                EndContext();
                BeginContext(529, 24, true);
                WriteLiteral("\r\n            </div>\r\n\r\n");
                EndContext();
#line 22 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Edit.cshtml"
             if (Model.CTDistance == null)
            {

#line default
#line hidden
                BeginContext(612, 191, true);
                WriteLiteral("                <div>\r\n                    <label for=\"STTime\" style=\"text-align:center\"> Time taken </label>\r\n                    <br />\r\n                    <input id=\"STTime\" name=\"STTime\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 803, "\"", 824, 1);
#line 27 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Edit.cshtml"
WriteAttributeValue("", 811, Model.STTime, 811, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(825, 29, true);
                WriteLiteral(" />\r\n                </div>\r\n");
                EndContext();
#line 29 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Edit.cshtml"
            }
            else
            {

#line default
#line hidden
                BeginContext(902, 201, true);
                WriteLiteral("                <div>\r\n                    <label for=\"CTDistance\" style=\"text-align:center\"> Distance </label>\r\n                    <br />\r\n                    <input id=\"CTDistance\" name=\"CTDistance\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1103, "\"", 1128, 1);
#line 35 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Edit.cshtml"
WriteAttributeValue("", 1111, Model.CTDistance, 1111, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1129, 29, true);
                WriteLiteral(" />\r\n                </div>\r\n");
                EndContext();
#line 37 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Edit.cshtml"
            }

#line default
#line hidden
                BeginContext(1173, 51, true);
                WriteLiteral("            <div hidden=\"hidden\">\r\n                ");
                EndContext();
                BeginContext(1225, 21, false);
#line 39 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Edit.cshtml"
           Write(Html.EditorForModel());

#line default
#line hidden
                EndContext();
                BeginContext(1246, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1265, 33, false);
#line 40 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Edit.cshtml"
           Write(Html.EditorFor(model => model.ID));

#line default
#line hidden
                EndContext();
                BeginContext(1298, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1317, 37, false);
#line 41 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Edit.cshtml"
           Write(Html.EditorFor(model => model.TestId));

#line default
#line hidden
                EndContext();
                BeginContext(1354, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1373, 37, false);
#line 42 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Edit.cshtml"
           Write(Html.EditorFor(model => model.UserId));

#line default
#line hidden
                EndContext();
                BeginContext(1410, 116, true);
                WriteLiteral("\r\n            </div>\r\n            <br />\r\n            <div>\r\n                <button type=\"submit\">submit</button>\r\n");
                EndContext();
                BeginContext(1703, 28, true);
                WriteLiteral("            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1738, 45, true);
            WriteLiteral("\r\n        <br />\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(1783, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27b33c56fa16432c848c6a14c6f4945d", async() => {
                BeginContext(1862, 24, true);
                WriteLiteral("DELETE ATHLETE FROM TEST");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\Edit.cshtml"
                                            WriteLiteral(Model.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1890, 40, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
