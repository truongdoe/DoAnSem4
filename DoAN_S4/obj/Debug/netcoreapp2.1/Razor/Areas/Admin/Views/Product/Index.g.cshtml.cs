#pragma checksum "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c895c8552c0f8cd07f10cddeb27208aece7b77c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Product/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Product_Index))]
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
#line 1 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\_ViewImports.cshtml"
using DoAN_S4;

#line default
#line hidden
#line 2 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\_ViewImports.cshtml"
using DoAN_S4.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c895c8552c0f8cd07f10cddeb27208aece7b77c", @"/Areas/Admin/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92fc87e7198ec4a2fa639f01f342e5b8ac3cc44c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoAN_S4.Models.DataModel.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline ml-lg-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(161, 468, true);
            WriteLiteral(@"

<div class=""container-fluid"">

    <!-- Page Heading -->
    <h1 class=""h3 mb-2 text-gray-800"">Sản Phẩm</h1>

    <!-- DataTales Example -->
    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">Danh sách Sản Phẩm</h6>
        </div>

        <div class=""page-header row"" style=""padding-top:10px"">
            <div class=""col-md-12"" style=""display: flex;"">
                ");
            EndContext();
            BeginContext(629, 444, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15c69a3d4de14b6dab464bddba56ad6e", async() => {
                BeginContext(689, 377, true);
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
            BeginContext(1073, 1064, true);
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
                            <th class=""text-center align-middle"">Images</th>
                            <th class=""text-center align-middle"">Quantity</th>
                            <th class=""text-center align-middle"">Id_Category</th>
                            <th class=""text-center align-middle"">Price</th>
                            <th class=""text-center align-middle"">Content</th>
                            <th class=""text-center align-middle"">Status</th>
                            <th></th>
                            <th></th>
                        </tr>
                   ");
            WriteLiteral(" </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 49 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(2218, 108, true);
            WriteLiteral("                        <tr>\r\n                            <td class=\"text-center align-middle\" scope=\"row\"> ");
            EndContext();
            BeginContext(2327, 38, false);
#line 52 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\Index.cshtml"
                                                                         Write(Html.DisplayFor(modelItem => item._id));

#line default
#line hidden
            EndContext();
            BeginContext(2365, 85, true);
            WriteLiteral("</td>\r\n                            <td class=\"text-center align-middle\" scope=\"row\"> ");
            EndContext();
            BeginContext(2451, 46, false);
#line 53 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\Index.cshtml"
                                                                         Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(2497, 89, true);
            WriteLiteral("</td>\r\n                            <td class=\"text-center align-middle\" scope=\"row\"> <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2586, "\"", 2612, 2);
            WriteAttributeValue("", 2592, "/images/", 2592, 8, true);
#line 54 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\Index.cshtml"
WriteAttributeValue("", 2600, item.Images, 2600, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2613, 123, true);
            WriteLiteral(" width=\"100px\" alt=\"Alternate Text\" /></td>\r\n                            <td class=\"text-center align-middle\" scope=\"row\"> ");
            EndContext();
            BeginContext(2737, 43, false);
#line 55 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\Index.cshtml"
                                                                         Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(2780, 85, true);
            WriteLiteral("</td>\r\n                            <td class=\"text-center align-middle\" scope=\"row\"> ");
            EndContext();
            BeginContext(2866, 42, false);
#line 56 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\Index.cshtml"
                                                                         Write(Html.DisplayFor(modelItem => item.Id_Cate));

#line default
#line hidden
            EndContext();
            BeginContext(2908, 85, true);
            WriteLiteral("</td>\r\n                            <td class=\"text-center align-middle\" scope=\"row\"> ");
            EndContext();
            BeginContext(2994, 40, false);
#line 57 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\Index.cshtml"
                                                                         Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(3034, 85, true);
            WriteLiteral("</td>\r\n                            <td class=\"text-center align-middle\" scope=\"row\"> ");
            EndContext();
            BeginContext(3120, 42, false);
#line 58 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\Index.cshtml"
                                                                         Write(Html.DisplayFor(modelItem => item.Content));

#line default
#line hidden
            EndContext();
            BeginContext(3162, 74, true);
            WriteLiteral("</td>\r\n                            <td class=\"text-center align-middle\">\r\n");
            EndContext();
#line 60 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\Index.cshtml"
                             if (item.Status)
                            {

#line default
#line hidden
            BeginContext(3314, 51, true);
            WriteLiteral("                                <span>True</span>\r\n");
            EndContext();
#line 63 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(3461, 52, true);
            WriteLiteral("                                <span>False</span>\r\n");
            EndContext();
#line 67 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\Index.cshtml"

                            }

#line default
#line hidden
            BeginContext(3546, 150, true);
            WriteLiteral("                             </td>\r\n                            <td style=\"text-align: center; padding-top: 30px;\" >\r\n                                ");
            EndContext();
            BeginContext(3696, 198, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad430028fcaf486bb8aebc3e4b45d935", async() => {
                BeginContext(3784, 106, true);
                WriteLiteral("\r\n                                    <i class=\"fas fa-info-circle\"></i>\r\n                                ");
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
#line 71 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\Index.cshtml"
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
            BeginContext(3894, 151, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"text-align: center; padding-top: 30px;\" >\r\n                                ");
            EndContext();
            BeginContext(4045, 237, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cebddb60bdb48539922145042789bd3", async() => {
                BeginContext(4178, 100, true);
                WriteLiteral("\r\n                                    <i class=\"fas fa-trash\"></i>\r\n                                ");
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
#line 76 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\Index.cshtml"
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
            BeginContext(4282, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 81 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4377, 106, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                <p>\r\n                    Trang :\r\n");
            EndContext();
#line 86 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\Index.cshtml"
                     for (int i = 1; i < ViewBag.totalpage; i++)
                    {
                        if (i == (int)ViewBag.page)
                        {

#line default
#line hidden
            BeginContext(4652, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(4687, 1, false);
#line 90 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\Index.cshtml"
                             Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(4688, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 91 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\Index.cshtml"
                        }
                        else if (ViewBag.name != null)
                        {

#line default
#line hidden
            BeginContext(4807, 30, true);
            WriteLiteral("                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4837, "\"", 4871, 4);
            WriteAttributeValue("", 4844, "?page=", 4844, 6, true);
#line 94 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\Index.cshtml"
WriteAttributeValue("", 4850, i, 4850, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 4852, "&name=", 4852, 6, true);
#line 94 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\Index.cshtml"
WriteAttributeValue("", 4858, ViewBag.name, 4858, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4872, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(4874, 1, false);
#line 94 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\Index.cshtml"
                                                             Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(4875, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 95 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4965, 30, true);
            WriteLiteral("                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4995, "\"", 5010, 2);
            WriteAttributeValue("", 5002, "?page=", 5002, 6, true);
#line 98 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\Index.cshtml"
WriteAttributeValue("", 5008, i, 5008, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5011, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(5013, 1, false);
#line 98 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\Index.cshtml"
                                          Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(5014, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 99 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\Index.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(5070, 106, true);
            WriteLiteral("                </p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n<!-- /.container-fluid -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoAN_S4.Models.DataModel.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
