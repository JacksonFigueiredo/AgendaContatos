#pragma checksum "C:\Users\tmp.jfigueiredo\Desktop\AgendaContatos\Contatos\Views\Contato\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3c7ae6f868bfa490df29cb876694c0e542469cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contato_Index), @"mvc.1.0.view", @"/Views/Contato/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contato/Index.cshtml", typeof(AspNetCore.Views_Contato_Index))]
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
#line 1 "C:\Users\tmp.jfigueiredo\Desktop\AgendaContatos\Contatos\Views\_ViewImports.cshtml"
using AgendaContatos;

#line default
#line hidden
#line 2 "C:\Users\tmp.jfigueiredo\Desktop\AgendaContatos\Contatos\Views\_ViewImports.cshtml"
using AgendaContatos.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3c7ae6f868bfa490df29cb876694c0e542469cd", @"/Views/Contato/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f9fad036e7d7295871f759288612633404bd7db", @"/Views/_ViewImports.cshtml")]
    public class Views_Contato_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AgendaContatos.Models.Contato>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\tmp.jfigueiredo\Desktop\AgendaContatos\Contatos\Views\Contato\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(92, 17, true);
            WriteLiteral("<br />\r\n<p>\r\n    ");
            EndContext();
            BeginContext(109, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "041154f5b515439f97bb1e78e0e65ec9", async() => {
                BeginContext(132, 18, true);
                WriteLiteral("Criar Novo Contato");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(154, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(247, 45, false);
#line 13 "C:\Users\tmp.jfigueiredo\Desktop\AgendaContatos\Contatos\Views\Contato\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ContatoId));

#line default
#line hidden
            EndContext();
            BeginContext(292, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(348, 40, false);
#line 16 "C:\Users\tmp.jfigueiredo\Desktop\AgendaContatos\Contatos\Views\Contato\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(388, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(444, 44, false);
#line 19 "C:\Users\tmp.jfigueiredo\Desktop\AgendaContatos\Contatos\Views\Contato\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
            EndContext();
            BeginContext(488, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(544, 41, false);
#line 22 "C:\Users\tmp.jfigueiredo\Desktop\AgendaContatos\Contatos\Views\Contato\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(585, 88, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 29 "C:\Users\tmp.jfigueiredo\Desktop\AgendaContatos\Contatos\Views\Contato\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(705, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(754, 44, false);
#line 32 "C:\Users\tmp.jfigueiredo\Desktop\AgendaContatos\Contatos\Views\Contato\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ContatoId));

#line default
#line hidden
            EndContext();
            BeginContext(798, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(854, 39, false);
#line 35 "C:\Users\tmp.jfigueiredo\Desktop\AgendaContatos\Contatos\Views\Contato\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(893, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(949, 43, false);
#line 38 "C:\Users\tmp.jfigueiredo\Desktop\AgendaContatos\Contatos\Views\Contato\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Telefone));

#line default
#line hidden
            EndContext();
            BeginContext(992, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1048, 40, false);
#line 41 "C:\Users\tmp.jfigueiredo\Desktop\AgendaContatos\Contatos\Views\Contato\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1088, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1146, 60, false);
#line 45 "C:\Users\tmp.jfigueiredo\Desktop\AgendaContatos\Contatos\Views\Contato\Index.cshtml"
           Write(Html.ActionLink("Editar", "Edit", new { id=item.ContatoId }));

#line default
#line hidden
            EndContext();
            BeginContext(1206, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1227, 65, false);
#line 46 "C:\Users\tmp.jfigueiredo\Desktop\AgendaContatos\Contatos\Views\Contato\Index.cshtml"
           Write(Html.ActionLink("Detalhes", "Details", new { id=item.ContatoId }));

#line default
#line hidden
            EndContext();
            BeginContext(1292, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1313, 63, false);
#line 47 "C:\Users\tmp.jfigueiredo\Desktop\AgendaContatos\Contatos\Views\Contato\Index.cshtml"
           Write(Html.ActionLink("Deletar", "Delete", new { id=item.ContatoId }));

#line default
#line hidden
            EndContext();
            BeginContext(1376, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 50 "C:\Users\tmp.jfigueiredo\Desktop\AgendaContatos\Contatos\Views\Contato\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1415, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AgendaContatos.Models.Contato>> Html { get; private set; }
    }
}
#pragma warning restore 1591
