#pragma checksum "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcbb49e9117b3c3a4c8f50d86ce7be5f8acab968"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_YnabLiabilityAccount_Index), @"mvc.1.0.view", @"/Views/YnabLiabilityAccount/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/YnabLiabilityAccount/Index.cshtml", typeof(AspNetCore.Views_YnabLiabilityAccount_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcbb49e9117b3c3a4c8f50d86ce7be5f8acab968", @"/Views/YnabLiabilityAccount/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79477945a6a1409120aa7368be286ae442cb4915", @"/Views/_ViewImports.cshtml")]
    public class Views_YnabLiabilityAccount_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FinancialDashboard.Models.YnabLiabilityAccount>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(111, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(140, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "133047a1d6af4aa483a26ea02f376a26", async() => {
                BeginContext(163, 10, true);
                WriteLiteral("Create New");
                EndContext();
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
            EndContext();
            BeginContext(177, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(270, 46, false);
#line 16 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PayOffDate));

#line default
#line hidden
            EndContext();
            BeginContext(316, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(372, 57, false);
#line 19 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GoalDateMonthlyAmount));

#line default
#line hidden
            EndContext();
            BeginContext(429, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(485, 50, false);
#line 22 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PayoffPriority));

#line default
#line hidden
            EndContext();
            BeginContext(535, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(591, 40, false);
#line 25 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(631, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(687, 40, false);
#line 28 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(727, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(783, 45, false);
#line 31 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.On_budget));

#line default
#line hidden
            EndContext();
            BeginContext(828, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(884, 42, false);
#line 34 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Closed));

#line default
#line hidden
            EndContext();
            BeginContext(926, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(982, 40, false);
#line 37 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Note));

#line default
#line hidden
            EndContext();
            BeginContext(1022, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1078, 43, false);
#line 40 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Balance));

#line default
#line hidden
            EndContext();
            BeginContext(1121, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1177, 51, false);
#line 43 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cleared_balance));

#line default
#line hidden
            EndContext();
            BeginContext(1228, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1284, 53, false);
#line 46 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Uncleared_balance));

#line default
#line hidden
            EndContext();
            BeginContext(1337, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1393, 53, false);
#line 49 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Transfer_payee_id));

#line default
#line hidden
            EndContext();
            BeginContext(1446, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1502, 43, false);
#line 52 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Deleted));

#line default
#line hidden
            EndContext();
            BeginContext(1545, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1601, 39, false);
#line 55 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.APR));

#line default
#line hidden
            EndContext();
            BeginContext(1640, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1696, 57, false);
#line 58 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MostRecentStatementID));

#line default
#line hidden
            EndContext();
            BeginContext(1753, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 64 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1871, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1920, 45, false);
#line 67 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PayOffDate));

#line default
#line hidden
            EndContext();
            BeginContext(1965, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2021, 56, false);
#line 70 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GoalDateMonthlyAmount));

#line default
#line hidden
            EndContext();
            BeginContext(2077, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2133, 49, false);
#line 73 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PayoffPriority));

#line default
#line hidden
            EndContext();
            BeginContext(2182, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2238, 39, false);
#line 76 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2277, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2333, 39, false);
#line 79 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
            EndContext();
            BeginContext(2372, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2428, 44, false);
#line 82 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.On_budget));

#line default
#line hidden
            EndContext();
            BeginContext(2472, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2528, 41, false);
#line 85 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Closed));

#line default
#line hidden
            EndContext();
            BeginContext(2569, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2625, 39, false);
#line 88 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Note));

#line default
#line hidden
            EndContext();
            BeginContext(2664, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2720, 42, false);
#line 91 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Balance));

#line default
#line hidden
            EndContext();
            BeginContext(2762, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2818, 50, false);
#line 94 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cleared_balance));

#line default
#line hidden
            EndContext();
            BeginContext(2868, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2924, 52, false);
#line 97 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Uncleared_balance));

#line default
#line hidden
            EndContext();
            BeginContext(2976, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3032, 52, false);
#line 100 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Transfer_payee_id));

#line default
#line hidden
            EndContext();
            BeginContext(3084, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3140, 42, false);
#line 103 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Deleted));

#line default
#line hidden
            EndContext();
            BeginContext(3182, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3238, 38, false);
#line 106 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.APR));

#line default
#line hidden
            EndContext();
            BeginContext(3276, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3332, 56, false);
#line 109 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MostRecentStatementID));

#line default
#line hidden
            EndContext();
            BeginContext(3388, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3443, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "905a99f966314212a1e96bc233b21c1f", async() => {
                BeginContext(3488, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 112 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
                                       WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3496, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3516, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bff43e9dea60445482f069ea10a85c4d", async() => {
                BeginContext(3564, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 113 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
                                          WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3575, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3595, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a30144013cef4ba585c294d4e6d84df3", async() => {
                BeginContext(3642, 6, true);
                WriteLiteral("Delete");
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
#line 114 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
                                         WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3652, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 117 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\YnabLiabilityAccount\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3691, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FinancialDashboard.Models.YnabLiabilityAccount>> Html { get; private set; }
    }
}
#pragma warning restore 1591
