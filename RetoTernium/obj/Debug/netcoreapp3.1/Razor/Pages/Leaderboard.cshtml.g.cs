#pragma checksum "C:\Users\david\source\repos\RetoTernium\RetoTernium\Pages\Leaderboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99cea479b73e49420ad6463c4e6f408d4ff2e446"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RetoTernium.Pages.Pages_Leaderboard), @"mvc.1.0.razor-page", @"/Pages/Leaderboard.cshtml")]
namespace RetoTernium.Pages
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
#line 1 "C:\Users\david\source\repos\RetoTernium\RetoTernium\Pages\_ViewImports.cshtml"
using RetoTernium;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99cea479b73e49420ad6463c4e6f408d4ff2e446", @"/Pages/Leaderboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34595cccd2e0dbca155d738770a4f7cfbe12b08c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Leaderboard : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <h1>");
#nullable restore
#line 4 "C:\Users\david\source\repos\RetoTernium\RetoTernium\Pages\Leaderboard.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99cea479b73e49420ad6463c4e6f408d4ff2e4463166", async() => {
                WriteLiteral(@"
    <section class=""header2"">
        <div class=""toggle-modo"">
            <input type=""button"" value=""Exámen"" id=""boton-examen"">
            <input type=""button"" value=""Práctica"" id=""boton-practica"">
        </div>

        <div>
            <header>
                <h1>Tabla de Clasificación</h1>
            </header>
        </div>
    </section>

    <section class=""seccion-tabla"">
        <table class=""table table-dark"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Username</th>
                    <th scope=""col"">Puntuacion</th>
                </tr>
            </thead>
            <tbody>
                
");
#nullable restore
#line 33 "C:\Users\david\source\repos\RetoTernium\RetoTernium\Pages\Leaderboard.cshtml"
                   
                    int counter = 1;
                    foreach (var item in Model.listScores)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 39 "C:\Users\david\source\repos\RetoTernium\RetoTernium\Pages\Leaderboard.cshtml"
                       Write(counter);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 42 "C:\Users\david\source\repos\RetoTernium\RetoTernium\Pages\Leaderboard.cshtml"
                       Write(item.username);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 45 "C:\Users\david\source\repos\RetoTernium\RetoTernium\Pages\Leaderboard.cshtml"
                       Write(item.score);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 48 "C:\Users\david\source\repos\RetoTernium\RetoTernium\Pages\Leaderboard.cshtml"
                        counter = counter + 1;
                    }

               

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </tbody>
        </table>
    </section>

    <section class=""info"">
        <br />
        <br />
        <div>
            <a href=""#"">Más Información</a>
        </div>
        <div>
            <h3>Asistente de Entrenamiento de Inspector</h3>
        </div>
    </section>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RetoTernium.Pages.LeaderboardModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RetoTernium.Pages.LeaderboardModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RetoTernium.Pages.LeaderboardModel>)PageContext?.ViewData;
        public RetoTernium.Pages.LeaderboardModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
