#pragma checksum "C:\Users\Haris\OneDrive\Radna površina\Projekt\Projekt\Views\Kupac\Prikazi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e05a99947a8742913e4474cea98bafa537a038d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kupac_Prikazi), @"mvc.1.0.view", @"/Views/Kupac/Prikazi.cshtml")]
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
#line 1 "C:\Users\Haris\OneDrive\Radna površina\Projekt\Projekt\Views\_ViewImports.cshtml"
using Projekt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Haris\OneDrive\Radna površina\Projekt\Projekt\Views\_ViewImports.cshtml"
using Projekt.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Haris\OneDrive\Radna površina\Projekt\Projekt\Views\Kupac\Prikazi.cshtml"
using Projekt.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e05a99947a8742913e4474cea98bafa537a038d5", @"/Views/Kupac/Prikazi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90ccb9a0a85e2b383b463914ff60e93aa736b684", @"/Views/_ViewImports.cshtml")]
    public class Views_Kupac_Prikazi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KupacPrikaziViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Haris\OneDrive\Radna površina\Projekt\Projekt\Views\Kupac\Prikazi.cshtml"
  
    ViewData["Title"] = "Prikazi";

    var porukaSucess = (string)TempData["porukaSucess"];
    var porukaWarning = (string)TempData["porukaWarning"];
    var porukaError = (string)TempData["porukaError"];




#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 16 "C:\Users\Haris\OneDrive\Radna površina\Projekt\Projekt\Views\Kupac\Prikazi.cshtml"
 if (porukaSucess != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\" id=\"porukaBox\">\r\n        ");
#nullable restore
#line 19 "C:\Users\Haris\OneDrive\Radna površina\Projekt\Projekt\Views\Kupac\Prikazi.cshtml"
   Write(porukaSucess);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 21 "C:\Users\Haris\OneDrive\Radna površina\Projekt\Projekt\Views\Kupac\Prikazi.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 24 "C:\Users\Haris\OneDrive\Radna površina\Projekt\Projekt\Views\Kupac\Prikazi.cshtml"
 if (porukaWarning != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\" role=\"alert\" id=\"porukaBox\">\r\n        ");
#nullable restore
#line 27 "C:\Users\Haris\OneDrive\Radna površina\Projekt\Projekt\Views\Kupac\Prikazi.cshtml"
   Write(porukaWarning);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 29 "C:\Users\Haris\OneDrive\Radna površina\Projekt\Projekt\Views\Kupac\Prikazi.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 32 "C:\Users\Haris\OneDrive\Radna površina\Projekt\Projekt\Views\Kupac\Prikazi.cshtml"
 if (porukaError != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\" id=\"porukaBox\">\r\n        ");
#nullable restore
#line 35 "C:\Users\Haris\OneDrive\Radna površina\Projekt\Projekt\Views\Kupac\Prikazi.cshtml"
   Write(porukaError);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 37 "C:\Users\Haris\OneDrive\Radna površina\Projekt\Projekt\Views\Kupac\Prikazi.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<h1>Prikazi</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>Naziv</th>
            <th>Adresa</th>
            <th>PDVBroj</th>
            <th>NazivOpstine</th>
            <th>Fatura Count</th>
            <th>Faktura Sum</th>
            <th>Akcija</th>


        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 59 "C:\Users\Haris\OneDrive\Radna površina\Projekt\Projekt\Views\Kupac\Prikazi.cshtml"
         foreach (NekiDrugiNaziv x in Model.podaciZaHTMLTabelu)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 62 "C:\Users\Haris\OneDrive\Radna površina\Projekt\Projekt\Views\Kupac\Prikazi.cshtml"
               Write(x.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 63 "C:\Users\Haris\OneDrive\Radna površina\Projekt\Projekt\Views\Kupac\Prikazi.cshtml"
               Write(x.Adresa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 64 "C:\Users\Haris\OneDrive\Radna površina\Projekt\Projekt\Views\Kupac\Prikazi.cshtml"
               Write(x.PdvBroj);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>\r\n");
#nullable restore
#line 67 "C:\Users\Haris\OneDrive\Radna površina\Projekt\Projekt\Views\Kupac\Prikazi.cshtml"
                     if (x.OpstinaPrebivalista == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label>Nema opstine</label>\r\n");
#nullable restore
#line 70 "C:\Users\Haris\OneDrive\Radna površina\Projekt\Projekt\Views\Kupac\Prikazi.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label>");
#nullable restore
#line 73 "C:\Users\Haris\OneDrive\Radna površina\Projekt\Projekt\Views\Kupac\Prikazi.cshtml"
                          Write(x.OpstinaPrebivalista);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 74 "C:\Users\Haris\OneDrive\Radna površina\Projekt\Projekt\Views\Kupac\Prikazi.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n\r\n                <td>");
#nullable restore
#line 77 "C:\Users\Haris\OneDrive\Radna površina\Projekt\Projekt\Views\Kupac\Prikazi.cshtml"
               Write(x.BrojFaktura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 78 "C:\Users\Haris\OneDrive\Radna površina\Projekt\Projekt\Views\Kupac\Prikazi.cshtml"
               Write(x.SumaFaktura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1720, "\"", 1759, 2);
            WriteAttributeValue("", 1727, "/Kupac/Obrisi?KupacID=", 1727, 22, true);
#nullable restore
#line 82 "C:\Users\Haris\OneDrive\Radna površina\Projekt\Projekt\Views\Kupac\Prikazi.cshtml"
WriteAttributeValue("", 1749, x.KupacId, 1749, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Obrisi</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1818, "\"", 1860, 2);
            WriteAttributeValue("", 1825, "/Kupac/UrediForm?KupacID=", 1825, 25, true);
#nullable restore
#line 83 "C:\Users\Haris\OneDrive\Radna površina\Projekt\Projekt\Views\Kupac\Prikazi.cshtml"
WriteAttributeValue("", 1850, x.KupacId, 1850, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Uredi</a>\r\n\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 87 "C:\Users\Haris\OneDrive\Radna površina\Projekt\Projekt\Views\Kupac\Prikazi.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<script>

    window.setTimeout(function () {
        $(""#porukaBox"").fadeOut(500, 0).slideUp(500, function () {
            $(this).remove();
        });
    }, 4000);
</script>

<a href=""/Kupac/DodajForm"" class=""btn btn-success"">Dodaj novi</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KupacPrikaziViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
