#pragma checksum "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3721dc7d1e71dc6ccb1d1ab8d85e5669a5c5e1ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Blog_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Blog/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Blog/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Blog_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3721dc7d1e71dc6ccb1d1ab8d85e5669a5c5e1ca", @"/Areas/Admin/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92fc87e7198ec4a2fa639f01f342e5b8ac3cc44c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DoAN_S4.Models.DataModel.Blog>>
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(158, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(187, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12ddbc90976d48d5a67b2b7ecd850cb5", async() => {
                BeginContext(210, 10, true);
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
            BeginContext(224, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(317, 39, false);
#line 17 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Blog\Index.cshtml"
           Write(Html.DisplayNameFor(model => model._id));

#line default
#line hidden
            EndContext();
            BeginContext(356, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(412, 43, false);
#line 20 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Blog\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Content));

#line default
#line hidden
            EndContext();
            BeginContext(455, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(511, 41, false);
#line 23 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Blog\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(552, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(608, 42, false);
#line 26 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Blog\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(650, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 32 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Blog\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(768, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(817, 38, false);
#line 35 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Blog\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item._id));

#line default
#line hidden
            EndContext();
            BeginContext(855, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(911, 42, false);
#line 38 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Blog\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Content));

#line default
#line hidden
            EndContext();
            BeginContext(953, 59, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1012, "\"", 1037, 2);
            WriteAttributeValue("", 1018, "/images/", 1018, 8, true);
#line 41 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1026, item.Image, 1026, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1038, 71, true);
            WriteLiteral(" width=\"100\" /> \r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1110, 41, false);
#line 44 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Blog\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1151, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1207, 53, false);
#line 47 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Blog\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new {  id=item._id }));

#line default
#line hidden
            EndContext();
            BeginContext(1260, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1281, 63, false);
#line 48 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Blog\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new {  /*id=item._id*/ }));

#line default
#line hidden
            EndContext();
            BeginContext(1344, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1365, 57, false);
#line 49 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Blog\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new {  id=item._id }));

#line default
#line hidden
            EndContext();
            BeginContext(1422, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 52 "D:\New folder\DoAnSem4\DoAN_S4\Areas\Admin\Views\Blog\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1461, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DoAN_S4.Models.DataModel.Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
