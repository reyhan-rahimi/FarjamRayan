#pragma checksum "C:\Users\sogand-win\source\repos\FarjamRayanKarmania\FarjamRayan\FarjamRayan\Views\Blogs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f3d885fba0fef79af3c88511e748845ba4c303f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blogs_Details), @"mvc.1.0.view", @"/Views/Blogs/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blogs/Details.cshtml", typeof(AspNetCore.Views_Blogs_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f3d885fba0fef79af3c88511e748845ba4c303f", @"/Views/Blogs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d60894f2ef7a23db15906799872a9cbbaad3a25", @"/Views/_ViewImports.cshtml")]
    public class Views_Blogs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FarjamRayan.Models.Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\sogand-win\source\repos\FarjamRayanKarmania\FarjamRayan\FarjamRayan\Views\Blogs\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(77, 118, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Blog</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(196, 41, false);
#line 14 "C:\Users\sogand-win\source\repos\FarjamRayanKarmania\FarjamRayan\FarjamRayan\Views\Blogs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(237, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(281, 37, false);
#line 17 "C:\Users\sogand-win\source\repos\FarjamRayanKarmania\FarjamRayan\FarjamRayan\Views\Blogs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(318, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(362, 40, false);
#line 20 "C:\Users\sogand-win\source\repos\FarjamRayanKarmania\FarjamRayan\FarjamRayan\Views\Blogs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Text));

#line default
#line hidden
            EndContext();
            BeginContext(402, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(446, 36, false);
#line 23 "C:\Users\sogand-win\source\repos\FarjamRayanKarmania\FarjamRayan\FarjamRayan\Views\Blogs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Text));

#line default
#line hidden
            EndContext();
            BeginContext(482, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(526, 41, false);
#line 26 "C:\Users\sogand-win\source\repos\FarjamRayanKarmania\FarjamRayan\FarjamRayan\Views\Blogs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(567, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(611, 37, false);
#line 29 "C:\Users\sogand-win\source\repos\FarjamRayanKarmania\FarjamRayan\FarjamRayan\Views\Blogs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(648, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(692, 47, false);
#line 32 "C:\Users\sogand-win\source\repos\FarjamRayanKarmania\FarjamRayan\FarjamRayan\Views\Blogs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateCreated));

#line default
#line hidden
            EndContext();
            BeginContext(739, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(783, 43, false);
#line 35 "C:\Users\sogand-win\source\repos\FarjamRayanKarmania\FarjamRayan\FarjamRayan\Views\Blogs\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateCreated));

#line default
#line hidden
            EndContext();
            BeginContext(826, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(870, 46, false);
#line 38 "C:\Users\sogand-win\source\repos\FarjamRayanKarmania\FarjamRayan\FarjamRayan\Views\Blogs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Categories));

#line default
#line hidden
            EndContext();
            BeginContext(916, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(960, 42, false);
#line 41 "C:\Users\sogand-win\source\repos\FarjamRayanKarmania\FarjamRayan\FarjamRayan\Views\Blogs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Categories));

#line default
#line hidden
            EndContext();
            BeginContext(1002, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1046, 42, false);
#line 44 "C:\Users\sogand-win\source\repos\FarjamRayanKarmania\FarjamRayan\FarjamRayan\Views\Blogs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Author));

#line default
#line hidden
            EndContext();
            BeginContext(1088, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1132, 38, false);
#line 47 "C:\Users\sogand-win\source\repos\FarjamRayanKarmania\FarjamRayan\FarjamRayan\Views\Blogs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Author));

#line default
#line hidden
            EndContext();
            BeginContext(1170, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1214, 40, false);
#line 50 "C:\Users\sogand-win\source\repos\FarjamRayanKarmania\FarjamRayan\FarjamRayan\Views\Blogs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tags));

#line default
#line hidden
            EndContext();
            BeginContext(1254, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1298, 36, false);
#line 53 "C:\Users\sogand-win\source\repos\FarjamRayanKarmania\FarjamRayan\FarjamRayan\Views\Blogs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tags));

#line default
#line hidden
            EndContext();
            BeginContext(1334, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1381, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02a7cd8805a14bfea0b37948b597718b", async() => {
                BeginContext(1427, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "C:\Users\sogand-win\source\repos\FarjamRayanKarmania\FarjamRayan\FarjamRayan\Views\Blogs\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            BeginContext(1435, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1443, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34006248a9e2427d9dacb76b4b0e2182", async() => {
                BeginContext(1465, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1481, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FarjamRayan.Models.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591