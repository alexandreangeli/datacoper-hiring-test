#pragma checksum "C:\Users\alean\Desktop\DCLearning\DataBank\DataBank\Banco\Views\Bancos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f5fc8df71fc2112156da7a1b55e2f77aa29063a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bancos_Details), @"mvc.1.0.view", @"/Views/Bancos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bancos/Details.cshtml", typeof(AspNetCore.Views_Bancos_Details))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
#line 4 "C:\Users\alean\Desktop\DCLearning\DataBank\DataBank\Banco\Views\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\alean\Desktop\DCLearning\DataBank\DataBank\Banco\Views\_ViewImports.cshtml"
using BancoDataCoper;

#line default
#line hidden
#line 2 "C:\Users\alean\Desktop\DCLearning\DataBank\DataBank\Banco\Views\_ViewImports.cshtml"
using BancoDataCoper.Models;

#line default
#line hidden
#line 3 "C:\Users\alean\Desktop\DCLearning\DataBank\DataBank\Banco\Views\_ViewImports.cshtml"
using BancoDataCoper.Models.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\alean\Desktop\DCLearning\DataBank\DataBank\Banco\Views\_ViewImports.cshtml"
using System.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f5fc8df71fc2112156da7a1b55e2f77aa29063a", @"/Views/Bancos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9581cf40c849ef45913251e3e65b4437ad75d811", @"/Views/_ViewImports.cshtml")]
    public class Views_Bancos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Banco>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark  rounded-pill"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary  rounded-pill"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(14, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\alean\Desktop\DCLearning\DataBank\DataBank\Banco\Views\Bancos\Details.cshtml"
  
    ViewData["Title"] = "Detalhes do Banco";

#line default
#line hidden
            BeginContext(69, 309, true);
            WriteLiteral(@"

<div class=""pai-banco"">
    <div class=""filho col-4  p-2"">
        <h4 class=""font font-weight-bold m-1 text-center"">Detalhes do Banco</h4>
        <hr />
        <dl class=""col-6 offset-3 cor text-white alert-secondary rounded p-2"">
            <dt class=""font font-weight-bolder"">
                ");
            EndContext();
            BeginContext(379, 40, false);
#line 14 "C:\Users\alean\Desktop\DCLearning\DataBank\DataBank\Banco\Views\Bancos\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(419, 68, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"font\">\r\n                ");
            EndContext();
            BeginContext(488, 36, false);
#line 17 "C:\Users\alean\Desktop\DCLearning\DataBank\DataBank\Banco\Views\Bancos\Details.cshtml"
           Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(524, 87, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"font font-weight-bolder\">\r\n                ");
            EndContext();
            BeginContext(612, 42, false);
#line 20 "C:\Users\alean\Desktop\DCLearning\DataBank\DataBank\Banco\Views\Bancos\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Codigo));

#line default
#line hidden
            EndContext();
            BeginContext(654, 68, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"font\">\r\n                ");
            EndContext();
            BeginContext(723, 38, false);
#line 23 "C:\Users\alean\Desktop\DCLearning\DataBank\DataBank\Banco\Views\Bancos\Details.cshtml"
           Write(Html.DisplayFor(model => model.Codigo));

#line default
#line hidden
            EndContext();
            BeginContext(761, 97, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n        <div class=\"text-center\">\r\n            \r\n            ");
            EndContext();
            BeginContext(858, 134, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42abbda8ac5341c38d2addf44617ee18", async() => {
                BeginContext(915, 73, true);
                WriteLiteral("<i class=\"material-icons float-left font\">arrow_back</i>Voltar Para Lista");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(992, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1006, 142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "479a01f670ad430fa0cda00debcedabf", async() => {
                BeginContext(1090, 54, true);
                WriteLiteral("<i class=\"material-icons float-left\">create</i> Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 29 "C:\Users\alean\Desktop\DCLearning\DataBank\DataBank\Banco\Views\Bancos\Details.cshtml"
                                   WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1148, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Banco> Html { get; private set; }
    }
}
#pragma warning restore 1591