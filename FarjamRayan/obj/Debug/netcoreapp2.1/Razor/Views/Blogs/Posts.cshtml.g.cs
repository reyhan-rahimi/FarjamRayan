#pragma checksum "C:\Users\sogand-win\source\repos\FarjamRayanKarmania\FarjamRayan\FarjamRayan\Views\Blogs\Posts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1c0411666b56fabd80e211bca5622548839e22a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blogs_Posts), @"mvc.1.0.view", @"/Views/Blogs/Posts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blogs/Posts.cshtml", typeof(AspNetCore.Views_Blogs_Posts))]
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
#line 1 "C:\Users\sogand-win\source\repos\FarjamRayanKarmania\FarjamRayan\FarjamRayan\Views\_ViewImports.cshtml"
using FarjamRayan;

#line default
#line hidden
#line 2 "C:\Users\sogand-win\source\repos\FarjamRayanKarmania\FarjamRayan\FarjamRayan\Views\_ViewImports.cshtml"
using FarjamRayan.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1c0411666b56fabd80e211bca5622548839e22a", @"/Views/Blogs/Posts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d60894f2ef7a23db15906799872a9cbbaad3a25", @"/Views/_ViewImports.cshtml")]
    public class Views_Blogs_Posts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\sogand-win\source\repos\FarjamRayanKarmania\FarjamRayan\FarjamRayan\Views\Blogs\Posts.cshtml"
  
    ViewData["Title"] = "Posts";
    Layout = "~/Views/Shared/_LayoutBlog.cshtml";


#line default
#line hidden
            BeginContext(108, 427, true);
            WriteLiteral(@"

<!-- HERO
================================================== -->
<section class=""page-banner-area page-about"">
    <div class=""overlay""></div>
    <!-- Content -->
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-9 col-md-12 col-12 text-center"">
                <div class=""page-banner-content"">
                    <h1 class=""display-5 font-weight-bold"">");
            EndContext();
            BeginContext(536, 11, false);
#line 18 "C:\Users\sogand-win\source\repos\FarjamRayanKarmania\FarjamRayan\FarjamRayan\Views\Blogs\Posts.cshtml"
                                                      Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(547, 610, true);
            WriteLiteral(@"</h1>
                </div>
            </div>
        </div> <!-- / .row -->
    </div> <!-- / .container -->
</section>

<!-- LATEST BLOG
================================================== -->
<section class=""section"" id=""blog"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <!-- Side Panel -->
            <div class=""col-12 col-md-4 blog-right-sidebar"">

                <aside class=""single-sidebar-widget post-category-widget"">
                    <h4 class=""widget-title"">???????? ???????? ????</h4>
                    <ul class=""list cat-list p-0"">
");
            EndContext();
            BeginContext(1187, 134, true);
            WriteLiteral("                            <li>\r\n                                <a href=\"#\" class=\"d-flex\">\r\n                                    <p>");
            EndContext();
            BeginContext(1322, 16, false);
#line 40 "C:\Users\sogand-win\source\repos\FarjamRayanKarmania\FarjamRayan\FarjamRayan\Views\Blogs\Posts.cshtml"
                                  Write(Model.Categories);

#line default
#line hidden
            EndContext();
            BeginContext(1338, 141, true);
            WriteLiteral("</p>\r\n                                    <!--<p>&nbsp;(37)</p>-->\r\n                                </a>\r\n                            </li>\r\n");
            EndContext();
            BeginContext(1508, 53, true);
            WriteLiteral("                    </ul>\r\n                </aside>\r\n");
            EndContext();
            BeginContext(2919, 188, true);
            WriteLiteral("\r\n\r\n            </div>\r\n            <!-- /Side Panel -->\r\n            <!-- Blog Post Content -->\r\n            <div class=\"col-12 col-md-8 single-post-area\">\r\n              \r\n              ");
            EndContext();
            BeginContext(3108, 20, false);
#line 85 "C:\Users\sogand-win\source\repos\FarjamRayanKarmania\FarjamRayan\FarjamRayan\Views\Blogs\Posts.cshtml"
         Write(Html.Raw(Model.Text));

#line default
#line hidden
            EndContext();
            BeginContext(3128, 74, true);
            WriteLiteral(";\r\n                <p>\r\n                    <br>\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3202, "\"", 3228, 2);
            WriteAttributeValue("", 3208, "/Images/", 3208, 8, true);
#line 88 "C:\Users\sogand-win\source\repos\FarjamRayanKarmania\FarjamRayan\FarjamRayan\Views\Blogs\Posts.cshtml"
WriteAttributeValue("", 3216, Model.Image, 3216, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3229, 116, true);
            WriteLiteral(" class=\"rounded\" alt=\"post\" width=\"50%\">\r\n                    <br><br>\r\n                  \r\n                </p>\r\n\r\n");
            EndContext();
            BeginContext(5421, 96, true);
            WriteLiteral("\r\n            </div>\r\n            <!-- /Blog Posts -->\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
