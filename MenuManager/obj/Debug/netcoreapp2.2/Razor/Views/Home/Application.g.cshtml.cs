#pragma checksum "C:\Users\mensah\source\repos\MenuManager\MenuManager\Views\Home\Application.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dac60ac9e2c8c8b7d64d3cc2dac25cddf40ae856"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Application), @"mvc.1.0.view", @"/Views/Home/Application.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Application.cshtml", typeof(AspNetCore.Views_Home_Application))]
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
#line 1 "C:\Users\mensah\source\repos\MenuManager\MenuManager\Views\_ViewImports.cshtml"
using MenuManager;

#line default
#line hidden
#line 2 "C:\Users\mensah\source\repos\MenuManager\MenuManager\Views\_ViewImports.cshtml"
using MenuManager.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dac60ac9e2c8c8b7d64d3cc2dac25cddf40ae856", @"/Views/Home/Application.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bad7df9ce55776236e93c2b663d2127b9ecdeb0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Application : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("appForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/saitama/PageJSFiles/Applications.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\mensah\source\repos\MenuManager\MenuManager\Views\Home\Application.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Applications";

#line default
#line hidden
            BeginContext(75, 409, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col"">
        <div class=""card shadow"">
            <div class=""col-md-12"">
                <div class=""col-md-8"">
                    <select class=""form-control"" id=""slctProject""></select>
                </div>
                <div class=""col-md-4 text-right"">
                    <button class=""btn btn-primary text-right project-add-button"" id=""btnAddApp"">Add ");
            EndContext();
            BeginContext(485, 17, false);
#line 15 "C:\Users\mensah\source\repos\MenuManager\MenuManager\Views\Home\Application.cshtml"
                                                                                                Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(502, 2047, true);
            WriteLiteral(@"</button>
                </div>

            </div>
            <div class=""table-responsive"">
                <table class=""table align-items-center table-flush"">
                    <thead class=""thead-light"">
                        <tr>
                            <th scope=""col"">Prefix</th>
                            <th scope=""col"">App Name</th>
                            <th scope=""col"">Status</th>
                            <th scope=""col"">Date Created</th>
                            <th scope=""col"" class=""text-center"">Actions</th>
                        </tr>
                    </thead>
                    <tbody id=""apps-tbody""></tbody>
                </table>
            </div>
            <div class=""card-footer py-4"">
                <nav aria-label=""..."">
                    <ul class=""pagination justify-content-end mb-0"">
                        <li class=""page-item disabled"">
                            <a class=""page-link"" href=""#"" tabindex=""-1"">
               ");
            WriteLiteral(@"                 <i class=""fa fa-angle-left""></i>
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
                                <i class=""fa fa-angle-right""></i>
                                <span class=""sr-only"">Next</span>
                            </a>
                        </li>
                    </ul>
                </nav>
            </div>
        </div>
    </div>
</div>
");
            EndContext();
            DefineSection("Modals", async() => {
                BeginContext(2565, 430, true);
                WriteLiteral(@"
    <div class=""modal fade"" id=""appModal"" role=""dialog"" data-backdrop=""static"" data-keyboard=""true"">
        <div class=""modal-dialog modal-lg"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true""> <i class=""far fa-times-circle text-danger""></i> </button>
                </div>
                ");
                EndContext();
                BeginContext(2995, 1865, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dac60ac9e2c8c8b7d64d3cc2dac25cddf40ae8568600", async() => {
                    BeginContext(3038, 1815, true);
                    WriteLiteral(@"
                    <div class=""modal-body"">
                        <div class=""form-group row"">
                            <div class=""col-md-6"">
                                <label class=""control-label"">Name</label>
                                <input class=""form-control"" type=""text"" name=""description"" id=""description"" required />
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
                BeginContext(4860, 50, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            BeginContext(4913, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4932, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4938, 90, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dac60ac9e2c8c8b7d64d3cc2dac25cddf40ae85612596", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 105 "C:\Users\mensah\source\repos\MenuManager\MenuManager\Views\Home\Application.cshtml"
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
                BeginContext(5028, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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