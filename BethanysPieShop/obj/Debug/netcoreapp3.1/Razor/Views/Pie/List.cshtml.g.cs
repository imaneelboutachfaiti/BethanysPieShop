#pragma checksum "C:\Ldev\BethanysPieShop\BethanysPieShop\Views\Pie\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f73ec6964ddd0b30b37773c5746a4aeebcc90f62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pie_List), @"mvc.1.0.view", @"/Views/Pie/List.cshtml")]
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
#line 1 "C:\Ldev\BethanysPieShop\BethanysPieShop\Views\_ViewImports.cshtml"
using BethanysPieShop.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f73ec6964ddd0b30b37773c5746a4aeebcc90f62", @"/Views/Pie/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"482eca9a00fbd64a8a8e04b34361226e2613b155", @"/Views/_ViewImports.cshtml")]
    public class Views_Pie_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PiesListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n    <h1>");
#nullable restore
#line 3 "C:\Ldev\BethanysPieShop\BethanysPieShop\Views\Pie\List.cshtml"
   Write(Model.CurrentCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 4 "C:\Ldev\BethanysPieShop\BethanysPieShop\Views\Pie\List.cshtml"
     foreach (var pie in Model.Pies)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-sm-4 col-lg-4 col-md-4\" >\r\n        <div class=\"thumbnail\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 201, "\"", 229, 1);
#nullable restore
#line 7 "C:\Ldev\BethanysPieShop\BethanysPieShop\Views\Pie\List.cshtml"
WriteAttributeValue("", 207, pie.ImageThumbnailUrl, 207, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 230, "\"", 236, 0);
            EndWriteAttribute();
            WriteLiteral("/>\r\n            <div class=\"caption\">\r\n                <h3 class=\"pull-right\"> ");
#nullable restore
#line 9 "C:\Ldev\BethanysPieShop\BethanysPieShop\Views\Pie\List.cshtml"
                                   Write(pie.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <h3>\r\n                    <a>");
#nullable restore
#line 11 "C:\Ldev\BethanysPieShop\BethanysPieShop\Views\Pie\List.cshtml"
                  Write(pie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </h3>\r\n                <p> ");
#nullable restore
#line 13 "C:\Ldev\BethanysPieShop\BethanysPieShop\Views\Pie\List.cshtml"
               Write(pie.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>    \r\n    </div>\r\n");
#nullable restore
#line 17 "C:\Ldev\BethanysPieShop\BethanysPieShop\Views\Pie\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PiesListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
