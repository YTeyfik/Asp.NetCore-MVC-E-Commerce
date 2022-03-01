#pragma checksum "C:\Users\teyo_\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5c4909b38cd0d4e59a912b9eb83262c2bdbec29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ProductList), @"mvc.1.0.view", @"/Views/Admin/ProductList.cshtml")]
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
#nullable restore
#line 2 "C:\Users\teyo_\source\repos\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\teyo_\source\repos\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\teyo_\source\repos\ShopApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5c4909b38cd0d4e59a912b9eb83262c2bdbec29", @"/Views/Admin/ProductList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b27f32906909110c3f79d88021a739c7b1a116a", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ProductList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/productdelete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\teyo_\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
  
    var products=Model.Products;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <h1>Admin Products</h1><hr />
        <a href=""/admin/products/create"" class=""btn btn-outline-success"">Add Products</a>
        <table class=""table table-striped mt-3"">
            <thead>
                <tr>
                    <th scope=""col"">Id</th>
                    <th scope=""col"">Image</th>
                    <th scope=""col"">Name</th>
                    <th scope=""col"">Price</th>
                    <th scope=""col"">Home</th>
                    <th scope=""col"">Approved</th>
                    <th scope=""col"">Action</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 24 "C:\Users\teyo_\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
                 if (products.Count > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\teyo_\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
                     foreach(var item in products)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\teyo_\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
                       Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a5c4909b38cd0d4e59a912b9eb83262c2bdbec296720", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 996, "~/images/", 996, 9, true);
#nullable restore
#line 30 "C:\Users\teyo_\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
AddHtmlAttributeValue("", 1005, item.ImageUrl, 1005, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\teyo_\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\teyo_\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 34 "C:\Users\teyo_\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
                             if(@item.IsHome)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fa-solid fa-square-check\"></i>\r\n");
#nullable restore
#line 37 "C:\Users\teyo_\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fa-solid fa-square-xmark\"></i>\r\n");
#nullable restore
#line 41 "C:\Users\teyo_\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 44 "C:\Users\teyo_\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
                             if(@item.IsApproved)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fa-solid fa-square-check\"></i>\r\n");
#nullable restore
#line 47 "C:\Users\teyo_\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fa-solid fa-square-xmark\"></i>\r\n");
#nullable restore
#line 51 "C:\Users\teyo_\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2024, "\"", 2062, 2);
            WriteAttributeValue("", 2031, "/admin/products/", 2031, 16, true);
#nullable restore
#line 54 "C:\Users\teyo_\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
WriteAttributeValue("", 2047, item.ProductId, 2047, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info btn-sm mr-2\">Edit</a>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5c4909b38cd0d4e59a912b9eb83262c2bdbec2911441", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"ProductId\"");
                BeginWriteAttribute("value", " value=\"", 2288, "\"", 2311, 1);
#nullable restore
#line 56 "C:\Users\teyo_\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
WriteAttributeValue("", 2296, item.ProductId, 2296, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                                <button type=\"submit\" class=\"btn btn-outline-danger btn-sm mr-2\">Delete</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            \r\n                        </td>\r\n                    </tr>  \r\n");
#nullable restore
#line 62 "C:\Users\teyo_\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\teyo_\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h3 class=\"alert alert-warning\">No Products</h3>\r\n");
#nullable restore
#line 67 "C:\Users\teyo_\source\repos\ShopApp\ShopApp.WebUI\Views\Admin\ProductList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591