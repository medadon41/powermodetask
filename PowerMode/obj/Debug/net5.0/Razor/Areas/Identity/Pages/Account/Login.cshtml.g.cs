#pragma checksum "D:\itra\PowerMode\Areas\Identity\Pages\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da81bc9a6627e51cdc2b261dd3fdf7787cc75095"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Login), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Login.cshtml")]
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
#line 1 "D:\itra\PowerMode\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\itra\PowerMode\Areas\Identity\Pages\_ViewImports.cshtml"
using PowerMode.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\itra\PowerMode\Areas\Identity\Pages\_ViewImports.cshtml"
using PowerMode.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\itra\PowerMode\Areas\Identity\Pages\_ViewImports.cshtml"
using PowerMode.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\itra\PowerMode\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using PowerMode.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da81bc9a6627e51cdc2b261dd3fdf7787cc75095", @"/Areas/Identity/Pages/Account/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e9051900eb4614a5c30bbac7537f2c58a5fad0d", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2094647190d5eb3b255f6193392021d67a7fae59", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Login : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("external-account"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ExternalLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\itra\PowerMode\Areas\Identity\Pages\Account\Login.cshtml"
  
    ViewData["Title"] = "Log in";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 8 "D:\itra\PowerMode\Areas\Identity\Pages\Account\Login.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div class=\"row\">\r\n    <div class=\"col-md-6 col-md-offset-2\">\r\n        <section>\r\n            <h4>Use one of the services to log in.</h4>\r\n            <hr />\r\n");
#nullable restore
#line 14 "D:\itra\PowerMode\Areas\Identity\Pages\Account\Login.cshtml"
              
                if ((Model.ExternalLogins?.Count ?? 0) == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div>
                        <p>
                            There are no external authentication services configured. See <a href=""https://go.microsoft.com/fwlink/?LinkID=532715"">this article</a>
                            for details on setting up this ASP.NET application to support logging in via external services.
                        </p>
                    </div>
");
#nullable restore
#line 23 "D:\itra\PowerMode\Areas\Identity\Pages\Account\Login.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da81bc9a6627e51cdc2b261dd3fdf7787cc750957282", async() => {
                WriteLiteral("\r\n                        <div>\r\n                            <p>\r\n                                <ul style=\"list-style-type: none; padding: 0\">\r\n");
#nullable restore
#line 30 "D:\itra\PowerMode\Areas\Identity\Pages\Account\Login.cshtml"
                                 foreach (var provider in Model.ExternalLogins)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\itra\PowerMode\Areas\Identity\Pages\Account\Login.cshtml"
                                     if (provider.DisplayName == "Facebook")
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <li style=\"margin-bottom: 10px\">\r\n                                        <button type=\"submit\" class=\"btn btn-social btn-lg btn-facebook\" name=\"provider\"");
                BeginWriteAttribute("value", " value=\"", 1546, "\"", 1568, 1);
#nullable restore
#line 35 "D:\itra\PowerMode\Areas\Identity\Pages\Account\Login.cshtml"
WriteAttributeValue("", 1554, provider.Name, 1554, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 1569, "\"", 1624, 6);
                WriteAttributeValue("", 1577, "Log", 1577, 3, true);
                WriteAttributeValue(" ", 1580, "in", 1581, 3, true);
                WriteAttributeValue(" ", 1583, "using", 1584, 6, true);
                WriteAttributeValue(" ", 1589, "your", 1590, 5, true);
#nullable restore
#line 35 "D:\itra\PowerMode\Areas\Identity\Pages\Account\Login.cshtml"
WriteAttributeValue(" ", 1594, provider.DisplayName, 1595, 21, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1616, "account", 1617, 8, true);
                EndWriteAttribute();
                WriteLiteral("><span class=\"fa fa-facebook\"></span>Log in with ");
