#pragma checksum "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\APIStarWars\WebAPIStarWars\WebAPIStarWars\Views\Planets\GetPlanetsbyId.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4ff24660db8dd8c2d453153b776f65afe135dec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Planets_GetPlanetsbyId), @"mvc.1.0.view", @"/Views/Planets/GetPlanetsbyId.cshtml")]
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
#line 1 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\APIStarWars\WebAPIStarWars\WebAPIStarWars\Views\_ViewImports.cshtml"
using WebAPIStarWars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\APIStarWars\WebAPIStarWars\WebAPIStarWars\Views\_ViewImports.cshtml"
using WebAPIStarWars.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4ff24660db8dd8c2d453153b776f65afe135dec", @"/Views/Planets/GetPlanetsbyId.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8086f99a8f0de08afdf3108ebde0288494a9d13", @"/Views/_ViewImports.cshtml")]
    public class Views_Planets_GetPlanetsbyId : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlanetRoot>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\APIStarWars\WebAPIStarWars\WebAPIStarWars\Views\Planets\GetPlanetsbyId.cshtml"
  
    ViewData["Title"] = "GetPlanetsbyId";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1>GetPlanetbyId</h1>

<table class=""table align-items-xl-center"">
    <tr>
        <td>Name</td>
        <td>Rotation Period</td>
        <td>Orbital Period</td>
        <td>Diameter</td>
        <td>Climate</td>
        <td>Gravity</td>
        <td>Terrain</td>
        <td>Surface Water</td>
        <td>Population</td>
        <td>Residents</td>


    </tr>

    <tr>
        <td>");
#nullable restore
#line 25 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\APIStarWars\WebAPIStarWars\WebAPIStarWars\Views\Planets\GetPlanetsbyId.cshtml"
       Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 26 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\APIStarWars\WebAPIStarWars\WebAPIStarWars\Views\Planets\GetPlanetsbyId.cshtml"
       Write(Model.rotation_period);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 27 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\APIStarWars\WebAPIStarWars\WebAPIStarWars\Views\Planets\GetPlanetsbyId.cshtml"
       Write(Model.orbital_period);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 28 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\APIStarWars\WebAPIStarWars\WebAPIStarWars\Views\Planets\GetPlanetsbyId.cshtml"
       Write(Model.diameter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 29 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\APIStarWars\WebAPIStarWars\WebAPIStarWars\Views\Planets\GetPlanetsbyId.cshtml"
       Write(Model.climate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 30 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\APIStarWars\WebAPIStarWars\WebAPIStarWars\Views\Planets\GetPlanetsbyId.cshtml"
       Write(Model.gravity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 31 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\APIStarWars\WebAPIStarWars\WebAPIStarWars\Views\Planets\GetPlanetsbyId.cshtml"
       Write(Model.terrain);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 32 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\APIStarWars\WebAPIStarWars\WebAPIStarWars\Views\Planets\GetPlanetsbyId.cshtml"
       Write(Model.surface_water);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 33 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\APIStarWars\WebAPIStarWars\WebAPIStarWars\Views\Planets\GetPlanetsbyId.cshtml"
       Write(Model.population);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 34 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\APIStarWars\WebAPIStarWars\WebAPIStarWars\Views\Planets\GetPlanetsbyId.cshtml"
       Write(Model.residents);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n    </tr>\r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlanetRoot> Html { get; private set; }
    }
}
#pragma warning restore 1591