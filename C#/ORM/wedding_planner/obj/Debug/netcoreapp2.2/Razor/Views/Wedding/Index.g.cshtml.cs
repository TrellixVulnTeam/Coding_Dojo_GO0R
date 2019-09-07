#pragma checksum "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\Wedding\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "537c7df10a8eee9a911f4ffbced617347edb3833"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wedding_Index), @"mvc.1.0.view", @"/Views/Wedding/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Wedding/Index.cshtml", typeof(AspNetCore.Views_Wedding_Index))]
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
#line 1 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\_ViewImports.cshtml"
using wedding_planner;

#line default
#line hidden
#line 2 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\_ViewImports.cshtml"
using wedding_planner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"537c7df10a8eee9a911f4ffbced617347edb3833", @"/Views/Wedding/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0aadd694686a14c367f0150bd67bec2e71f0b6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Wedding_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\Wedding\Index.cshtml"
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
            BeginContext(62, 104, true);
            WriteLiteral("\r\n<div class=\"row justify-content-between\">\r\n    <div class=\"col-8\"><h2>Welcome to the Wedding Planner, ");
            EndContext();
            BeginContext(167, 15, false);
#line 7 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\Wedding\Index.cshtml"
                                                      Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(182, 608, true);
            WriteLiteral(@"!</h2></div>
    <div class=""col-2 text-right align-self-end"">
        <a href=""/logout"" class=""btn-sm btn-secondary"">Log Out</a>
    </div>
</div>


<div class=""row"">
    <div class=""col"">
            <table class=""table table-striped table-bordered mt-4"">
                <thead>
                    <tr>
                        <th scope=""col"">Wedding</th>
                        <th scope=""col"">Date</th>
                        <th scope=""col"">Guests</th>
                        <th scope=""col"">Action</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 26 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\Wedding\Index.cshtml"
                     foreach (RSVP rsvp in Model.Weddings)
                    {

#line default
#line hidden
            BeginContext(873, 64, true);
            WriteLiteral("                        <tr>\r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 937, "\"", 969, 2);
            WriteAttributeValue("", 944, "/weddings/", 944, 10, true);
#line 29 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\Wedding\Index.cshtml"
WriteAttributeValue("", 954, rsvp.WeddingId, 954, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(970, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(972, 22, false);
#line 29 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\Wedding\Index.cshtml"
                                                               Write(rsvp.Wedding.WedderOne);

#line default
#line hidden
            EndContext();
            BeginContext(994, 3, true);
            WriteLiteral(" & ");
            EndContext();
            BeginContext(998, 22, false);
#line 29 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\Wedding\Index.cshtml"
                                                                                         Write(rsvp.Wedding.WedderTwo);

#line default
#line hidden
            EndContext();
            BeginContext(1020, 43, true);
            WriteLiteral("</a></td>\r\n                            <td>");
            EndContext();
            BeginContext(1065, 52, false);
#line 30 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\Wedding\Index.cshtml"
                            Write(((DateTime)rsvp.Wedding.Date).ToString("d MMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1118, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1158, 25, false);
#line 31 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\Wedding\Index.cshtml"
                           Write(rsvp.Wedding.Guests.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1183, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 32 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\Wedding\Index.cshtml"
                             if(rsvp.Wedding.CreatorId == Model.UserId)
                            {

#line default
#line hidden
            BeginContext(1294, 38, true);
            WriteLiteral("                                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1332, "\"", 1362, 2);
            WriteAttributeValue("", 1339, "/delete/", 1339, 8, true);
#line 34 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\Wedding\Index.cshtml"
WriteAttributeValue("", 1347, rsvp.WeddingId, 1347, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1363, 18, true);
            WriteLiteral(">Delete</a></td>\r\n");
            EndContext();
#line 35 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\Wedding\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(1477, 38, true);
            WriteLiteral("                                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1515, "\"", 1543, 2);
            WriteAttributeValue("", 1522, "/un-rsvp/", 1522, 9, true);
#line 38 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\Wedding\Index.cshtml"
WriteAttributeValue("", 1531, rsvp.RSVPId, 1531, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1544, 19, true);
            WriteLiteral(">Un-RSVP</a></td>\r\n");
            EndContext();
#line 39 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\Wedding\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(1594, 31, true);
            WriteLiteral("                        </tr>\r\n");
            EndContext();
#line 41 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\Wedding\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1648, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 42 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\Wedding\Index.cshtml"
                     foreach(Wedding wedding in ViewBag.Weddings)
                    {

#line default
#line hidden
            BeginContext(1738, 64, true);
            WriteLiteral("                        <tr>\r\n                            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1802, "\"", 1837, 2);
            WriteAttributeValue("", 1809, "/weddings/", 1809, 10, true);
#line 45 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\Wedding\Index.cshtml"
WriteAttributeValue("", 1819, wedding.WeddingId, 1819, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1838, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1840, 17, false);
#line 45 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\Wedding\Index.cshtml"
                                                                  Write(wedding.WedderOne);

#line default
#line hidden
            EndContext();
            BeginContext(1857, 3, true);
            WriteLiteral(" & ");
            EndContext();
            BeginContext(1861, 17, false);
#line 45 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\Wedding\Index.cshtml"
                                                                                       Write(wedding.WedderTwo);

#line default
#line hidden
            EndContext();
            BeginContext(1878, 43, true);
            WriteLiteral("</a></td>\r\n                            <td>");
            EndContext();
            BeginContext(1923, 47, false);
#line 46 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\Wedding\Index.cshtml"
                            Write(((DateTime)wedding.Date).ToString("d MMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1971, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(2011, 20, false);
#line 47 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\Wedding\Index.cshtml"
                           Write(wedding.Guests.Count);

#line default
#line hidden
            EndContext();
            BeginContext(2031, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 48 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\Wedding\Index.cshtml"
                             if(wedding.CreatorId == Model.UserId)
                            {

#line default
#line hidden
            BeginContext(2137, 38, true);
            WriteLiteral("                                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2175, "\"", 2208, 2);
            WriteAttributeValue("", 2182, "/delete/", 2182, 8, true);
#line 50 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\Wedding\Index.cshtml"
WriteAttributeValue("", 2190, wedding.WeddingId, 2190, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2209, 18, true);
            WriteLiteral(">Delete</a></td>\r\n");
            EndContext();
#line 51 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\Wedding\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2323, 38, true);
            WriteLiteral("                                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2361, "\"", 2406, 4);
            WriteAttributeValue("", 2368, "/rsvp/", 2368, 6, true);
#line 54 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\Wedding\Index.cshtml"
WriteAttributeValue("", 2374, Model.UserId, 2374, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 2387, "/", 2387, 1, true);
#line 54 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\Wedding\Index.cshtml"
WriteAttributeValue("", 2388, wedding.WeddingId, 2388, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2407, 16, true);
            WriteLiteral(">RSVP</a></td>\r\n");
            EndContext();
#line 55 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\Wedding\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2454, 61, true);
            WriteLiteral("                            \r\n                        </tr>\r\n");
            EndContext();
#line 58 "C:\Users\Anthony\Desktop\c#\ORM\wedding_planner\Views\Wedding\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2538, 197, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col text-right\"><a href=\"weddings/new\" class=\"btn btn-primary\">New Wedding</a></div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591