#nullable restore
#line 35 "D:\itra\PowerMode\Areas\Identity\Pages\Account\Login.cshtml"
                                                                                                                                                                                                                                                   Write(provider.DisplayName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                                        </li>\r\n");
#nullable restore
#line 37 "D:\itra\PowerMode\Areas\Identity\Pages\Account\Login.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\itra\PowerMode\Areas\Identity\Pages\Account\Login.cshtml"
                                     if (provider.DisplayName == "Vkontakte")
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <li style=\"margin-bottom: 10px\">\r\n                                        <button type=\"submit\" class=\"btn btn-social btn-lg btn-vk\" name=\"provider\"");
                BeginWriteAttribute("value", " value=\"", 2098, "\"", 2120, 1);
#nullable restore
#line 41 "D:\itra\PowerMode\Areas\Identity\Pages\Account\Login.cshtml"
WriteAttributeValue("", 2106, provider.Name, 2106, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 2121, "\"", 2176, 6);
                WriteAttributeValue("", 2129, "Log", 2129, 3, true);
                WriteAttributeValue(" ", 2132, "in", 2133, 3, true);
                WriteAttributeValue(" ", 2135, "using", 2136, 6, true);
                WriteAttributeValue(" ", 2141, "your", 2142, 5, true);
#nullable restore
#line 41 "D:\itra\PowerMode\Areas\Identity\Pages\Account\Login.cshtml"
WriteAttributeValue(" ", 2146, provider.DisplayName, 2147, 21, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 2168, "account", 2169, 8, true);
                EndWriteAttribute();
                WriteLiteral("><span class=\"fa fa-vk\"></span>Log in with VK</button>\r\n                                        </li>\r\n");
#nullable restore
#line 43 "D:\itra\PowerMode\Areas\Identity\Pages\Account\Login.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\itra\PowerMode\Areas\Identity\Pages\Account\Login.cshtml"
                                     if (provider.DisplayName == "Google")
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <li style=\"margin-bottom: 10px\">\r\n                                        <button type=\"submit\" class=\"btn btn-social btn-lg btn-google\" name=\"provider\"");
                BeginWriteAttribute("value", " value=\"", 2626, "\"", 2648, 1);
#nullable restore
#line 47 "D:\itra\PowerMode\Areas\Identity\Pages\Account\Login.cshtml"
WriteAttributeValue("", 2634, provider.Name, 2634, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 2649, "\"", 2704, 6);
                WriteAttributeValue("", 2657, "Log", 2657, 3, true);
                WriteAttributeValue(" ", 2660, "in", 2661, 3, true);
                WriteAttributeValue(" ", 2663, "using", 2664, 6, true);
                WriteAttributeValue(" ", 2669, "your", 2670, 5, true);
#nullable restore
#line 47 "D:\itra\PowerMode\Areas\Identity\Pages\Account\Login.cshtml"
WriteAttributeValue(" ", 2674, provider.DisplayName, 2675, 21, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 2696, "account", 2697, 8, true);
                EndWriteAttribute();
                WriteLiteral("><span class=\"fa fa-google\"></span>Log in with ");
#nullable restore
#line 47 "D:\itra\PowerMode\Areas\Identity\Pages\Account\Login.cshtml"
                                                                                                                                                                                                                                               Write(provider.DisplayName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                                        </li>\r\n");
#nullable restore
#line 49 "D:\itra\PowerMode\Areas\Identity\Pages\Account\Login.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\itra\PowerMode\Areas\Identity\Pages\Account\Login.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </ul>\r\n                            </p>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "D:\itra\PowerMode\Areas\Identity\Pages\Account\Login.cshtml"
                                                                                    WriteLiteral(Model.ReturnUrl);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["returnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 55 "D:\itra\PowerMode\Areas\Identity\Pages\Account\Login.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </section>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "da81bc9a6627e51cdc2b261dd3fdf7787cc7509517703", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LoginModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LoginModel>)PageContext?.ViewData;
        public LoginModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591