#pragma checksum "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\CTAthletes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "225789888e244c3dfec1bb157000f8ddbb2b3f32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_CTAthletes), @"mvc.1.0.view", @"/Views/Main/CTAthletes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Main/CTAthletes.cshtml", typeof(AspNetCore.Views_Main_CTAthletes))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"225789888e244c3dfec1bb157000f8ddbb2b3f32", @"/Views/Main/CTAthletes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_CTAthletes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication1.Models.UserTestMapping>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\CTAthletes.cshtml"
  
    ViewData["Title"] = "CTAthletes";

#line default
#line hidden
            BeginContext(106, 41, true);
            WriteLiteral("\r\n<h2>CTAthletes</h2>\r\n<h2></h2>\r\n<div>\r\n");
            EndContext();
            BeginContext(181, 474, true);
            WriteLiteral(@"</div>
<div>
    <table class=""table"">
        <thead>
            <tr>
                <th style=""text-align:center"">
                    Ranking
                </th>
                <th style=""text-align:center"">
                    Distance (meter)
                </th>
                <th style=""text-align:center"">
                    Fitness Rating
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 28 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\CTAthletes.cshtml"
             foreach (var item in Model.OrderByDescending(s => s.CTDistance))
            {

#line default
#line hidden
            BeginContext(749, 98, true);
            WriteLiteral("                <tr style=\"text-align:center\">\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(848, 45, false);
#line 32 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\CTAthletes.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Users.Name));

#line default
#line hidden
            EndContext();
            BeginContext(893, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(973, 45, false);
#line 35 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\CTAthletes.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CTDistance));

#line default
#line hidden
            EndContext();
            BeginContext(1018, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1098, 48, false);
#line 38 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\CTAthletes.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FitnessRating));

#line default
#line hidden
            EndContext();
            BeginContext(1146, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 41 "C:\Users\krittika\source\repos\WebApplication1\WebApplication1\Views\Main\CTAthletes.cshtml"
            }

#line default
#line hidden
            BeginContext(1213, 367, true);
            WriteLiteral(@"        </tbody>
    </table>
    <p> ( Click on player to change data )</p>
</div>
<div>
    <button class=""btn-default"" style=""border-radius:12px; width:50%; display: flex; justify-content: center;""> ADD NEW ATHLETE TO TEST </button>
</div>
<br />
<div>
    <button class=""btn-default"" style=""border-radius:12px; width:50%""> DELETE TEST </button>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication1.Models.UserTestMapping>> Html { get; private set; }
    }
}
#pragma warning restore 1591