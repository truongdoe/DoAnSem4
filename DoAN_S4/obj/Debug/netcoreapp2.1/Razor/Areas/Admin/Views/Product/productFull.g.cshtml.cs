#pragma checksum "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\productFull.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6b31fa4c1eb6f39bf6c53da9a05ab2632054671"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_productFull), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/productFull.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Product/productFull.cshtml", typeof(AspNetCore.Areas_Admin_Views_Product_productFull))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6b31fa4c1eb6f39bf6c53da9a05ab2632054671", @"/Areas/Admin/Views/Product/productFull.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92fc87e7198ec4a2fa639f01f342e5b8ac3cc44c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_productFull : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoAN_S4.Areas.Admin.Models.ViewModel.productViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(75, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\productFull.cshtml"
  
    ViewData["Title"] = "productFull";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(188, 35, true);
            WriteLiteral("\r\n<h2>productFull</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(223, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bdae4483340444cb561dc7438464521", async() => {
                BeginContext(246, 10, true);
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
            BeginContext(260, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(353, 39, false);
#line 17 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\productFull.cshtml"
           Write(Html.DisplayNameFor(model => model._id));

#line default
#line hidden
            EndContext();
            BeginContext(392, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(448, 40, false);
#line 20 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\productFull.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(488, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(544, 42, false);
#line 23 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\productFull.cshtml"
           Write(Html.DisplayNameFor(model => model.Images));

#line default
#line hidden
            EndContext();
            BeginContext(586, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(642, 44, false);
#line 26 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\productFull.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(686, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(742, 48, false);
#line 29 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\productFull.cshtml"
           Write(Html.DisplayNameFor(model => model.NameCategory));

#line default
#line hidden
            EndContext();
            BeginContext(790, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(846, 41, false);
#line 32 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\productFull.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(887, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(943, 43, false);
#line 35 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\productFull.cshtml"
           Write(Html.DisplayNameFor(model => model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(986, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1042, 42, false);
#line 38 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\productFull.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1084, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 44 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\productFull.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1202, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1251, 38, false);
#line 47 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\productFull.cshtml"
           Write(Html.DisplayFor(modelItem => item._id));

#line default
#line hidden
            EndContext();
            BeginContext(1289, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1345, 39, false);
#line 50 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\productFull.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1384, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1440, 41, false);
#line 53 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\productFull.cshtml"
           Write(Html.DisplayFor(modelItem => item.Images));

#line default
#line hidden
            EndContext();
            BeginContext(1481, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1537, 43, false);
#line 56 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\productFull.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1580, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1636, 47, false);
#line 59 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\productFull.cshtml"
           Write(Html.DisplayFor(modelItem => item.NameCategory));

#line default
#line hidden
            EndContext();
            BeginContext(1683, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1739, 40, false);
#line 62 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\productFull.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1779, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1835, 42, false);
#line 65 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\productFull.cshtml"
           Write(Html.DisplayFor(modelItem => item.Content));

#line default
#line hidden
            EndContext();
            BeginContext(1877, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1933, 41, false);
#line 68 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\productFull.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1974, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2030, 65, false);
#line 71 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\productFull.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2095, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2116, 71, false);
#line 72 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\productFull.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2187, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2208, 69, false);
#line 73 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\productFull.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2277, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 76 "C:\Users\Truongdoe\OneDrive\Desktop\ĐỒ án sem 4\DoAN_S4\DoAN_S4\Areas\Admin\Views\Product\productFull.cshtml"
}

#line default
#line hidden
            BeginContext(2316, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoAN_S4.Areas.Admin.Models.ViewModel.productViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
