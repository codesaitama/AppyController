#pragma checksum "D:\Project\AppyMenuBuilder\AppyController\Views\Home\Menus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5e79a9a4a326e681ca62164309ada54910541d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Menus), @"mvc.1.0.view", @"/Views/Home/Menus.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Menus.cshtml", typeof(AspNetCore.Views_Home_Menus))]
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
#line 1 "D:\Project\AppyMenuBuilder\AppyController\Views\_ViewImports.cshtml"
using MenuManager;

#line default
#line hidden
#line 2 "D:\Project\AppyMenuBuilder\AppyController\Views\_ViewImports.cshtml"
using MenuManager.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5e79a9a4a326e681ca62164309ada54910541d2", @"/Views/Home/Menus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bad7df9ce55776236e93c2b663d2127b9ecdeb0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Menus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("appForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/saitama/PageJSFiles/Menus.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Project\AppyMenuBuilder\AppyController\Views\Home\Menus.cshtml"
  
    ViewData["Title"] = "Menus";

#line default
#line hidden
            BeginContext(43, 225, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n        <div class=\"card shadow\">\r\n            <div class=\"col-md-12 text-right\">\r\n                <button class=\"btn btn-primary text-right project-add-button\" id=\"btnAddMenu\">Add ");
            EndContext();
            BeginContext(269, 17, false);
#line 10 "D:\Project\AppyMenuBuilder\AppyController\Views\Home\Menus.cshtml"
                                                                                             Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(286, 2085, true);
            WriteLiteral(@"</button>
            </div>
            <div class=""table-responsive"">
                <table class=""table align-items-center table-flush"">
                    <thead class=""thead-light"">
                        <tr>
                            <th scope=""col"">Menus</th>
                            <th scope=""col"">Status</th>
                            <th scope=""auto"">Controller</th>
                            <th scope=""auto"">Method</th>
                            <th scope=""col"">Date Created</th>
                            <th scope=""col"" class=""text-center"">Actions</th>
                        </tr>
                    </thead>
                    <tbody id=""menus-body""></tbody>
                </table>
            </div>
            <div class=""card-footer py-4"">
                <nav aria-label=""..."">
                    <ul class=""pagination justify-content-end mb-0"">
                        <li class=""page-item disabled"">
                            <a class=""page-link"" href=""");
            WriteLiteral(@"#"" tabindex=""-1"">
                                <i class=""fas fa-angle-left""></i>
                                <span class=""sr-only"">Previous</span>
                            </a>
                        </li>
                        <li class=""page-item active"">
                            <a class=""page-link"" href=""#"">1</a>
                        </li>
                        <li class=""page-item"">
                            <a class=""page-link"" href=""#"">2 <span class=""sr-only"">(current)</span></a>
                        </li>
                        <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                        <li class=""page-item"">
                            <a class=""page-link"" href=""#"">
                                <i class=""fas fa-angle-right""></i>
                                <span class=""sr-only"">Next</span>
                            </a>
                        </li>
                    </ul>
                </nav>
            </div>
 ");
            WriteLiteral("       </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Modals", async() => {
                BeginContext(2387, 432, true);
                WriteLiteral(@"
    <div class=""modal fade"" id=""menusModal"" role=""dialog"" data-backdrop=""static"" data-keyboard=""true"">
        <div class=""modal-dialog modal-lg"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true""> <i class=""far fa-times-circle text-danger""></i> </button>
                </div>
                ");
                EndContext();
                BeginContext(2819, 1865, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c18947769d54fc5ba84904654cfde66", async() => {
                    BeginContext(2862, 1815, true);
                    WriteLiteral(@"
                    <div class=""modal-body"">
                        <div class=""form-group row"">
                            <div class=""col-md-6"">
                                <label class=""control-label"">Name</label>
                                <input class=""form-control"" type=""text"" name=""description"" id=""menudescrip"" required />
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <div class=""col-md-8"">
                                <label class=""control-label"">URL</label>
                                <input class=""form-control"" type=""text"" name=""txtWebsite"" id=""txtWebsite"" required />
                            </div>
                            <div class=""col-md-4"">
                                <label class=""control-label"">Prefix</label>
                                <input class=""form-control"" type=""text"" name=""txtPrefix"" id=""txtPrefix"" required />
                         ");
                    WriteLiteral(@"   </div>
                        </div>
                        <div class=""form-group row"">
                            <div class=""col-md-12"">
                                <label class=""control-label"">Description</label>
                                <textarea class=""form-control"" rows=""3"" id=""notes""></textarea>
                            </div>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <div class=""pull-left""></div>
                        <button type=""button"" class=""btn btn-success btn-sm"" id=""btnSave"">Save</button>
                        <button type=""reset"" class=""btn btn-link text-danger btn-sm"" id=""btnClose"">Close</button>
                    </div>
                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4684, 50, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(4737, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4756, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4762, 83, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e5bc2fcf2e34e41b6f4adef62b86152", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 100 "D:\Project\AppyMenuBuilder\AppyController\Views\Home\Menus.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4845, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(4850, 2, true);
            WriteLiteral("\r\n");
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
