#pragma checksum "C:\Users\ELNUR\Desktop\Test Imtahan 2\TestImtahan2\TestImtahan2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2e5c88d2ff74bfa4c64bf124c5a347fcc7e8107"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\ELNUR\Desktop\Test Imtahan 2\TestImtahan2\TestImtahan2\Views\_ViewImports.cshtml"
using TestImtahan2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ELNUR\Desktop\Test Imtahan 2\TestImtahan2\TestImtahan2\Views\_ViewImports.cshtml"
using TestImtahan2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2e5c88d2ff74bfa4c64bf124c5a347fcc7e8107", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14992e41d1ce405b0229a4c7d0f54788fb629c21", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/featureCarImg.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("car"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/mbw s.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ELNUR\Desktop\Test Imtahan 2\TestImtahan2\TestImtahan2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main>
        <section id=""Intro"">
            <div class=""container"">
                <div class=""row "">
                    <div class=""col-7"">
                        <div class=""intro-content"">
                            <div class=""intro-text"">
                                <h1>FIND YOUR RENT A CAR</h1>
                                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                            </div>
                        </div>

                    </div>
                    <div class=""col-5"">
                        <div class=""intro-search"">
                            <div class=""intro-search-card"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2e5c88d2ff74bfa4c64bf124c5a347fcc7e81076131", async() => {
                WriteLiteral(@"
                                    <div class=""text-center h3 mt-3"">Search Car</div>
                                    <div class=""form-group mt-3"">
                                        <input class=""form-control"" id=""exampleInputEmail1"">
                                    </div>
                                    <div class=""form-group mt-3"">
                                        <input class=""form-control"" id=""exampleInputEmail1"">
                                    </div>
                                    <div class=""form-group mt-3"">
                                        <input class=""form-control"" id=""exampleInputEmail1"">
                                    </div>
                                    <div class=""form-group mt-3"">
                                        <input class=""form-control"" id=""exampleInputEmail1"">
                                    </div>
                                    <button type=""submit"" class=""btn btn-warning w-100 mt-2 mb-3"">Search</button>
");
                WriteLiteral("                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <section id=""OurOffers"">
            <div class=""container"">
                <div class=""section-header text-center mt-5"">OUR BEST <span>OFFERS</span></div>
                <div class=""offers-text text-center"">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras a arcu eu justo euismod rutrum. Quisque id enim ac tortor malesuada vestibulum non quis turpis. Ut eget ornare arcu. Suspendisse velit mi, pulvinar sed mauris eget, efficitur
                    tempor ex.</div>
                <div class=""row mt-4"">
                    <div class=""col-4 d-flex flex-column justify-content-between"">
                        <div class=""offers-part"">
                            <div class=""row"">
                                <div class=""col-2"">
                                    <div class=""offers-part-icon"">
                      ");
            WriteLiteral(@"                  <i class=""fa-solid fa-car""></i>
                                    </div>
                                </div>
                                <div class=""col-10"">
                                    <div class=""offers-part-content"">
                                        <div class=""offers-part-content-header"">Featured Luxury Cars</div>
                                        <div class=""offers-part-content-text"">Lorem ipsum dolor sit amet, onsectetuer adipiscing elitcommodo ligula eget dolor.</div>
                                    </div>
                                </div>

                            </div>
                        </div>
                        <div class=""offers-part"">
                            <div class=""row"">
                                <div class=""col-2"">
                                    <div class=""offers-part-icon"">
                                        <i class=""fa-solid fa-car""></i>
                                    </div>
            WriteLiteral(@"
                                </div>
                                <div class=""col-10"">
                                    <div class=""offers-part-content"">
                                        <div class=""offers-part-content-header"">Featured Luxury Cars</div>
                                        <div class=""offers-part-content-text"">Lorem ipsum dolor sit amet, onsectetuer adipiscing elitcommodo ligula eget dolor.</div>
                                    </div>
                                </div>

                            </div>
                        </div>
                        <div class=""offers-part"">
                            <div class=""row"">
                                <div class=""col-2"">
                                    <div class=""offers-part-icon"">
                                        <i class=""fa-solid fa-car""></i>
                                    </div>
                                </div>
                                <div class=""col-10"">
            WriteLiteral(@"
                                    <div class=""offers-part-content"">
                                        <div class=""offers-part-content-header"">Featured Luxury Cars</div>
                                        <div class=""offers-part-content-text"">Lorem ipsum dolor sit amet, onsectetuer adipiscing elitcommodo ligula eget dolor.</div>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                    <div class=""col-4"">
                        <div class=""offers-img"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e2e5c88d2ff74bfa4c64bf124c5a347fcc7e810712363", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""col-4 d-flex flex-column justify-content-between"">
                        <div class=""offers-part"">
                            <div class=""row"">
                                <div class=""col-2"">
                                    <div class=""offers-part-icon"">
                                        <i class=""fa-solid fa-car""></i>
                                    </div>
                                </div>
                                <div class=""col-10"">
                                    <div class=""offers-part-content"">
                                        <div class=""offers-part-content-header"">Featured Luxury Cars</div>
                                        <div class=""offers-part-content-text"">Lorem ipsum dolor sit amet, onsectetuer adipiscing elitcommodo ligula eget dolor.</div>
                                    </div>
                                </div>

                ");
            WriteLiteral(@"            </div>
                        </div>
                        <div class=""offers-part"">
                            <div class=""row"">
                                <div class=""col-2"">
                                    <div class=""offers-part-icon"">
                                        <i class=""fa-solid fa-car""></i>
                                    </div>
                                </div>
                                <div class=""col-10"">
                                    <div class=""offers-part-content"">
                                        <div class=""offers-part-content-header"">Featured Luxury Cars</div>
                                        <div class=""offers-part-content-text"">Lorem ipsum dolor sit amet, onsectetuer adipiscing elitcommodo ligula eget dolor.</div>
                                    </div>
                                </div>

                            </div>
                        </div>
                        <div class=""offers");
            WriteLiteral(@"-part"">
                            <div class=""row"">
                                <div class=""col-2"">
                                    <div class=""offers-part-icon"">
                                        <i class=""fa-solid fa-car""></i>
                                    </div>
                                </div>
                                <div class=""col-10"">
                                    <div class=""offers-part-content"">
                                        <div class=""offers-part-content-header"">Featured Luxury Cars</div>
                                        <div class=""offers-part-content-text"">Lorem ipsum dolor sit amet, onsectetuer adipiscing elitcommodo ligula eget dolor.</div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
            </div>

        </section>
        <section id=""V");
            WriteLiteral(@"ehicle"">
            <div class=""container"">
                <div class=""section-header text-center"">VEHICLE MODELS <span>FOR RENT</span></div>
                <div class=""row mt-3"">
                    <div class=""car-btn-part d-flex flex-column justify-content-between p-0"">
                        <div class=""car-btn active""><b>BMW</b> 3-SERIES</div>
                        <div class=""car-btn""><b>BMW</b> 4-SERIES</div>
                        <div class=""car-btn""><b>BMW</b> 5-SERIES</div>
                        <div class=""car-btn""><b>BMW</b> M-SERIES</div>
                        <div class=""car-btn""><b>BMW</b> X-SERIES</div>
                        <div class=""car-btn""><b>BMW</b> X-SERIES</div>
                        <div class=""car-btn""><b>BMW</b> X-SERIES</div>
                    </div>
                    <div class=""car-about-part"">
                        <div class=""row h-100"">
                            <div class=""col-7 p-0"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e2e5c88d2ff74bfa4c64bf124c5a347fcc7e810717734", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""col-5 p-0"">
                                <div class=""car-about"">
                                    <div class=""car-price"">
                                        37$ <small>for a rent</small>
                                    </div>
                                    <div class=""car-about-part""><b>Model</b> <span>S series</span></div>
                                    <div class=""car-about-part""><b>Model</b> <span>S series</span></div>
                                    <div class=""car-about-part""><b>Model</b> <span>S series</span></div>
                                    <div class=""car-about-part""><b>Model</b> <span>S series</span></div>
                                    <div class=""car-about-part""><b>Model</b> <span>S series</span></div>
                                    <div class=""car-about-part""><b>Model</b> <span>S series</span></div>
                                    <div class=""car-about-part"">");
            WriteLiteral(@"<b>Model</b> <span>S series</span></div>
                                    <button class=""btn btn-primary ms-auto me-2 mt-2"">Reserve Now</button>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </section>
        <section id=""counter"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-3 text-center"">
                        <div class=""counter-icon""><i class=""fa-solid fa-users""></i></div>
                        <div class=""counter-count"">399</div>
                        <div class=""counter-text"">Happy Client</div>
                    </div>
                    <div class=""col-3 text-center"">
                        <div class=""counter-icon""><i class=""fa-solid fa-users""></i></div>
                        <div class=""counter-count"">399</div>
                        <div class=""counter-text"">Happy Cl");
            WriteLiteral(@"ient</div>
                    </div>
                    <div class=""col-3 text-center"">
                        <div class=""counter-icon""><i class=""fa-solid fa-users""></i></div>
                        <div class=""counter-count"">399</div>
                        <div class=""counter-text"">Happy Client</div>
                    </div>
                    <div class=""col-3 text-center"">
                        <div class=""counter-icon""><i class=""fa-solid fa-users""></i></div>
                        <div class=""counter-count"">399</div>
                        <div class=""counter-text"">Happy Client</div>
                    </div>
                </div>
            </div>
        </section>
        <section id=""Footer-form"">
            <div class=""row"">
                <div class=""col-6"">
                    <div class=""mapouter"">
                        <div class=""gmap_canvas""><iframe width=""944"" height=""500"" id=""gmap_canvas"" src=""https://maps.google.com/maps?q=azerbaycan%20texniki%20uni&t=");
            WriteLiteral(@"&z=13&ie=UTF8&iwloc=&output=embed"" frameborder=""0"" scrolling=""no"" marginheight=""0"" marginwidth=""0""></iframe>
                            <a href=""https://123movies-to.org""></a><br>
                            <style>
                                .mapouter {
                                    position: relative;
                                    text-align: right;
                                    height: 500px;
                                    width: 944px;
                                }
                            </style>
                            <a href=""https://www.embedgooglemap.net""></a>
                            <style>
                                .gmap_canvas {
                                    overflow: hidden;
                                    background: none!important;
                                    height: 500px;
                                    width: 944px;
                                }
                            </style>
              ");
            WriteLiteral("          </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-6 p-0\">\r\n                    <div class=\"footer-form\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2e5c88d2ff74bfa4c64bf124c5a347fcc7e810723363", async() => {
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2e5c88d2ff74bfa4c64bf124c5a347fcc7e810723650", async() => {
                    WriteLiteral(@"
                                <div class=""form-group mt-2"">
                                    <input type=""text"" class=""form-control"">
                                </div>
                                <div class=""form-group mt-2"">
                                    <input type=""text"" class=""form-control"">
                                </div>
                                <div class=""form-group mt-2"">
                                    <input type=""text"" class=""form-control"">
                                </div>
                                <div class=""form-group mt-2"">
                                    <textarea class=""form-control""></textarea>
                                </div>
                                <button class=""btn btn-primary mt-2"">Send</button>
                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </section>\r\n    </main>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591