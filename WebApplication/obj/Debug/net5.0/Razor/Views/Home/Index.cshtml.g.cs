#pragma checksum "C:\Users\Gavin Grant\Desktop\Weather_Application-main\WebApplication\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ec496644f873e72acc82dcbe716fa44c6f3dbcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Gavin Grant\Desktop\Weather_Application-main\WebApplication\Views\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gavin Grant\Desktop\Weather_Application-main\WebApplication\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ec496644f873e72acc82dcbe716fa44c6f3dbcf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ea7069f4d9b26b9cc12f9c9c6ca44dbeaa31e7b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Gavin Grant\Desktop\Weather_Application-main\WebApplication\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome to the WeatherApplication!</h1>
    <br />
    <label for=""usr"">Insert your City</label>
    <input type=""text"" class=""form-control"" id=""usr"" text-center>
    <br />
    <input type=""button""class=""btn btn-info"" id=""WeatherSearch"" value=""Check the weather!"" />
</div>


");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    <script type=\"text/javascript\">\n        $(\"#WeatherSearch\").click(function () {\n            var txtVal = $(\"#usr\").val();\n            window.location = \"");
#nullable restore
#line 19 "C:\Users\Gavin Grant\Desktop\Weather_Application-main\WebApplication\Views\Home\Index.cshtml"
                          Write(Url.Action("WeatherData","Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\" +\n                              \"/\" + txtVal;\n        });\n    </script>\n");
            }
            );
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
