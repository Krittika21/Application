#pragma checksum "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\AddAthlete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f95ee8ba725689b610e3cd7eb56a22464b810d28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_AddAthlete), @"mvc.1.0.view", @"/Views/Main/AddAthlete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/AddAthlete.cshtml", typeof(AspNetCore.Views_Main_AddAthlete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f95ee8ba725689b610e3cd7eb56a22464b810d28", @"/Views/Main/AddAthlete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_AddAthlete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication1.Models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TestAthleteDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:right; text-decoration-color:crimson"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewAthlete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\AddAthlete.cshtml"
   
    var fetchTime = (UserTestMapping)ViewBag.testMap;

#line default
#line hidden
#line 5 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\AddAthlete.cshtml"
  
    ViewData["Title"] = "AddAthlete";

#line default
#line hidden
            BeginContext(158, 28, true);
            WriteLiteral("\r\n<h2>CREATE NEW TEST</h2>\r\n");
            EndContext();
            BeginContext(186, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "750683493ce94951b0c70bf63820ffbd", async() => {
                BeginContext(273, 5, true);
                WriteLiteral("close");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(282, 12, true);
            WriteLiteral("\r\n<hr />\r\n\r\n");
            EndContext();
#line 13 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\AddAthlete.cshtml"
 if(@ViewBag.Name == "100m Sprint Test")
{

#line default
#line hidden
            BeginContext(339, 94, true);
            WriteLiteral("    <div class=\"row\" style=\"align-items:center\">\r\n        <div class=\"col-md-4\">\r\n            ");
            EndContext();
            BeginContext(433, 1036, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c5147a2d5a943058d505fc019aaf722", async() => {
                BeginContext(463, 234, true);
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <label for=\"AName\" style=\"text-align:center\"> Name </label>\r\n                    <br />\r\n                    <select id=\"AName\" name=\"AName\" style=\"align-items:center\">\r\n");
                EndContext();
#line 22 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\AddAthlete.cshtml"
                         foreach (var item in Model)
                        {
                            

#line default
#line hidden
#line 24 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\AddAthlete.cshtml"
                             if (item.UserRole.Equals(WebApplication1.Models.UserRole.Athlete))
                            {

#line default
#line hidden
                BeginContext(906, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(938, 27, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09476229142f4fc180f695d843eadbab", async() => {
                    BeginContext(947, 9, false);
#line 26 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\AddAthlete.cshtml"
                                   Write(item.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(965, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 27 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\AddAthlete.cshtml"
                            }

#line default
#line hidden
#line 27 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\AddAthlete.cshtml"
                             
                        }

#line default
#line hidden
                BeginContext(1025, 437, true);
                WriteLiteral(@"                    </select>
                </div>
                <div>
                    <label for=""STTime"" style=""text-align:center""> Time taken </label>
                    <br />
                    <input id=""STTime"" name=""STTime"" />
                </div>
                <br />
                <div>
                    <button class=""btn-default"" type=""submit"">Create</button>
                </div>
            ");
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
            BeginContext(1469, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 43 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\AddAthlete.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1511, 94, true);
            WriteLiteral("    <div class=\"row\" style=\"align-items:center\">\r\n        <div class=\"col-md-4\">\r\n            ");
            EndContext();
            BeginContext(1605, 1046, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b6d03be18d24f40acd56577cb26012d", async() => {
                BeginContext(1635, 234, true);
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <label for=\"AName\" style=\"text-align:center\"> Name </label>\r\n                    <br />\r\n                    <select id=\"AName\" name=\"AName\" style=\"align-items:center\">\r\n");
                EndContext();
#line 53 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\AddAthlete.cshtml"
                         foreach (var item in Model)
                        {
                            

#line default
#line hidden
#line 55 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\AddAthlete.cshtml"
                             if (item.UserRole.Equals(WebApplication1.Models.UserRole.Athlete))
                            {

#line default
#line hidden
                BeginContext(2078, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(2110, 27, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6c00fdaee83458fbe305d8968061b99", async() => {
                    BeginContext(2119, 9, false);
#line 57 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\AddAthlete.cshtml"
                                   Write(item.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2137, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 58 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\AddAthlete.cshtml"
                            }

#line default
#line hidden
#line 58 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\AddAthlete.cshtml"
                             
                        }

#line default
#line hidden
                BeginContext(2197, 447, true);
                WriteLiteral(@"                    </select>
                </div>
                <div>
                    <label for=""CTDistance"" style=""text-align:center""> Distance </label>
                    <br />
                    <input id=""CTDistance"" name=""CTDistance"" />
                </div>
                <br />
                <div>
                    <button class=""btn-default"" type=""submit"">Create</button>
                </div>
            ");
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
            BeginContext(2651, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 74 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\AddAthlete.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication1.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
