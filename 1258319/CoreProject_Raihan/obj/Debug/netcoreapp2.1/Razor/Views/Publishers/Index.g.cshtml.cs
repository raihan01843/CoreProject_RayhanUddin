#pragma checksum "C:\Users\idb_c#\Desktop\1258319\CoreProject_Raihan\Views\Publishers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d16809edf1292c07df67433699dabc7f42088a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Publishers_Index), @"mvc.1.0.view", @"/Views/Publishers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Publishers/Index.cshtml", typeof(AspNetCore.Views_Publishers_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d16809edf1292c07df67433699dabc7f42088a6", @"/Views/Publishers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95a37ecc052f662192321f9d61409ac030a4b1a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Publishers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreProject_Raihan.Models.Publisher>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\idb_c#\Desktop\1258319\CoreProject_Raihan\Views\Publishers\Index.cshtml"
   ViewBag.Title = "Index"; 

#line default
#line hidden
            BeginContext(90, 524, true);
            WriteLiteral(@"
<div class=""row"">

    <div class=""col-md-6"" style=""margin-top:4rem; margin-left:7rem;"">
        <div id=""itemsDiv"">
        </div>
    </div>


    <div class=""col-md-4"" >
        <div id=""categoryDiv"">
            <h2 style=""text-align:center;"">Publisher Informations</h2>
            <p>
                <button type=""button"" class=""btn btn-outline-secondary btn-lg"" data-toggle=""modal"" data-target=""#categoryModal"" style=""background-color:purple"">Create New Publisher With Book</button>
            </p>
");
            EndContext();
#line 19 "C:\Users\idb_c#\Desktop\1258319\CoreProject_Raihan\Views\Publishers\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(671, 336, true);
            WriteLiteral(@"                <table class=""table table-bordered table-hover table-striped"" style=""text-align:center;"">
                    <tr>
                        <th>Publisher Name</th>

                        <th>Action</th>
                    </tr>
                    <tr>
                        <td>
                            ");
            EndContext();
            BeginContext(1008, 39, false);
#line 29 "C:\Users\idb_c#\Desktop\1258319\CoreProject_Raihan\Views\Publishers\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1047, 123, true);
            WriteLiteral("\r\n\r\n                        </td>\r\n\r\n                        <td>\r\n                            <button class=\"btn btn-info\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1170, "\"", 1200, 3);
            WriteAttributeValue("", 1180, "getDetails(", 1180, 11, true);
#line 34 "C:\Users\idb_c#\Desktop\1258319\CoreProject_Raihan\Views\Publishers\Index.cshtml"
WriteAttributeValue("", 1191, item.ID, 1191, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1199, ")", 1199, 1, true);
            EndWriteAttribute();
            BeginContext(1201, 59, true);
            WriteLiteral(">Details</button>&nbsp;&nbsp;\r\n                            ");
            EndContext();
            BeginContext(1260, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35078b8cc76a4e358c6369df95c74a38", async() => {
                BeginContext(1330, 6, true);
                WriteLiteral("Delete");
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
#line 35 "C:\Users\idb_c#\Desktop\1258319\CoreProject_Raihan\Views\Publishers\Index.cshtml"
                                                     WriteLiteral(item.ID);

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
            BeginContext(1340, 86, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                </table>\r\n");
            EndContext();
#line 39 "C:\Users\idb_c#\Desktop\1258319\CoreProject_Raihan\Views\Publishers\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1441, 230, true);
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n<div class=\"modal fade\" id=\"categoryModal\" tabindex=\"-1\" aria-labelledby=\"categoryModalLabel\" aria-hidden=\"true\">\r\n    <div class=\"modal-dialog\">\r\n        <div class=\"modal-content\">\r\n");
            EndContext();
#line 51 "C:\Users\idb_c#\Desktop\1258319\CoreProject_Raihan\Views\Publishers\Index.cshtml"
               Html.RenderPartialAsync("Create", new CoreProject_Raihan.Models.Publisher()); 

#line default
#line hidden
            BeginContext(1767, 58, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1843, 210, true);
                WriteLiteral("\r\n\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\"#categoryDiv\").height($(window).height() * .80);\r\n            $(\"#itemsDiv\").height($(window).height() * .70);\r\n\r\n            if (isNaN(");
                EndContext();
                BeginContext(2054, 14, false);
#line 73 "C:\Users\idb_c#\Desktop\1258319\CoreProject_Raihan\Views\Publishers\Index.cshtml"
                 Write(TempData["id"]);

#line default
#line hidden
                EndContext();
                BeginContext(2068, 43, true);
                WriteLiteral(") == false) {\r\n                var link = \'");
                EndContext();
                BeginContext(2112, 78, false);
#line 74 "C:\Users\idb_c#\Desktop\1258319\CoreProject_Raihan\Views\Publishers\Index.cshtml"
                       Write(Url.Action("GetCategoryWiseItems", "Publishers", new { id = @TempData["id"] }));

#line default
#line hidden
                EndContext();
                BeginContext(2190, 1603, true);
                WriteLiteral(@"';
                $(""#itemsDiv"").load(link);
            }

            $('#categoryModal').on('shown.bs.modal', function () {
                $('#Name').trigger('focus');
            });

            $('#categoryModal').on('hidden.bs.modal', function (event) {
                $(""input[type=text]"").val("""");
                $(""input[type=number]"").val("""");
                $(""input[type=datetime-local]"").val("""");
                $('#sl').val('0');



                $(""div"").each(function () {
                    if (parseInt(this.id) > 0) {
                        this.remove();
                    }
                })
            });

            $('#addModelButton').on('click', function () {
                var present_sl = parseInt($('#sl').val());
                var next_sl = parseInt(present_sl) + 1;
                var next_item = '<div id=""' + next_sl + '"">' + $('#' + present_sl).html() + '</div>';
                next_item = next_item.split('_' + present_sl.toString()).join");
                WriteLiteral(@"('_' + next_sl.toString());
                next_item = next_item.split('[' + present_sl.toString() + ']').join('[' + next_sl.toString() + ']');
                $('#' + present_sl).after(next_item);
                $('#sl').val(next_sl);
            });

            $('#itemModal').on('hidden.bs.modal', function (event) {
                $(""input[type=text]"").val("""");
                $(""input[type=number]"").val("""");
                $(""input[type=datetime-local]"").val("""");
            });
        });


        function getDetails(e) {
            var link = '");
                EndContext();
                BeginContext(3794, 67, false);
#line 116 "C:\Users\idb_c#\Desktop\1258319\CoreProject_Raihan\Views\Publishers\Index.cshtml"
                   Write(Url.Action("GetCategoryWiseItems", "Publishers", new { id = "-1" }));

#line default
#line hidden
                EndContext();
                BeginContext(3861, 717, true);
                WriteLiteral(@"';
            link = link.replace(""-1"", e);
            $(""#itemsDiv"").load(link);
        }

        var loadImage = function (event) {
            if (event.target.files && event.target.files[0]) {
                var img = document.getElementById('itemImage');
                img.src = URL.createObjectURL(event.target.files[0]);
            }
        }

        var changeImage = function (obj, event) {
            if (event.target.files && event.target.files[0]) {
                console.log(obj.dataset.tag);
                var img = document.getElementById(obj.dataset.tag);
                img.src = URL.createObjectURL(event.target.files[0]);
            }
        }

    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreProject_Raihan.Models.Publisher>> Html { get; private set; }
    }
}
#pragma warning restore 1591