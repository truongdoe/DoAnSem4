#pragma checksum "C:\Users\Truongdoe\OneDrive\Desktop\DoAN_S4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47b05f723bbdd622834e3ce7747374f45f31f1ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Account_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Account/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Account/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Account_Index))]
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
#line 1 "C:\Users\Truongdoe\OneDrive\Desktop\DoAN_S4\DoAN_S4\DoAN_S4\Areas\Admin\Views\_ViewImports.cshtml"
using DoAN_S4;

#line default
#line hidden
#line 2 "C:\Users\Truongdoe\OneDrive\Desktop\DoAN_S4\DoAN_S4\DoAN_S4\Areas\Admin\Views\_ViewImports.cshtml"
using DoAN_S4.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b05f723bbdd622834e3ce7747374f45f31f1ff", @"/Areas/Admin/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92fc87e7198ec4a2fa639f01f342e5b8ac3cc44c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoAN_S4.Models.DataModel.Account>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline ml-lg-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Truongdoe\OneDrive\Desktop\DoAN_S4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Account\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(161, 467, true);
            WriteLiteral(@"
<div class=""container-fluid"">

    <!-- Page Heading -->
    <h1 class=""h3 mb-2 text-gray-800"">Danh mục</h1>

    <!-- DataTales Example -->
    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">Danh sách tài khoản</h6>
        </div>

        <div class=""page-header row"" style=""padding-top:10px"">
            <div class=""col-md-12"" style=""display: flex;"">
                ");
            EndContext();
            BeginContext(628, 445, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbb8d7bfe16443e990be8ab83eac3f91", async() => {
                BeginContext(688, 378, true);
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label class=""sr-only"" for="""">label</label>
                        <input class=""form-control"" name=""email"" placeholder=""Search"" value="""">
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
            BeginContext(1073, 833, true);
            WriteLiteral(@"
            </div>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th class=""text-center align-middle"">Id_Account</th>
                            <th class=""text-center align-middle"">Name</th>
                            <th class=""text-center align-middle"">Email</th>
                            <th class=""text-center align-middle"">Password</th>
                            <th class=""text-center align-middle"">Phone</th>
                            <th class=""text-center align-middle"">Address</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 44 "C:\Users\Truongdoe\OneDrive\Desktop\DoAN_S4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Account\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1987, 108, true);
            WriteLiteral("                        <tr>\r\n                            <td class=\"text-center align-middle\" scope=\"row\"> ");
            EndContext();
            BeginContext(2096, 38, false);
#line 47 "C:\Users\Truongdoe\OneDrive\Desktop\DoAN_S4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Account\Index.cshtml"
                                                                         Write(Html.DisplayFor(modelItem => item._id));

#line default
#line hidden
            EndContext();
            BeginContext(2134, 85, true);
            WriteLiteral("</td>\r\n                            <td class=\"text-center align-middle\" scope=\"row\"> ");
            EndContext();
            BeginContext(2220, 39, false);
#line 48 "C:\Users\Truongdoe\OneDrive\Desktop\DoAN_S4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Account\Index.cshtml"
                                                                         Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2259, 85, true);
            WriteLiteral("</td>\r\n                            <td class=\"text-center align-middle\" scope=\"row\"> ");
            EndContext();
            BeginContext(2345, 40, false);
#line 49 "C:\Users\Truongdoe\OneDrive\Desktop\DoAN_S4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Account\Index.cshtml"
                                                                         Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2385, 85, true);
            WriteLiteral("</td>\r\n                            <td class=\"text-center align-middle\" scope=\"row\"> ");
            EndContext();
            BeginContext(2471, 43, false);
#line 50 "C:\Users\Truongdoe\OneDrive\Desktop\DoAN_S4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Account\Index.cshtml"
                                                                         Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
            EndContext();
            BeginContext(2514, 85, true);
            WriteLiteral("</td>\r\n                            <td class=\"text-center align-middle\" scope=\"row\"> ");
            EndContext();
            BeginContext(2600, 40, false);
#line 51 "C:\Users\Truongdoe\OneDrive\Desktop\DoAN_S4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Account\Index.cshtml"
                                                                         Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(2640, 85, true);
            WriteLiteral("</td>\r\n                            <td class=\"text-center align-middle\" scope=\"row\"> ");
            EndContext();
            BeginContext(2726, 42, false);
#line 52 "C:\Users\Truongdoe\OneDrive\Desktop\DoAN_S4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Account\Index.cshtml"
                                                                         Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2768, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 54 "C:\Users\Truongdoe\OneDrive\Desktop\DoAN_S4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Account\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2833, 106, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                <p>\r\n                    Trang :\r\n");
            EndContext();
#line 59 "C:\Users\Truongdoe\OneDrive\Desktop\DoAN_S4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Account\Index.cshtml"
                     for (int i = 1; i < ViewBag.totalpage; i++)
                    {
                        if (i == (int)ViewBag.page)
                        {

#line default
#line hidden
            BeginContext(3108, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(3143, 1, false);
#line 63 "C:\Users\Truongdoe\OneDrive\Desktop\DoAN_S4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Account\Index.cshtml"
                             Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(3144, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 64 "C:\Users\Truongdoe\OneDrive\Desktop\DoAN_S4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Account\Index.cshtml"
                        }
                        else if (ViewBag.name != null)
                        {

#line default
#line hidden
            BeginContext(3263, 30, true);
            WriteLiteral("                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3293, "\"", 3327, 4);
            WriteAttributeValue("", 3300, "?page=", 3300, 6, true);
#line 67 "C:\Users\Truongdoe\OneDrive\Desktop\DoAN_S4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Account\Index.cshtml"
WriteAttributeValue("", 3306, i, 3306, 2, false);

#line default
#line hidden
            WriteAttributeValue("", 3308, "&name=", 3308, 6, true);
#line 67 "C:\Users\Truongdoe\OneDrive\Desktop\DoAN_S4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Account\Index.cshtml"
WriteAttributeValue("", 3314, ViewBag.name, 3314, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3328, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3330, 1, false);
#line 67 "C:\Users\Truongdoe\OneDrive\Desktop\DoAN_S4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Account\Index.cshtml"
                                                             Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(3331, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 68 "C:\Users\Truongdoe\OneDrive\Desktop\DoAN_S4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Account\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(3421, 30, true);
            WriteLiteral("                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3451, "\"", 3466, 2);
            WriteAttributeValue("", 3458, "?page=", 3458, 6, true);
#line 71 "C:\Users\Truongdoe\OneDrive\Desktop\DoAN_S4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Account\Index.cshtml"
WriteAttributeValue("", 3464, i, 3464, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3467, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3469, 1, false);
#line 71 "C:\Users\Truongdoe\OneDrive\Desktop\DoAN_S4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Account\Index.cshtml"
                                          Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(3470, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 72 "C:\Users\Truongdoe\OneDrive\Desktop\DoAN_S4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Account\Index.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(3526, 106, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoAN_S4.Models.DataModel.Account>> Html { get; private set; }
    }
}
#pragma warning restore 1591
