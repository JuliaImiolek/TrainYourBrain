#pragma checksum "C:\Users\Julia\source\repos\Projekt_Inzynierski\Projekt_Inzynierski\Views\Coordination\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c06515aaa292f7c4697d6e1c8964e623b7a013a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Coordination_Index), @"mvc.1.0.view", @"/Views/Coordination/Index.cshtml")]
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
#line 1 "C:\Users\Julia\source\repos\Projekt_Inzynierski\Projekt_Inzynierski\Views\_ViewImports.cshtml"
using Projekt_Inzynierski;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Julia\source\repos\Projekt_Inzynierski\Projekt_Inzynierski\Views\_ViewImports.cshtml"
using Projekt_Inzynierski.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c06515aaa292f7c4697d6e1c8964e623b7a013a", @"/Views/Coordination/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"808bffd9bf6e7026011dbb91d893562187dcff91", @"/Views/_ViewImports.cshtml")]
    public class Views_Coordination_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Julia\source\repos\Projekt_Inzynierski\Projekt_Inzynierski\Views\Coordination\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Index</h1>
<a href=""LevelEasy""><h3>Level Easy</h3></a>
<a href=""LevelMedium""><h3>Level Medium</h3></a>
<a href=""LevelHard""><h3>Level Hard</h3></a>
<a href=""MediumShapes""><h3>Medium Shapes</h3></a>
<a href=""TinyShapes""><h3>Tiny Shapes</h3></a>

");
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