#pragma checksum "C:\Users\Julia\source\repos\Projekt_Inzynierski\Projekt_Inzynierski\Views\Results\CLevelHard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f57e45098c5e1a09f7a3b836b2e09ddff2adfd9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Results_CLevelHard), @"mvc.1.0.view", @"/Views/Results/CLevelHard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f57e45098c5e1a09f7a3b836b2e09ddff2adfd9d", @"/Views/Results/CLevelHard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"808bffd9bf6e7026011dbb91d893562187dcff91", @"/Views/_ViewImports.cshtml")]
    public class Views_Results_CLevelHard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoordinationModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Julia\source\repos\Projekt_Inzynierski\Projekt_Inzynierski\Views\Results\CLevelHard.cshtml"
  
    ViewData["Title"] = "Hard";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1> Results for Level Hard</h1>
<table class=""table"">
    <thead>
        <tr>
            <th>
                Position
            </th>
            <th>
                Time [s]
            </th>
            <th>
                numbr of Clicks
            </th>

            <th></th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 26 "C:\Users\Julia\source\repos\Projekt_Inzynierski\Projekt_Inzynierski\Views\Results\CLevelHard.cshtml"
          
            var a = 1;
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\Julia\source\repos\Projekt_Inzynierski\Projekt_Inzynierski\Views\Results\CLevelHard.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\Julia\source\repos\Projekt_Inzynierski\Projekt_Inzynierski\Views\Results\CLevelHard.cshtml"
               Write(a);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\Julia\source\repos\Projekt_Inzynierski\Projekt_Inzynierski\Views\Results\CLevelHard.cshtml"
               Write(Html.DisplayFor(modelItem => item.ReactionTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\Julia\source\repos\Projekt_Inzynierski\Projekt_Inzynierski\Views\Results\CLevelHard.cshtml"
               Write(Html.DisplayFor(modelItem => item.NumOfClick));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 45 "C:\Users\Julia\source\repos\Projekt_Inzynierski\Projekt_Inzynierski\Views\Results\CLevelHard.cshtml"
            a++;

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoordinationModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591