#pragma checksum "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Color\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7f02127cd2a6a4fe3bad36fbf8e532f41c2e20a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Color_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Color/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Color/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Color_Index))]
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
#line 1 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\_ViewImports.cshtml"
using DoAN_S4;

#line default
#line hidden
#line 2 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\_ViewImports.cshtml"
using DoAN_S4.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7f02127cd2a6a4fe3bad36fbf8e532f41c2e20a", @"/Areas/Admin/Views/Color/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92fc87e7198ec4a2fa639f01f342e5b8ac3cc44c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Color_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoAN_S4.Models.DataModel.Color>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline ml-lg-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Color", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure ?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Color\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(159, 468, true);
            WriteLiteral(@"

<div class=""container-fluid"">

    <!-- Page Heading -->
    <h1 class=""h3 mb-2 text-gray-800"">Bảng Màu</h1>

    <!-- DataTales Example -->
    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">Danh sách Bảng Màu</h6>
        </div>

        <div class=""page-header row"" style=""padding-top:10px"">
            <div class=""col-md-12"" style=""display: flex;"">
                ");
            EndContext();
            BeginContext(627, 444, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "991d89d73c3247a0a9599badced42fdc", async() => {
                BeginContext(687, 377, true);
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label class=""sr-only"" for="""">label</label>
                        <input class=""form-control"" name=""name"" placeholder=""Search"" value="""">
                    </div>
                    <button type=""submit"" class=""btn btn-icon btn-default mr-1""><i class=""fas fa-check""> </i></button>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1071, 667, true);
            WriteLiteral(@"
            </div>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th class=""text-center align-middle"">#</th>
                            <th class=""text-center align-middle"">Name</th>
                            <th class=""text-center align-middle"">Status</th>
                            <th></th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 44 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Color\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1819, 116, true);
            WriteLiteral("                            <tr>\r\n                                <td class=\"text-center align-middle\" scope=\"row\"> ");
            EndContext();
            BeginContext(1936, 38, false);
#line 47 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Color\Index.cshtml"
                                                                             Write(Html.DisplayFor(modelItem => item._id));

#line default
#line hidden
            EndContext();
            BeginContext(1974, 89, true);
            WriteLiteral("</td>\r\n                                <td class=\"text-center align-middle\" scope=\"row\"> ");
            EndContext();
            BeginContext(2064, 44, false);
#line 48 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Color\Index.cshtml"
                                                                             Write(Html.DisplayFor(modelItem => item.ColorName));

#line default
#line hidden
            EndContext();
            BeginContext(2108, 78, true);
            WriteLiteral("</td>\r\n                                <td class=\"text-center align-middle\">\r\n");
            EndContext();
#line 50 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Color\Index.cshtml"
                                     if (item.Status)
                                    {

#line default
#line hidden
            BeginContext(2280, 59, true);
            WriteLiteral("                                        <span>True</span>\r\n");
            EndContext();
#line 53 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Color\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(2459, 60, true);
            WriteLiteral("                                        <span>False</span>\r\n");
            EndContext();
#line 57 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Color\Index.cshtml"

                                    }

#line default
#line hidden
            BeginContext(2560, 160, true);
            WriteLiteral("                                </td>\r\n                                <td style=\"text-align: center; padding-top: 30px;\">\r\n                                    ");
            EndContext();
            BeginContext(2720, 204, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ce64d8c322747ea9e16eee42f65e0f9", async() => {
                BeginContext(2806, 114, true);
                WriteLiteral("\r\n                                        <i class=\"fas fa-info-circle\"></i>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Color\Index.cshtml"
                                                                                                   WriteLiteral(item._id);

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
            BeginContext(2924, 162, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td style=\"text-align: center; padding-top: 30px;\">\r\n                                    ");
            EndContext();
            BeginContext(3086, 243, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3b02c48659a4044a54737f1479e8e63", async() => {
                BeginContext(3217, 108, true);
                WriteLiteral("\r\n                                        <i class=\"fas fa-trash\"></i>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 66 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Color\Index.cshtml"
                                                                                                     WriteLiteral(item._id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3329, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 71 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Color\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3432, 106, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                <p>\r\n                    Trang :\r\n");
            EndContext();
#line 76 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Color\Index.cshtml"
                     for (int i = 1; i < ViewBag.totalpage; i++)
                    {
                        if (i == (int)ViewBag.page)
                        {

#line default
#line hidden
            BeginContext(3707, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(3742, 1, false);
#line 80 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Color\Index.cshtml"
                             Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(3743, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 81 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Color\Index.cshtml"
                        }
                        else if (ViewBag.name != null)
                        {

#line default
#line hidden
            BeginContext(3862, 30, true);
            WriteLiteral("                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3892, "\"", 3926, 4);
            WriteAttributeValue("", 3899, "?page=", 3899, 6, true);
#line 84 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Color\Index.cshtml"
WriteAttributeValue("", 3905, i, 3905, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 3907, "&name=", 3907, 6, true);
#line 84 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Color\Index.cshtml"
WriteAttributeValue("", 3913, ViewBag.name, 3913, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3927, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3929, 1, false);
#line 84 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Color\Index.cshtml"
                                                             Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(3930, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 85 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Color\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4020, 30, true);
            WriteLiteral("                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4050, "\"", 4065, 2);
            WriteAttributeValue("", 4057, "?page=", 4057, 6, true);
#line 88 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Color\Index.cshtml"
WriteAttributeValue("", 4063, i, 4063, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4066, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(4068, 1, false);
#line 88 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Color\Index.cshtml"
                                          Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(4069, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 89 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Color\Index.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(4125, 80, true);
            WriteLiteral("                </p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoAN_S4.Models.DataModel.Color>> Html { get; private set; }
    }
}
#pragma warning restore 1591
