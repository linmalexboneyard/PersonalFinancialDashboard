#pragma checksum "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabAccount\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a05889d57f4a101e0e1196e576d07c318c72ce9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_YnabAccount_Delete), @"mvc.1.0.view", @"/Views/YnabAccount/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/YnabAccount/Delete.cshtml", typeof(AspNetCore.Views_YnabAccount_Delete))]
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
#line 1 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\_ViewImports.cshtml"
using FinancialDashboard;

#line default
#line hidden
#line 2 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\_ViewImports.cshtml"
using FinancialDashboard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a05889d57f4a101e0e1196e576d07c318c72ce9", @"/Views/YnabAccount/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79477945a6a1409120aa7368be286ae442cb4915", @"/Views/_ViewImports.cshtml")]
    public class Views_YnabAccount_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinancialDashboard.Models.YnabAccount>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabAccount\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(90, 172, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>YnabAccount</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(263, 40, false);
#line 15 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabAccount\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(303, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(347, 36, false);
#line 18 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabAccount\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(383, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(427, 40, false);
#line 21 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabAccount\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(467, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(511, 36, false);
#line 24 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabAccount\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(547, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(591, 45, false);
#line 27 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabAccount\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.On_budget));

#line default
#line hidden
            EndContext();
            BeginContext(636, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(680, 41, false);
#line 30 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabAccount\Delete.cshtml"
       Write(Html.DisplayFor(model => model.On_budget));

#line default
#line hidden
            EndContext();
            BeginContext(721, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(765, 42, false);
#line 33 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabAccount\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Closed));

#line default
#line hidden
            EndContext();
            BeginContext(807, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(851, 38, false);
#line 36 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabAccount\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Closed));

#line default
#line hidden
            EndContext();
            BeginContext(889, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(933, 40, false);
#line 39 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabAccount\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Note));

#line default
#line hidden
            EndContext();
            BeginContext(973, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1017, 36, false);
#line 42 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabAccount\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Note));

#line default
#line hidden
            EndContext();
            BeginContext(1053, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1097, 43, false);
#line 45 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabAccount\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Balance));

#line default
#line hidden
            EndContext();
            BeginContext(1140, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1184, 39, false);
#line 48 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabAccount\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Balance));

#line default
#line hidden
            EndContext();
            BeginContext(1223, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1267, 51, false);
#line 51 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabAccount\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cleared_balance));

#line default
#line hidden
            EndContext();
            BeginContext(1318, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1362, 47, false);
#line 54 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabAccount\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cleared_balance));

#line default
#line hidden
            EndContext();
            BeginContext(1409, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1453, 53, false);
#line 57 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabAccount\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Uncleared_balance));

#line default
#line hidden
            EndContext();
            BeginContext(1506, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1550, 49, false);
#line 60 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabAccount\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Uncleared_balance));

#line default
#line hidden
            EndContext();
            BeginContext(1599, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1643, 53, false);
#line 63 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabAccount\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Transfer_payee_id));

#line default
#line hidden
            EndContext();
            BeginContext(1696, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1740, 49, false);
#line 66 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabAccount\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Transfer_payee_id));

#line default
#line hidden
            EndContext();
            BeginContext(1789, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1833, 43, false);
#line 69 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabAccount\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Deleted));

#line default
#line hidden
            EndContext();
            BeginContext(1876, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1920, 39, false);
#line 72 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabAccount\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Deleted));

#line default
#line hidden
            EndContext();
            BeginContext(1959, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2003, 39, false);
#line 75 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabAccount\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.APR));

#line default
#line hidden
            EndContext();
            BeginContext(2042, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2086, 35, false);
#line 78 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabAccount\Delete.cshtml"
       Write(Html.DisplayFor(model => model.APR));

#line default
#line hidden
            EndContext();
            BeginContext(2121, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2165, 57, false);
#line 81 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabAccount\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MostRecentStatementID));

#line default
#line hidden
            EndContext();
            BeginContext(2222, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2266, 53, false);
#line 84 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabAccount\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MostRecentStatementID));

#line default
#line hidden
            EndContext();
            BeginContext(2319, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2357, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e429e8cbdc6741f380cd028d66eb9aee", async() => {
                BeginContext(2383, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2393, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5ae72c7145264fbcb8e610fa69722502", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 89 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabAccount\Delete.cshtml"
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
                BeginContext(2429, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2513, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbfec54334104b908ca4f611724d2d9b", async() => {
                    BeginContext(2535, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2551, 6, true);
                WriteLiteral("\r\n    ");
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
            BeginContext(2564, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinancialDashboard.Models.YnabAccount> Html { get; private set; }
    }
}
#pragma warning restore 1591
