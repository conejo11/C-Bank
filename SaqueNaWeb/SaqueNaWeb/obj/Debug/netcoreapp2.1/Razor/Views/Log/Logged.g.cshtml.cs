#pragma checksum "C:\Users\gabriel.conejo\source\repos\SaqueNaWeb\SaqueNaWeb\Views\Log\Logged.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba8e674177308d0df0c0f7407df7ffe67fd60439"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Log_Logged), @"mvc.1.0.view", @"/Views/Log/Logged.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Log/Logged.cshtml", typeof(AspNetCore.Views_Log_Logged))]
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
#line 1 "C:\Users\gabriel.conejo\source\repos\SaqueNaWeb\SaqueNaWeb\Views\_ViewImports.cshtml"
using SaqueNaWeb;

#line default
#line hidden
#line 2 "C:\Users\gabriel.conejo\source\repos\SaqueNaWeb\SaqueNaWeb\Views\_ViewImports.cshtml"
using SaqueNaWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba8e674177308d0df0c0f7407df7ffe67fd60439", @"/Views/Log/Logged.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbc757ac29f0a74b2a8523d0787b2927947944b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Log_Logged : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SaqueNaWeb.Models.Log>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\gabriel.conejo\source\repos\SaqueNaWeb\SaqueNaWeb\Views\Log\Logged.cshtml"
  
    ViewData["Title"] = "Logged";

#line default
#line hidden
            BeginContext(74, 88, true);
            WriteLiteral("\r\n<h2>Saque Realizado com Sucesso</h2>\r\n\r\n<h4>Total de Notas Entregues:</h4>\r\n<hr />\r\n\r\n");
            EndContext();
#line 12 "C:\Users\gabriel.conejo\source\repos\SaqueNaWeb\SaqueNaWeb\Views\Log\Logged.cshtml"
   
	var cem = TempData["100"];
	var cinq = TempData["50"];
	var vinte = TempData["20"];
	var dez = TempData["10"];
	var cinco = TempData["5"];
	var dois = TempData["2"];
	var tot = TempData["Total"];

#line default
#line hidden
            BeginContext(374, 360, true);
            WriteLiteral(@"
<div>
<table class=""table"">
	<thead>
		<tr>
			<th>
				Notas de 100
			</th>
			<th>
				Notas de 50
			</th>
			<th>
				Notas de 20
			</th>
			<th>
				Notas de 10
			</th>
			<th>
				Notas de 5
			</th>
			<th>
				Notas de 2
			</th>
			<th>
				Total
			</th>
			<th></th>
		</tr>
	</thead>
	<tbody>
		<tr>
			<td>
				");
            EndContext();
            BeginContext(735, 3, false);
#line 53 "C:\Users\gabriel.conejo\source\repos\SaqueNaWeb\SaqueNaWeb\Views\Log\Logged.cshtml"
           Write(cem);

#line default
#line hidden
            EndContext();
            BeginContext(738, 25, true);
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t\t<td>\r\n\t\t\t\t");
            EndContext();
            BeginContext(764, 4, false);
#line 56 "C:\Users\gabriel.conejo\source\repos\SaqueNaWeb\SaqueNaWeb\Views\Log\Logged.cshtml"
           Write(cinq);

#line default
#line hidden
            EndContext();
            BeginContext(768, 25, true);
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t\t<td>\r\n\t\t\t\t");
            EndContext();
            BeginContext(794, 5, false);
#line 59 "C:\Users\gabriel.conejo\source\repos\SaqueNaWeb\SaqueNaWeb\Views\Log\Logged.cshtml"
           Write(vinte);

#line default
#line hidden
            EndContext();
            BeginContext(799, 25, true);
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t\t<td>\r\n\t\t\t\t");
            EndContext();
            BeginContext(825, 3, false);
#line 62 "C:\Users\gabriel.conejo\source\repos\SaqueNaWeb\SaqueNaWeb\Views\Log\Logged.cshtml"
           Write(dez);

#line default
#line hidden
            EndContext();
            BeginContext(828, 25, true);
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t\t<td>\r\n\t\t\t\t");
            EndContext();
            BeginContext(854, 5, false);
#line 65 "C:\Users\gabriel.conejo\source\repos\SaqueNaWeb\SaqueNaWeb\Views\Log\Logged.cshtml"
           Write(cinco);

#line default
#line hidden
            EndContext();
            BeginContext(859, 25, true);
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t\t<td>\r\n\t\t\t\t");
            EndContext();
            BeginContext(885, 4, false);
#line 68 "C:\Users\gabriel.conejo\source\repos\SaqueNaWeb\SaqueNaWeb\Views\Log\Logged.cshtml"
           Write(dois);

#line default
#line hidden
            EndContext();
            BeginContext(889, 25, true);
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t\t<td>\r\n\t\t\t\t");
            EndContext();
            BeginContext(915, 3, false);
#line 71 "C:\Users\gabriel.conejo\source\repos\SaqueNaWeb\SaqueNaWeb\Views\Log\Logged.cshtml"
           Write(tot);

#line default
#line hidden
            EndContext();
            BeginContext(918, 66, true);
            WriteLiteral("\r\n\t\t\t</td>\r\n\t\t\t<td></td>\r\n\t\t</tr>\r\n\t</tbody>\r\n</table>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SaqueNaWeb.Models.Log> Html { get; private set; }
    }
}
#pragma warning restore 1591