#pragma checksum "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "841bad788bed1ad721f6ef3045a224bba3aab72f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GoalStatus_Details), @"mvc.1.0.view", @"/Views/GoalStatus/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GoalStatus/Details.cshtml", typeof(AspNetCore.Views_GoalStatus_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"841bad788bed1ad721f6ef3045a224bba3aab72f", @"/Views/GoalStatus/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79477945a6a1409120aa7368be286ae442cb4915", @"/Views/_ViewImports.cshtml")]
    public class Views_GoalStatus_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinancialDashboard.Models.GoalStatus>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(90, 124, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>GoalStatus</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(215, 53, false);
#line 14 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NextMonthSpending));

#line default
#line hidden
            EndContext();
            BeginContext(268, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(312, 49, false);
#line 17 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayFor(model => model.NextMonthSpending));

#line default
#line hidden
            EndContext();
            BeginContext(361, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(405, 48, false);
#line 20 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DebtFreeDate));

#line default
#line hidden
            EndContext();
            BeginContext(453, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(497, 44, false);
#line 23 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayFor(model => model.DebtFreeDate));

#line default
#line hidden
            EndContext();
            BeginContext(541, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(585, 40, false);
#line 26 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(625, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(669, 36, false);
#line 29 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(705, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(749, 56, false);
#line 32 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CurrentMonthSpending));

#line default
#line hidden
            EndContext();
            BeginContext(805, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(849, 52, false);
#line 35 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayFor(model => model.CurrentMonthSpending));

#line default
#line hidden
            EndContext();
            BeginContext(901, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(945, 54, false);
#line 38 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CurrentMonthIncome));

#line default
#line hidden
            EndContext();
            BeginContext(999, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1043, 50, false);
#line 41 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayFor(model => model.CurrentMonthIncome));

#line default
#line hidden
            EndContext();
            BeginContext(1093, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1137, 46, false);
#line 44 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CashOnHand));

#line default
#line hidden
            EndContext();
            BeginContext(1183, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1227, 42, false);
#line 47 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayFor(model => model.CashOnHand));

#line default
#line hidden
            EndContext();
            BeginContext(1269, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1313, 44, false);
#line 50 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NetWorth));

#line default
#line hidden
            EndContext();
            BeginContext(1357, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1401, 40, false);
#line 53 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayFor(model => model.NetWorth));

#line default
#line hidden
            EndContext();
            BeginContext(1441, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1485, 45, false);
#line 56 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalDebt));

#line default
#line hidden
            EndContext();
            BeginContext(1530, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1574, 41, false);
#line 59 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalDebt));

#line default
#line hidden
            EndContext();
            BeginContext(1615, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1659, 51, false);
#line 62 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalCCPayments));

#line default
#line hidden
            EndContext();
            BeginContext(1710, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1754, 47, false);
#line 65 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalCCPayments));

#line default
#line hidden
            EndContext();
            BeginContext(1801, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1845, 54, false);
#line 68 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RetirementAccounts));

#line default
#line hidden
            EndContext();
            BeginContext(1899, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1943, 50, false);
#line 71 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayFor(model => model.RetirementAccounts));

#line default
#line hidden
            EndContext();
            BeginContext(1993, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2037, 58, false);
#line 74 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OverallMonthlyExpenses));

#line default
#line hidden
            EndContext();
            BeginContext(2095, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2139, 54, false);
#line 77 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayFor(model => model.OverallMonthlyExpenses));

#line default
#line hidden
            EndContext();
            BeginContext(2193, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2237, 56, false);
#line 80 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OverallMonthlyIncome));

#line default
#line hidden
            EndContext();
            BeginContext(2293, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2337, 52, false);
#line 83 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayFor(model => model.OverallMonthlyIncome));

#line default
#line hidden
            EndContext();
            BeginContext(2389, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2433, 55, false);
#line 86 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ThreeMonthsExpenses));

#line default
#line hidden
            EndContext();
            BeginContext(2488, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2532, 51, false);
#line 89 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayFor(model => model.ThreeMonthsExpenses));

#line default
#line hidden
            EndContext();
            BeginContext(2583, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2627, 53, false);
#line 92 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ThreeMonthsIncome));

#line default
#line hidden
            EndContext();
            BeginContext(2680, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2724, 49, false);
#line 95 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayFor(model => model.ThreeMonthsIncome));

#line default
#line hidden
            EndContext();
            BeginContext(2773, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2817, 58, false);
#line 98 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProjectedMonthlyIncome));

#line default
#line hidden
            EndContext();
            BeginContext(2875, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2919, 54, false);
#line 101 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProjectedMonthlyIncome));

#line default
#line hidden
            EndContext();
            BeginContext(2973, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3020, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00ab6989d0b34bc793d3e8d13b592c9d", async() => {
                BeginContext(3066, 4, true);
                WriteLiteral("Edit");
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
#line 106 "C:\Users\linma\source\repos\FinancialSitch\FinancialDashboard\Views\GoalStatus\Details.cshtml"
                           WriteLiteral(Model.ID);

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
            BeginContext(3074, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3082, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b87eb5882ed64e09b7e6b2edbd02f507", async() => {
                BeginContext(3104, 12, true);
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
            BeginContext(3120, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinancialDashboard.Models.GoalStatus> Html { get; private set; }
    }
}
#pragma warning restore 1591
