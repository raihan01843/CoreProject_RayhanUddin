#pragma checksum "C:\Users\idb_c#\Desktop\1258319\CoreProject_Raihan\Views\Transaction\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53bc25c138f8c1c8ad2a359e0823fbde85cf1d99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction_Details), @"mvc.1.0.view", @"/Views/Transaction/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Transaction/Details.cshtml", typeof(AspNetCore.Views_Transaction_Details))]
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
#line 1 "C:\Users\idb_c#\Desktop\1258319\CoreProject_Raihan\Views\_ViewImports.cshtml"
using CoreProject_Raihan;

#line default
#line hidden
#line 2 "C:\Users\idb_c#\Desktop\1258319\CoreProject_Raihan\Views\_ViewImports.cshtml"
using CoreProject_Raihan.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53bc25c138f8c1c8ad2a359e0823fbde85cf1d99", @"/Views/Transaction/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95a37ecc052f662192321f9d61409ac030a4b1a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaction_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreProject_Raihan.Models.Transaction>
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
            BeginContext(45, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\idb_c#\Desktop\1258319\CoreProject_Raihan\Views\Transaction\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(86, 126, true);
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>Transaction</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(213, 49, false);
#line 14 "C:\Users\idb_c#\Desktop\1258319\CoreProject_Raihan\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AccountNumber));

#line default
#line hidden
            EndContext();
            BeginContext(262, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(323, 45, false);
#line 17 "C:\Users\idb_c#\Desktop\1258319\CoreProject_Raihan\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.AccountNumber));

#line default
#line hidden
            EndContext();
            BeginContext(368, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(428, 51, false);
#line 20 "C:\Users\idb_c#\Desktop\1258319\CoreProject_Raihan\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BeneficiaryName));

#line default
#line hidden
            EndContext();
            BeginContext(479, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(540, 47, false);
#line 23 "C:\Users\idb_c#\Desktop\1258319\CoreProject_Raihan\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.BeneficiaryName));

#line default
#line hidden
            EndContext();
            BeginContext(587, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(647, 44, false);
#line 26 "C:\Users\idb_c#\Desktop\1258319\CoreProject_Raihan\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BankName));

#line default
#line hidden
            EndContext();
            BeginContext(691, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(752, 40, false);
#line 29 "C:\Users\idb_c#\Desktop\1258319\CoreProject_Raihan\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.BankName));

#line default
#line hidden
            EndContext();
            BeginContext(792, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(852, 45, false);
#line 32 "C:\Users\idb_c#\Desktop\1258319\CoreProject_Raihan\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SWIFTCode));

#line default
#line hidden
            EndContext();
            BeginContext(897, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(958, 41, false);
#line 35 "C:\Users\idb_c#\Desktop\1258319\CoreProject_Raihan\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.SWIFTCode));

#line default
#line hidden
            EndContext();
            BeginContext(999, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1059, 42, false);
#line 38 "C:\Users\idb_c#\Desktop\1258319\CoreProject_Raihan\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1101, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1162, 38, false);
#line 41 "C:\Users\idb_c#\Desktop\1258319\CoreProject_Raihan\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1200, 59, true);
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
            EndContext();
            BeginContext(1260, 40, false);
#line 44 "C:\Users\idb_c#\Desktop\1258319\CoreProject_Raihan\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1300, 60, true);
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
            EndContext();
            BeginContext(1361, 36, false);
#line 47 "C:\Users\idb_c#\Desktop\1258319\CoreProject_Raihan\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1397, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1439, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8f11dc0152e4c128461d317082741f7", async() => {
                BeginContext(1496, 4, true);
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
#line 52 "C:\Users\idb_c#\Desktop\1258319\CoreProject_Raihan\Views\Transaction\Details.cshtml"
                           WriteLiteral(Model.TransactionId);

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
            BeginContext(1504, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(1511, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b6603e771c44359a744ef3bf6cc6f43", async() => {
                BeginContext(1533, 12, true);
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
            BeginContext(1549, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreProject_Raihan.Models.Transaction> Html { get; private set; }
    }
}
#pragma warning restore 1591
