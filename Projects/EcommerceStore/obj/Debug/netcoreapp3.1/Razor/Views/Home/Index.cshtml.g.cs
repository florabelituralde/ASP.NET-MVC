#pragma checksum "C:\Users\flora\OneDrive\Week 1 MSSA\ASP.NET\EcommerceStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0598d8e212e983832b7c596272e4c78e668a6f3e"
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
#line 1 "C:\Users\flora\OneDrive\Week 1 MSSA\ASP.NET\EcommerceStore\Views\_ViewImports.cshtml"
using EcommerceStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\flora\OneDrive\Week 1 MSSA\ASP.NET\EcommerceStore\Views\_ViewImports.cshtml"
using EcommerceStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0598d8e212e983832b7c596272e4c78e668a6f3e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed5acc9e62e425d692a69e7100a7eb2d5b1079c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/bootstrap/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/shop-homepage.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/jquery/jquery.slim.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\flora\OneDrive\Week 1 MSSA\ASP.NET\EcommerceStore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0598d8e212e983832b7c596272e4c78e668a6f3e5468", async() => {
                WriteLiteral("\r\n\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 242, "\"", 252, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 279, "\"", 289, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n    <title>Shop Homepage - Start Bootstrap Template</title>\r\n\r\n    <!-- Bootstrap core CSS -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0598d8e212e983832b7c596272e4c78e668a6f3e6347", async() => {
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
                WriteLiteral("\r\n\r\n    <!-- Custom styles for this template -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0598d8e212e983832b7c596272e4c78e668a6f3e7578", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0598d8e212e983832b7c596272e4c78e668a6f3e9469", async() => {
                WriteLiteral(@"

    <!-- Navigation -->
    <!--<nav class=""navbar navbar-expand-lg navbar-dark bg-dark fixed-top"">
        <div class=""container"">
            <a class=""navbar-brand"" href=""#"">Start Bootstrap</a>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
                <ul class=""navbar-nav ml-auto"">
                    <li class=""nav-item active"">
                        <a class=""nav-link"" href=""#"">
                            Home
                            <span class=""sr-only"">(current)</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" asp-area="""" asp-controller=""Home"" asp-action=""Privacy"">About</a");
                WriteLiteral(@">
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#"">Services</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#"">Contact</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>-->

    <!-- Page Content -->
    <div class=""container"">

        <div class=""row"">

            <div class=""col-lg-3"">

                <h1 class=""my-4"">Shop Name</h1>
                <div class=""list-group"">
                    <a href=""#"" class=""list-group-item"">Cellphones</a>
                    <a href=""#"" class=""list-group-item"">Tablets</a>
                    <a href=""#"" class=""list-group-item"">Laptops</a>
                </div>

            </div>
            <!-- /.col-lg-3 -->

            <div class=""col-lg-9"">

                <div id=""carouselExampleIndicators"" class=""carousel slide my-4"" data-ride=""carousel""");
                WriteLiteral(@">
                    <ol class=""carousel-indicators"">
                        <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                        <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                        <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
                    </ol>
                    <div class=""carousel-inner"" role=""listbox"">
                        <div class=""carousel-item active"">
                            <img class=""d-block img-fluid"" src=""https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/iphone-accessories-1578414825.png"" alt=""First slide"">
                        </div>
                        <div class=""carousel-item"">
                            <img class=""d-block img-fluid"" src=""https://images.macrumors.com/t/WsvIi0KIslDuVu1Rm-z7n0do0nA=/1600x0/article-new/2019/05/bestiphoneaccessoriesguide.jpg"" alt=""Second slide"">
                        </div>
                 ");
                WriteLiteral(@"       <div class=""carousel-item"">
                            <img class=""d-block img-fluid"" src=""https://i.ytimg.com/vi/dNii5EUxCCQ/maxresdefault.jpg"" alt=""Third slide"">
                        </div>
                    </div>
                    <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Previous</span>
                    </a>
                    <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                        <span class=""sr-only"">Next</span>
                    </a>
                </div>

                <div class=""row"">

                    <div class=""col-lg-4 col-md-6 mb-4"">
                        <div class=""card h-100"">
                 ");
                WriteLiteral("           <a href=\"#\"><img class=\"card-img-top\" src=\"https://images-na.ssl-images-amazon.com/images/I/71Tl4QPddkL._AC_SL1500_.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 4822, "\"", 4828, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                            <div class=""card-body"">
                                <h4 class=""card-title"">
                                    <a href=""https://www.amazon.com/YOUMAKER-iPhone-Protector-Protection-Shockproof/dp/B07K2321LL/ref=sxin_9_ac_d_rm?ac_md=0-0-Y2VsbCBwaG9uZSBjYXNlcw%3D%3D-ac_d_rm&cv_ct_cx=cell+phone+cases&dchild=1&keywords=cell+phone+cases&pd_rd_i=B07K2321LL&pd_rd_r=423813af-31dc-474e-96da-76fcfa9b0a86&pd_rd_w=7RbjD&pd_rd_wg=HHLBI&pf_rd_p=500f114e-2c2f-4a43-bcda-f4dcdd3832f9&pf_rd_r=TT0KEG4TF53Y00NDKAF7&psc=1&qid=1599751310&sr=1-1-12d4272d-8adb-4121-8624-135149aa9081"">Case for iPhone 8 & iPhone 7</a>
                                </h4>
                                <h5>$16.99</h5>
                                <p class=""card-text"">Full Body Rugged with Built-in Screen Protector Heavy Duty Protection Slim Fit Shockproof Cover for Apple iPhone 8 (2017) 4.7 Inch</p>
                            </div>
                            <div class=""card-footer"">
               ");
                WriteLiteral(@"                 <small class=""text-muted"">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-4 col-md-6 mb-4"">
                        <div class=""card h-100"">
                            <a href=""#""><img class=""card-img-top"" src=""https://images-na.ssl-images-amazon.com/images/I/71qldDVOw2L._AC_SL1500_.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 6299, "\"", 6305, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                            <div class=""card-body"">
                                <h4 class=""card-title"">
                                    <a href=""https://www.amazon.com/JETech-iPhone-Shock-Absorption-Bumper-Anti-Scratch/dp/B00M3Q4IFC/ref=sxin_9_ac_d_rm?ac_md=3-3-aXBob25lIDZzIGNhc2U%3D-ac_d_rm&cv_ct_cx=cell+phone+cases&dchild=1&keywords=cell+phone+cases&pd_rd_i=B00M3Q4IFC&pd_rd_r=423813af-31dc-474e-96da-76fcfa9b0a86&pd_rd_w=7RbjD&pd_rd_wg=HHLBI&pf_rd_p=500f114e-2c2f-4a43-bcda-f4dcdd3832f9&pf_rd_r=TT0KEG4TF53Y00NDKAF7&psc=1&qid=1599751310&sr=1-4-12d4272d-8adb-4121-8624-135149aa9081"">Case for iPhone 6 and iPhone 6s</a>
                                </h4>
                                <h5>$15.99</h5>
                                <p class=""card-text"">Shock-Absorption Bumper Cover, Anti-Scratch Clear Back, HD Clear</p>
                            </div>
                            <div class=""card-footer"">
                                <small class=""text-muted"">&#9733; &#9733; &#9733;");
                WriteLiteral(@" &#9733; &#9734;</small>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-4 col-md-6 mb-4"">
                        <div class=""card h-100"">
                            <a href=""#""><img class=""card-img-top"" src=""https://images-na.ssl-images-amazon.com/images/I/71Zm2u-82WL._AC_SL1000_.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 7710, "\"", 7716, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                            <div class=""card-body"">
                                <h4 class=""card-title"">
                                    <a href=""https://www.amazon.com/UrSpeedtekLive-Premium-Leather-Wristlet-Samsung/dp/B01GPILLD0/ref=sxin_9_ac_d_rm?ac_md=2-2-c2Ftc3VuZyBjZWxsIHBob25lIGNhc2U%3D-ac_d_rm&cv_ct_cx=cell+phone+cases&dchild=1&keywords=cell+phone+cases&pd_rd_i=B01GPILLD0&pd_rd_r=423813af-31dc-474e-96da-76fcfa9b0a86&pd_rd_w=7RbjD&pd_rd_wg=HHLBI&pf_rd_p=500f114e-2c2f-4a43-bcda-f4dcdd3832f9&pf_rd_r=TT0KEG4TF53Y00NDKAF7&psc=1&qid=1599751310&sr=1-3-12d4272d-8adb-4121-8624-135149aa9081"">Galaxy S7 Wallet Case</a>
                                </h4>
                                <h5>$24.99</h5>
                                <p class=""card-text"">Premium PU Leather Wristlet Flip Case Cover with Card Slots & Stand for Samsung Galaxy S7, Love Tree Pattern</p>
                            </div>
                            <div class=""card-footer"">
                                <small");
                WriteLiteral(@" class=""text-muted"">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-4 col-md-6 mb-4"">
                        <div class=""card h-100"">
                            <a href=""#""><img class=""card-img-top"" src=""https://images-na.ssl-images-amazon.com/images/I/81k9S55CZ1L._AC_SL1500_.jpg""/>"" alt=""""></a>
                            <div class=""card-body"">
                                <h4 class=""card-title"">
                                    <a href=""https://www.amazon.com/i-Blason-Release-Full-Body-Protective-Protector/dp/B07W6MV7HF/ref=sr_1_2?crid=22AA1VO4MX371&dchild=1&keywords=cell+phone+case+for+iphone+11+pro+max&qid=1599751977&sprefix=cellphone+cases+%2Caps%2C191&sr=8-2"">Cosmo Series Case for iPhone 11 Pro Max</a>
                                </h4>
                                <h5>$19.99</h5>
                                <p class=""card-text"">2019 Release");
                WriteLiteral(@", Slim Full-Body Stylish Protective Case with Built-in Screen Protector (Marble)</p>
                            </div>
                            <div class=""card-footer"">
                                <small class=""text-muted"">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-4 col-md-6 mb-4"">
                        <div class=""card h-100"">
                            <a href=""#""><img class=""card-img-top"" src=""https://images-na.ssl-images-amazon.com/images/I/616Xf4rET4L._AC_SL1002_.jpg""/>"" alt=""""></a>
                            <div class=""card-body"">
                                <h4 class=""card-title"">
                                    <a href=""https://www.amazon.com/dp/B08CXP74H8/ref=sspa_dk_detail_2?psc=1&pd_rd_i=B08CXP74H8&pd_rd_w=fAYi3&pf_rd_p=f0355a48-7e73-489a-9590-564e12837b93&pd_rd_wg=zj3GP&pf_rd_r=QZ1QT12RWNX4DEG2Y154&pd_rd_r=9eec6068-6e7c-45ff-b");
                WriteLiteral(@"217-a2760915ee04&spLa=ZW5jcnlwdGVkUXVhbGlmaWVyPUExSkJOWkhGNDVaRjBUJmVuY3J5cHRlZElkPUEwNjg1Mjk4MlVTQ0VQSkNFM01JVSZlbmNyeXB0ZWRBZElkPUEwMTY0MTIzMjIyVVdLUDNXRUgzMiZ3aWRnZXROYW1lPXNwX2RldGFpbF90aGVtYXRpYyZhY3Rpb249Y2xpY2tSZWRpcmVjdCZkb05vdExvZ0NsaWNrPXRydWU="">Cosmo Snap Case Designed for iPhone Xs (2018) / iPhone X (2017)</a>
                                </h4>
                                <h5>$17.99</h5>
                                <p class=""card-text"">Slim Full-Body Stylish Protective Case with Built-in Screen Protector (Marble)</p>
                            </div>
                            <div class=""card-footer"">
                                <small class=""text-muted"">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
                            </div>
                        </div>
                    </div>

                    <div class=""col-lg-4 col-md-6 mb-4"">
                        <div class=""card h-100"">
                            <a href=""#""><img class=""card-img-top"" src=");
                WriteLiteral("\"https://images-na.ssl-images-amazon.com/images/I/71lJz27xImL._AC_SL1200_.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 11891, "\"", 11897, 0);
                EndWriteAttribute();
                WriteLiteral(@"></a>
                            <div class=""card-body"">
                                <h4 class=""card-title"">
                                    <a href=""https://www.amazon.com/dp/B07YKGC5ZP/ref=sspa_dk_detail_1?psc=1&pd_rd_i=B07YKGC5ZP&pd_rd_w=bbx0h&pf_rd_p=f0355a48-7e73-489a-9590-564e12837b93&pd_rd_wg=eTHiJ&pf_rd_r=4031XXD9TAX2SGY85AD1&pd_rd_r=c87567e9-cbe2-4537-86fd-1c9b89bcd9c2&spLa=ZW5jcnlwdGVkUXVhbGlmaWVyPUEzRklJSVg3Ulo5R0lRJmVuY3J5cHRlZElkPUEwODEyODA2MUFCMUFDTkVLMkhNNCZlbmNyeXB0ZWRBZElkPUEwMTE2NjMxMzk1QUZCVFkzNTVXViZ3aWRnZXROYW1lPXNwX2RldGFpbF90aGVtYXRpYyZhY3Rpb249Y2xpY2tSZWRpcmVjdCZkb05vdExvZ0NsaWNrPXRydWU="">Marble iPhone 11 Pro Max Case</a>
                                </h4>
                                <h5>$15.99</h5>
                                <p class=""card-text"">Slim Thin Glossy Soft TPU Rubber Gel Phone Case Cover Compatible iPhone 11 Pro Max 6.5 Inch 2019 Release (Green/Gold)</p>
                            </div>
                            <div class=""card-footer"">
  ");
                WriteLiteral(@"                              <small class=""text-muted"">&#9733; &#9733; &#9733; &#9733; &#9734;</small>
                            </div>
                        </div>
                    </div>

                </div>
                <!-- /.row -->

            </div>
            <!-- /.col-lg-9 -->

        </div>
        <!-- /.row -->

    </div>
    <!-- /.container -->
    <!-- Footer -->
    <!--<footer class=""py-5 bg-dark"">
        <div class=""container"">
            <p class=""m-0 text-center text-white"">Copyright &copy; Your Website 2020</p>
        </div>-->
        <!-- /.container -->
    <!--</footer>-->

    <!-- Bootstrap core JavaScript -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0598d8e212e983832b7c596272e4c78e668a6f3e24027", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0598d8e212e983832b7c596272e4c78e668a6f3e25127", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
