#pragma checksum "C:\Users\Dell\Documents\Tarefas Visual Studio\Tarefas C#\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f491df387ec88937371c6d31708ab3e694c23180"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SalesRecords_GroupingSearch), @"mvc.1.0.view", @"/Views/SalesRecords/GroupingSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SalesRecords/GroupingSearch.cshtml", typeof(AspNetCore.Views_SalesRecords_GroupingSearch))]
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
#line 1 "C:\Users\Dell\Documents\Tarefas Visual Studio\Tarefas C#\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc;

#line default
#line hidden
#line 2 "C:\Users\Dell\Documents\Tarefas Visual Studio\Tarefas C#\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f491df387ec88937371c6d31708ab3e694c23180", @"/Views/SalesRecords/GroupingSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70dafd425af89a5439216963c7093f2ead686e4a", @"/Views/_ViewImports.cshtml")]
    public class Views_SalesRecords_GroupingSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IGrouping<Departament, SalesRecord>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Dell\Documents\Tarefas Visual Studio\Tarefas C#\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
   ViewData["Title"] = "Grouping Search";
    DateTime minDate = DateTime.Parse(ViewData["minDate"] as string);
    DateTime maxDate = DateTime.Parse(ViewData["maxDate"] as string); 

#line default
#line hidden
            BeginContext(241, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(247, 17, false);
#line 7 "C:\Users\Dell\Documents\Tarefas Visual Studio\Tarefas C#\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(264, 85, true);
            WriteLiteral("</h2>\n\n<nav class=\"navbar navbar-inverse\">\n    <div class=\"container-fluid\">\n        ");
            EndContext();
            BeginContext(349, 648, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f491df387ec88937371c6d31708ab3e694c231805250", async() => {
                BeginContext(401, 211, true);
                WriteLiteral("\n            <div class=\"form-group\">\n                <div class=\"form-group\">\n                    <label for=\"minDate\">Min Date</label>\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 612, "", 639, 1);
#line 15 "C:\Users\Dell\Documents\Tarefas Visual Studio\Tarefas C#\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
WriteAttributeValue("", 619, ViewData["minDate"], 619, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(639, 198, true);
                WriteLiteral(">\n                </div>\n                <div class=\"form-group\">\n                    <label for=\"maxDate\">Max Date</label>\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 837, "", 864, 1);
#line 19 "C:\Users\Dell\Documents\Tarefas Visual Studio\Tarefas C#\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
WriteAttributeValue("", 844, ViewData["maxDate"], 844, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(864, 126, true);
                WriteLiteral(">\n                </div>\n            </div>\n            <button type=\"submit\" class=\"btn btn-primary\">Filter</button>\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(997, 20, true);
            WriteLiteral("\n    </div>\n</nav>\n\n");
            EndContext();
#line 27 "C:\Users\Dell\Documents\Tarefas Visual Studio\Tarefas C#\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
 foreach (var departamentGroup in Model)
{

#line default
#line hidden
            BeginContext(1060, 109, true);
            WriteLiteral("<div class=\"panel panel-primary\">\n    <div class=\"panel-heading\">\n        <h3 class=\"panel-title\">Department ");
            EndContext();
            BeginContext(1170, 25, false);
#line 31 "C:\Users\Dell\Documents\Tarefas Visual Studio\Tarefas C#\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                                      Write(departamentGroup.Key.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1195, 16, true);
            WriteLiteral(", Total sales = ");
            EndContext();
            BeginContext(1212, 64, false);
#line 31 "C:\Users\Dell\Documents\Tarefas Visual Studio\Tarefas C#\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                                                                                Write(departamentGroup.Key.TotalSales(minDate, maxDate).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1276, 548, true);
            WriteLiteral(@"</h3>
    </div>
    <div class=""panel-body"">
        <table class=""table table-striped table-hover"">
            <thead>
                <tr class=""success"">
                    <th>
                        Date
                    </th>
                    <th>
                        Amount
                    </th>
                    <th>
                        Seller
                    </th>
                    <th>
                        Status
                    </th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 52 "C:\Users\Dell\Documents\Tarefas Visual Studio\Tarefas C#\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                 foreach (var item in departamentGroup)
                {

#line default
#line hidden
            BeginContext(1898, 22, true);
            WriteLiteral("<tr>\n    <td>\n        ");
            EndContext();
            BeginContext(1921, 39, false);
#line 56 "C:\Users\Dell\Documents\Tarefas Visual Studio\Tarefas C#\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
   Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1960, 28, true);
            WriteLiteral("\n    </td>\n    <td>\n        ");
            EndContext();
            BeginContext(1989, 41, false);
#line 59 "C:\Users\Dell\Documents\Tarefas Visual Studio\Tarefas C#\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
   Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(2030, 28, true);
            WriteLiteral("\n    </td>\n    <td>\n        ");
            EndContext();
            BeginContext(2059, 46, false);
#line 62 "C:\Users\Dell\Documents\Tarefas Visual Studio\Tarefas C#\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
   Write(Html.DisplayFor(modelItem => item.Seller.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2105, 28, true);
            WriteLiteral("\n    </td>\n    <td>\n        ");
            EndContext();
            BeginContext(2134, 41, false);
#line 65 "C:\Users\Dell\Documents\Tarefas Visual Studio\Tarefas C#\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
   Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2175, 17, true);
            WriteLiteral("\n    </td>\n</tr>\n");
            EndContext();
#line 68 "C:\Users\Dell\Documents\Tarefas Visual Studio\Tarefas C#\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
}

#line default
#line hidden
            BeginContext(2194, 55, true);
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>");
            EndContext();
#line 72 "C:\Users\Dell\Documents\Tarefas Visual Studio\Tarefas C#\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IGrouping<Departament, SalesRecord>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
