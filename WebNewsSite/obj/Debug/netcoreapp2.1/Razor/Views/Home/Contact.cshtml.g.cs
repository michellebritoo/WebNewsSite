#pragma checksum "C:\Users\Usuário\source\repos\WebNewsSite\WebNewsSite\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7360aab55c0195043799ac2b9794eeab906bcd8a"
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
#line 1 "C:\Users\Usuário\source\repos\WebNewsSite\WebNewsSite\Views\_ViewImports.cshtml"
using WebNewsSite;

#line default
#line hidden
#line 2 "C:\Users\Usuário\source\repos\WebNewsSite\WebNewsSite\Views\_ViewImports.cshtml"
using WebNewsSite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7360aab55c0195043799ac2b9794eeab906bcd8a", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc6eb3b8a30d43e2cf3b88964f6fe20adee639c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Usuário\source\repos\WebNewsSite\WebNewsSite\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(43, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(48, 17, false);
#line 4 "C:\Users\Usuário\source\repos\WebNewsSite\WebNewsSite\Views\Home\Contact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(65, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(77, 19, false);
#line 5 "C:\Users\Usuário\source\repos\WebNewsSite\WebNewsSite\Views\Home\Contact.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(96, 751, true);
            WriteLiteral(@"</h3>

<address>
    <button type=""button"" class=""btn btn-secondary"" title=""Desenvolvedora"" data-container=""body"" data-toggle=""popover"" 
            data-placement=""top"" data-content=""Desenvolvedora em construção :)"" 
            data-original-title=""Sobre:"" aria-describedby=""popover206289"">Michelle Brito</button>
    Michelle Brito<br />
    Rio Grande do Sul, Brasil<br />
</address>

<address>
    <strong>E-mail:</strong> <a href=""michellebrito@sou.faccat.br"">michellebrito@sou.faccat.br</a><br />
    <strong>Linkedin:</strong> <a href=""https://www.linkedin.com/in/michellebrito01/"">Michelle Brito</a><br />
    <strong>Instagram:</strong> <a href=""https://www.instagram.com/michebritoo/"">michebritoo</a>
    <img />
</address>
");
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
