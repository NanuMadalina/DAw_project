#pragma checksum "C:\Users\Ioana\Documents\DAw_project\WebApplication1\WebApplication1\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "234d1a073da023fe295546a9695a71eea6587570"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
#line 1 "C:\Users\Ioana\Documents\DAw_project\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\Ioana\Documents\DAw_project\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"234d1a073da023fe295546a9695a71eea6587570", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Ioana\Documents\DAw_project\WebApplication1\WebApplication1\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact Us";

#line default
#line hidden
            BeginContext(46, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(51, 17, false);
#line 4 "C:\Users\Ioana\Documents\DAw_project\WebApplication1\WebApplication1\Views\Home\Contact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(68, 11, true);
            WriteLiteral("</h2>\r\n\r\n\r\n");
            EndContext();
            BeginContext(79, 134, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "264c395562524936bb8bbbe1e2854ac7", async() => {
                BeginContext(85, 121, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(213, 2647, true);
            WriteLiteral(@"
<div class=""container1"">
    <div class=""box1"">
        <div class=""icon""><i class=""fa fa-map-marker"" aria-hidden=""true""></i></div>
        <div class='details'><h3>Romania, Bucharest</h3></div>
    </div>

    <div class=""box1"">
        <div class=""icon""><i class=""fa fa-phone"" aria-hidden=""true""></i></div>
        <div class='details'><h3>021 222 333</h3></div>
    </div>

    <div class=""box1"">
        <div class=""icon""><i class=""fa fa-envelope"" aria-hidden=""true""></i></div>
        <div class='details'><h3>food.tracker@gmail.com</h3></div>
    </div>
</div>
<style>
    .container1 {
        width: 900px;
        margin: 250px auto 0;
        display: flex;
    }

        .container1 .box1 {
            position: relative;
            width: 300px;
            height: 100px;
            box-sizing: border-box;
            text-align: center;
            margin: 0 10px;
            overflow: hidden;
            border-radius: 4px;
            box-shadow: 0 0 0 2px rgba(0,7,1");
            WriteLiteral(@"0,1);
        }

            .container1 .box1 .icon {
                width: 100%;
                height: 100%;
                background: #00171d;
                transition: 0.5s;
            }

                .container1 .box1 .icon .fa {
                    font-size: 4em;
                    line-height: 100px;
                    color: #0ff;
                }

            .container1 .box1:hover .icon {
                transform: scale(0);
            }

            .container1 .box1 .details {
                position: absolute;
                top: 0;
                left: 0;
                width: 100%;
                height: 100%;
                background: #03a9f4;
                transition: 0.5s;
                transform: scale(2);
                opacity: 0;
            }

            .container1 .box1:hover .details {
                transform: scale(1);
                opacity: 1;
            }

            .container1 .box1 .details h3 {
         ");
            WriteLiteral(@"       margin: 0;
                padding: 0;
                line-height: 100px;
                font-size: 24px;
                color: #fff;
            }

            .container1 .box1 .details:nth-child(2) .details {
                background: #e91e63;
            }

            .container1 .box1 .details:nth-child(2) .details {
                background: #607d8b;
            }


    /*item active*/

    .item {
        opacity: 0.7;
        filter: alpha(opacity=70);
    }

    .active {
        opacity: 0.7;
        filter: alpha(opacity=70);
    }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
