#pragma checksum "c:\Users\Anthony\Desktop\c#\ORM\CRUDelicious\Views\Home\DishInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5fdf0d6267a39d88348a8e9d583b3464705fd05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DishInfo), @"mvc.1.0.view", @"/Views/Home/DishInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/DishInfo.cshtml", typeof(AspNetCore.Views_Home_DishInfo))]
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
#line 1 "c:\Users\Anthony\Desktop\c#\ORM\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 2 "c:\Users\Anthony\Desktop\c#\ORM\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5fdf0d6267a39d88348a8e9d583b3464705fd05", @"/Views/Home/DishInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DishInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "c:\Users\Anthony\Desktop\c#\ORM\CRUDelicious\Views\Home\DishInfo.cshtml"
    ViewData["Title"] = @Model.Name;

#line default
#line hidden
            BeginContext(62, 145, true);
            WriteLiteral("<div class=\"mx-auto mt-4\">\r\n    <h5><a href=\"/\">Home</a></h5>\r\n    <div class=\"pb-4 border-bottom border-dark\">\r\n        <h1 class=\"text-center\">");
            EndContext();
            BeginContext(208, 10, false);
#line 8 "c:\Users\Anthony\Desktop\c#\ORM\CRUDelicious\Views\Home\DishInfo.cshtml"
                           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(218, 39, true);
            WriteLiteral("</h1>\r\n        <h3 class=\"text-center\">");
            EndContext();
            BeginContext(258, 10, false);
#line 9 "c:\Users\Anthony\Desktop\c#\ORM\CRUDelicious\Views\Home\DishInfo.cshtml"
                           Write(Model.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(268, 39, true);
            WriteLiteral("</h3>\r\n    </div>\r\n    <p class=\"mt-3\">");
            EndContext();
            BeginContext(308, 17, false);
#line 11 "c:\Users\Anthony\Desktop\c#\ORM\CRUDelicious\Views\Home\DishInfo.cshtml"
               Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(325, 65, true);
            WriteLiteral("</p>\r\n    <p class=\"mt-3\"><h5>Calories: <span class=\"text-muted\">");
            EndContext();
            BeginContext(391, 14, false);
#line 12 "c:\Users\Anthony\Desktop\c#\ORM\CRUDelicious\Views\Home\DishInfo.cshtml"
                                                      Write(Model.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(405, 65, true);
            WriteLiteral("</span></h5></p>\r\n    <p><h5>Tastiness: <span class=\"text-muted\">");
            EndContext();
            BeginContext(471, 15, false);
#line 13 "c:\Users\Anthony\Desktop\c#\ORM\CRUDelicious\Views\Home\DishInfo.cshtml"
                                          Write(Model.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(486, 52, true);
            WriteLiteral("</span></h5></p>\r\n    <div class=\"mt-4\">\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 538, "\"", 561, 2);
            WriteAttributeValue("", 545, "delete/", 545, 7, true);
#line 15 "c:\Users\Anthony\Desktop\c#\ORM\CRUDelicious\Views\Home\DishInfo.cshtml"
WriteAttributeValue("", 552, Model.id, 552, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(562, 51, true);
            WriteLiteral(" class=\"btn btn-danger mr-2\">Delete</a>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 613, "\"", 634, 2);
            WriteAttributeValue("", 620, "edit/", 620, 5, true);
#line 16 "c:\Users\Anthony\Desktop\c#\ORM\CRUDelicious\Views\Home\DishInfo.cshtml"
WriteAttributeValue("", 625, Model.id, 625, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(635, 72, true);
            WriteLiteral(" class=\"btn btn-light border border-dark\">Edit</a>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
