#pragma checksum "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\APIStarWars\WebAPIStarWars\WebAPIStarWars\Views\Person\GetPersonbyId.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9277171712c7b43a0f53c86ab501f469995c1519"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_GetPersonbyId), @"mvc.1.0.view", @"/Views/Person/GetPersonbyId.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9277171712c7b43a0f53c86ab501f469995c1519", @"/Views/Person/GetPersonbyId.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8086f99a8f0de08afdf3108ebde0288494a9d13", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_GetPersonbyId : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PersonRoot>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\APIStarWars\WebAPIStarWars\WebAPIStarWars\Views\Person\GetPersonbyId.cshtml"
  
    ViewData["Title"] = "GetPersonbyId";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Display Person</h1>

<table class=""table align-items-xl-center"">
    <tr>
        <td>Name</td>
        <td>Height</td>
        <td>Mass</td>
        <td>Hair Color</td>
        <td>Skin Color</td>
        <td>Eye Color</td>
        <td>Birth Year</td>
        <td>Gender</td>
        <td>Home World</td>
        <td>Films</td>
    </tr>
");
#nullable restore
#line 22 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\APIStarWars\WebAPIStarWars\WebAPIStarWars\Views\Person\GetPersonbyId.cshtml"
     foreach (PersonRoot person in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 25 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\APIStarWars\WebAPIStarWars\WebAPIStarWars\Views\Person\GetPersonbyId.cshtml"
   Write(person.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 26 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\APIStarWars\WebAPIStarWars\WebAPIStarWars\Views\Person\GetPersonbyId.cshtml"
   Write(person.height);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 27 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\APIStarWars\WebAPIStarWars\WebAPIStarWars\Views\Person\GetPersonbyId.cshtml"
   Write(person.mass);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 28 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\APIStarWars\WebAPIStarWars\WebAPIStarWars\Views\Person\GetPersonbyId.cshtml"
   Write(person.hair_color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 29 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\APIStarWars\WebAPIStarWars\WebAPIStarWars\Views\Person\GetPersonbyId.cshtml"
   Write(person.skin_color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 30 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\APIStarWars\WebAPIStarWars\WebAPIStarWars\Views\Person\GetPersonbyId.cshtml"
   Write(person.eye_color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 31 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\APIStarWars\WebAPIStarWars\WebAPIStarWars\Views\Person\GetPersonbyId.cshtml"
   Write(person.birth_year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 32 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\APIStarWars\WebAPIStarWars\WebAPIStarWars\Views\Person\GetPersonbyId.cshtml"
   Write(person.gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 33 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\APIStarWars\WebAPIStarWars\WebAPIStarWars\Views\Person\GetPersonbyId.cshtml"
   Write(person.homeworld);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 34 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\APIStarWars\WebAPIStarWars\WebAPIStarWars\Views\Person\GetPersonbyId.cshtml"
   Write(person.films);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n</tr>\r\n");
#nullable restore
#line 36 "C:\Users\micha\OneDrive\Desktop\C# Boot Camp\APIStarWars\WebAPIStarWars\WebAPIStarWars\Views\Person\GetPersonbyId.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PersonRoot>> Html { get; private set; }
    }
}
#pragma warning restore 1591