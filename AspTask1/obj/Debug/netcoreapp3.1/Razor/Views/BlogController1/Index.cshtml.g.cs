#pragma checksum "C:\Users\ASUS\source\repos\AspTask1\AspTask1\Views\BlogController1\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c43ead7a0fc638c8b0f9e60db2127a0cdf725b82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BlogController1_Index), @"mvc.1.0.view", @"/Views/BlogController1/Index.cshtml")]
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
#line 1 "C:\Users\ASUS\source\repos\AspTask1\AspTask1\Views\_ViewImports.cshtml"
using AspTask1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\AspTask1\AspTask1\Views\_ViewImports.cshtml"
using AspTask1.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c43ead7a0fc638c8b0f9e60db2127a0cdf725b82", @"/Views/BlogController1/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9128b13efcaa8d38bba9083bb9a4dd19c821633", @"/Views/_ViewImports.cshtml")]
    public class Views_BlogController1_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex justify-content-between"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\AspTask1\AspTask1\Views\BlogController1\Index.cshtml"
  
    ViewData["Title"] = "Blog";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<header class=""header_area sticky-header"">
    <div class=""main_menu"">
        <nav class=""navbar navbar-expand-lg navbar-light main_box"">
            <div class=""container"">
                <!-- Brand and toggle get grouped for better mobile display -->
                <a class=""navbar-brand logo_h"" href=""index.html""><img src=""img/logo.png""");
            BeginWriteAttribute("alt", " alt=\"", 392, "\"", 398, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent""
                        aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </button>
                <!-- Collect the nav links, forms, and other content for toggling -->
                <div class=""collapse navbar-collapse offset"" id=""navbarSupportedContent"">
                    <ul class=""nav navbar-nav menu_nav ml-auto"">
                        <li class=""nav-item""><a class=""nav-link"" href=""index.html"">Home</a></li>
                        <li class=""nav-item submenu dropdown"">
                            <a href=""#"" class=""nav-link dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true""
                               aria-expanded=""false"">Sh");
            WriteLiteral(@"op</a>
                            <ul class=""dropdown-menu"">
                                <li class=""nav-item""><a class=""nav-link"" href=""category.html"">Shop Category</a></li>
                                <li class=""nav-item""><a class=""nav-link"" href=""single-product.html"">Product Details</a></li>
                                <li class=""nav-item""><a class=""nav-link"" href=""checkout.html"">Product Checkout</a></li>
                                <li class=""nav-item""><a class=""nav-link"" href=""cart.html"">Shopping Cart</a></li>
                                <li class=""nav-item""><a class=""nav-link"" href=""confirmation.html"">Confirmation</a></li>
                            </ul>
                        </li>
                        <li class=""nav-item submenu dropdown active"">
                            <a href=""#"" class=""nav-link dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true""
                               aria-expanded=""false"">Blog</a>
                            ");
            WriteLiteral(@"<ul class=""dropdown-menu"">
                                <li class=""nav-item active""><a class=""nav-link"" href=""blog.html"">Blog</a></li>
                                <li class=""nav-item""><a class=""nav-link"" href=""single-blog.html"">Blog Details</a></li>
                            </ul>
                        </li>
                        <li class=""nav-item submenu dropdown"">
                            <a href=""#"" class=""nav-link dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true""
                               aria-expanded=""false"">Pages</a>
                            <ul class=""dropdown-menu"">
                                <li class=""nav-item""><a class=""nav-link"" href=""login.html"">Login</a></li>
                                <li class=""nav-item""><a class=""nav-link"" href=""tracking.html"">Tracking</a></li>
                                <li class=""nav-item""><a class=""nav-link"" href=""elements.html"">Elements</a></li>
                            </ul>
              ");
            WriteLiteral(@"          </li>
                        <li class=""nav-item""><a class=""nav-link"" href=""contact.html"">Contact</a></li>
                    </ul>
                    <ul class=""nav navbar-nav navbar-right"">
                        <li class=""nav-item""><a href=""#"" class=""cart""><span class=""ti-bag""></span></a></li>
                        <li class=""nav-item"">
                            <button class=""search""><span class=""lnr lnr-magnifier"" id=""search""></span></button>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    </div>
    <div class=""search_input"" id=""search_input_box"">
        <div class=""container"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c43ead7a0fc638c8b0f9e60db2127a0cdf725b828390", async() => {
                WriteLiteral(@"
                <input type=""text"" class=""form-control"" id=""search_input"" placeholder=""Search Here"">
                <button type=""submit"" class=""btn""></button>
                <span class=""lnr lnr-cross"" id=""close_search"" title=""Close Search""></span>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
</header>
<!-- End Header Area -->
<!-- Start Banner Area -->
<section class=""banner-area organic-breadcrumb"">
    <div class=""container"">
        <div class=""breadcrumb-banner d-flex flex-wrap align-items-center justify-content-end"">
            <div class=""col-first"">
                <h1>Blog Page</h1>
                <nav class=""d-flex align-items-center"">
                    <a href=""index.html"">Home<span class=""lnr lnr-arrow-right""></span></a>
                    <a href=""category.html"">Blog</a>
                </nav>
            </div>
        </div>
    </div>
</section>
<!-- End Banner Area -->
<!--================Blog Categorie Area =================-->
<section class=""blog_categorie_area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4"">
                <div class=""categories_post"">
                    <img src=""img/blog/cat-post/cat-post-3.jpg"" alt=""post"">
                    <div class=""categories_details");
            WriteLiteral(@""">
                        <div class=""categories_text"">
                            <a href=""blog-details.html"">
                                <h5>Social Life</h5>
                            </a>
                            <div class=""border_line""></div>
                            <p>Enjoy your social life together</p>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""categories_post"">
                    <img src=""img/blog/cat-post/cat-post-2.jpg"" alt=""post"">
                    <div class=""categories_details"">
                        <div class=""categories_text"">
                            <a href=""blog-details.html"">
                                <h5>Politics</h5>
                            </a>
                            <div class=""border_line""></div>
                            <p>Be a part of politics</p>
                        </div>
                    </d");
            WriteLiteral(@"iv>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""categories_post"">
                    <img src=""img/blog/cat-post/cat-post-1.jpg"" alt=""post"">
                    <div class=""categories_details"">
                        <div class=""categories_text"">
                            <a href=""blog-details.html"">
                                <h5>Food</h5>
                            </a>
                            <div class=""border_line""></div>
                            <p>Let the food be finished</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!--================Blog Categorie Area =================-->
<!--================Blog Area =================-->
<section class=""blog_area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-8"">
                <div class=""blog_left_sidebar"">
                 ");
            WriteLiteral(@"   <article class=""row blog_item"">
                        <div class=""col-md-3"">
                            <div class=""blog_info text-right"">
                                <div class=""post_tag"">
                                    <a href=""#"">Food,</a>
                                    <a class=""active"" href=""#"">Technology,</a>
                                    <a href=""#"">Politics,</a>
                                    <a href=""#"">Lifestyle</a>
                                </div>
                                <ul class=""blog_meta list"">
                                    <li><a href=""#"">Mark wiens<i class=""lnr lnr-user""></i></a></li>
                                    <li><a href=""#"">12 Dec, 2018<i class=""lnr lnr-calendar-full""></i></a></li>
                                    <li><a href=""#"">1.2M Views<i class=""lnr lnr-eye""></i></a></li>
                                    <li><a href=""#"">06 Comments<i class=""lnr lnr-bubble""></i></a></li>
                                </ul>");
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-md-9\">\r\n                            <div class=\"blog_post\">\r\n                                <img src=\"img/blog/main-blog/m-blog-1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 8840, "\"", 8846, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <div class=""blog_details"">
                                    <a href=""single-blog.html"">
                                        <h2>Astronomy Binoculars A Great Alternative</h2>
                                    </a>
                                    <p>
                                        MCSE boot camps have its supporters and its detractors. Some people do not
                                        understand why you should have to spend money on boot camp when you can get
                                        the MCSE study materials yourself at a fraction.
                                    </p>
                                    <a href=""single-blog.html"" class=""white_bg_btn"">View More</a>
                                </div>
                            </div>
                        </div>
                    </article>
                    <article class=""row blog_item"">
                        <div class=""col-md-3"">
                 ");
            WriteLiteral(@"           <div class=""blog_info text-right"">
                                <div class=""post_tag"">
                                    <a href=""#"">Food,</a>
                                    <a class=""active"" href=""#"">Technology,</a>
                                    <a href=""#"">Politics,</a>
                                    <a href=""#"">Lifestyle</a>
                                </div>
                                <ul class=""blog_meta list"">
                                    <li><a href=""#"">Mark wiens<i class=""lnr lnr-user""></i></a></li>
                                    <li><a href=""#"">12 Dec, 2018<i class=""lnr lnr-calendar-full""></i></a></li>
                                    <li><a href=""#"">1.2M Views<i class=""lnr lnr-eye""></i></a></li>
                                    <li><a href=""#"">06 Comments<i class=""lnr lnr-bubble""></i></a></li>
                                </ul>
                            </div>
                        </div>
                        <div cl");
            WriteLiteral("ass=\"col-md-9\">\r\n                            <div class=\"blog_post\">\r\n                                <img src=\"img/blog/main-blog/m-blog-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 11039, "\"", 11045, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <div class=""blog_details"">
                                    <a href=""single-blog.html"">
                                        <h2>The Basics Of Buying A Telescope</h2>
                                    </a>
                                    <p>
                                        MCSE boot camps have its supporters and its detractors. Some people do not
                                        understand why you should have to spend money on boot camp when you can get
                                        the MCSE study materials yourself at a fraction.
                                    </p>
                                    <a href=""single-blog.html"" class=""white_bg_btn"">View More</a>
                                </div>
                            </div>
                        </div>
                    </article>
                    <article class=""row blog_item"">
                        <div class=""col-md-3"">
                         ");
            WriteLiteral(@"   <div class=""blog_info text-right"">
                                <div class=""post_tag"">
                                    <a href=""#"">Food,</a>
                                    <a class=""active"" href=""#"">Technology,</a>
                                    <a href=""#"">Politics,</a>
                                    <a href=""#"">Lifestyle</a>
                                </div>
                                <ul class=""blog_meta list"">
                                    <li><a href=""#"">Mark wiens<i class=""lnr lnr-user""></i></a></li>
                                    <li><a href=""#"">12 Dec, 2018<i class=""lnr lnr-calendar-full""></i></a></li>
                                    <li><a href=""#"">1.2M Views<i class=""lnr lnr-eye""></i></a></li>
                                    <li><a href=""#"">06 Comments<i class=""lnr lnr-bubble""></i></a></li>
                                </ul>
                            </div>
                        </div>
                        <div class=""col");
            WriteLiteral("-md-9\">\r\n                            <div class=\"blog_post\">\r\n                                <img src=\"img/blog/main-blog/m-blog-3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 13230, "\"", 13236, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <div class=""blog_details"">
                                    <a href=""single-blog.html"">
                                        <h2>The Glossary Of Telescopes</h2>
                                    </a>
                                    <p>
                                        MCSE boot camps have its supporters and its detractors. Some people do not
                                        understand why you should have to spend money on boot camp when you can get
                                        the MCSE study materials yourself at a fraction.
                                    </p>
                                    <a href=""single-blog.html"" class=""white_bg_btn"">View More</a>
                                </div>
                            </div>
                        </div>
                    </article>
                    <article class=""row blog_item"">
                        <div class=""col-md-3"">
                            <di");
            WriteLiteral(@"v class=""blog_info text-right"">
                                <div class=""post_tag"">
                                    <a href=""#"">Food,</a>
                                    <a class=""active"" href=""#"">Technology,</a>
                                    <a href=""#"">Politics,</a>
                                    <a href=""#"">Lifestyle</a>
                                </div>
                                <ul class=""blog_meta list"">
                                    <li><a href=""#"">Mark wiens<i class=""lnr lnr-user""></i></a></li>
                                    <li><a href=""#"">12 Dec, 2018<i class=""lnr lnr-calendar-full""></i></a></li>
                                    <li><a href=""#"">1.2M Views<i class=""lnr lnr-eye""></i></a></li>
                                    <li><a href=""#"">06 Comments<i class=""lnr lnr-bubble""></i></a></li>
                                </ul>
                            </div>
                        </div>
                        <div class=""col-md-9""");
            WriteLiteral(">\r\n                            <div class=\"blog_post\">\r\n                                <img src=\"img/blog/main-blog/m-blog-4.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 15415, "\"", 15421, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <div class=""blog_details"">
                                    <a href=""single-blog.html"">
                                        <h2>The Night Sky</h2>
                                    </a>
                                    <p>
                                        MCSE boot camps have its supporters and its detractors. Some people do not
                                        understand why you should have to spend money on boot camp when you can get
                                        the MCSE study materials yourself at a fraction.
                                    </p>
                                    <a href=""single-blog.html"" class=""white_bg_btn"">View More</a>
                                </div>
                            </div>
                        </div>
                    </article>
                    <article class=""row blog_item"">
                        <div class=""col-md-3"">
                            <div class=""blog");
            WriteLiteral(@"_info text-right"">
                                <div class=""post_tag"">
                                    <a href=""#"">Food,</a>
                                    <a class=""active"" href=""#"">Technology,</a>
                                    <a href=""#"">Politics,</a>
                                    <a href=""#"">Lifestyle</a>
                                </div>
                                <ul class=""blog_meta list"">
                                    <li><a href=""#"">Mark wiens<i class=""lnr lnr-user""></i></a></li>
                                    <li><a href=""#"">12 Dec, 2018<i class=""lnr lnr-calendar-full""></i></a></li>
                                    <li><a href=""#"">1.2M Views<i class=""lnr lnr-eye""></i></a></li>
                                    <li><a href=""#"">06 Comments<i class=""lnr lnr-bubble""></i></a></li>
                                </ul>
                            </div>
                        </div>
                        <div class=""col-md-9"">
          ");
            WriteLiteral("                  <div class=\"blog_post\">\r\n                                <img src=\"img/blog/main-blog/m-blog-5.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 17587, "\"", 17593, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <div class=""blog_details"">
                                    <a href=""single-blog.html"">
                                        <h2>Telescopes 101</h2>
                                    </a>
                                    <p>
                                        MCSE boot camps have its supporters and its detractors. Some people do not
                                        understand why you should have to spend money on boot camp when you can get
                                        the MCSE study materials yourself at a fraction.
                                    </p>
                                    <a href=""single-blog.html"" class=""white_bg_btn"">View More</a>
                                </div>
                            </div>
                        </div>
                    </article>
                    <nav class=""blog-pagination justify-content-center d-flex"">
                        <ul class=""pagination"">
              ");
            WriteLiteral(@"              <li class=""page-item"">
                                <a href=""#"" class=""page-link"" aria-label=""Previous"">
                                    <span aria-hidden=""true"">
                                        <span class=""lnr lnr-chevron-left""></span>
                                    </span>
                                </a>
                            </li>
                            <li class=""page-item""><a href=""#"" class=""page-link"">01</a></li>
                            <li class=""page-item active""><a href=""#"" class=""page-link"">02</a></li>
                            <li class=""page-item""><a href=""#"" class=""page-link"">03</a></li>
                            <li class=""page-item""><a href=""#"" class=""page-link"">04</a></li>
                            <li class=""page-item""><a href=""#"" class=""page-link"">09</a></li>
                            <li class=""page-item"">
                                <a href=""#"" class=""page-link"" aria-label=""Next"">
                             ");
            WriteLiteral(@"       <span aria-hidden=""true"">
                                        <span class=""lnr lnr-chevron-right""></span>
                                    </span>
                                </a>
                            </li>
                        </ul>
                    </nav>
                </div>
            </div>
            <div class=""col-lg-4"">
                <div class=""blog_right_sidebar"">
                    <aside class=""single_sidebar_widget search_widget"">
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control"" placeholder=""Search Posts"" onfocus=""this.placeholder = ''"" onblur=""this.placeholder = 'Search Posts'"">
                            <span class=""input-group-btn"">
                                <button class=""btn btn-default"" type=""button""><i class=""lnr lnr-magnifier""></i></button>
                            </span>
                        </div><!-- /input-group -->
                        <div c");
            WriteLiteral("lass=\"br\"></div>\r\n                    </aside>\r\n                    <aside class=\"single_sidebar_widget author_widget\">\r\n                        <img class=\"author_img rounded-circle\" src=\"img/blog/author.png\"");
            BeginWriteAttribute("alt", " alt=\"", 20875, "\"", 20881, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <h4>Charlie Barber</h4>
                        <p>Senior blog writer</p>
                        <div class=""social_icon"">
                            <a href=""#""><i class=""fa fa-facebook""></i></a>
                            <a href=""#""><i class=""fa fa-twitter""></i></a>
                            <a href=""#""><i class=""fa fa-github""></i></a>
                            <a href=""#""><i class=""fa fa-behance""></i></a>
                        </div>
                        <p>
                            Boot camps have its supporters andit sdetractors. Some people do not understand why you
                            should have to spend money on boot camp when you can get. Boot camps have itssuppor
                            ters andits detractors.
                        </p>
                        <div class=""br""></div>
                    </aside>
                    <aside class=""single_sidebar_widget popular_post_widget"">
                        <h3 class=""widg");
            WriteLiteral(@"et_title"">Popular Posts</h3>
                        <div class=""media post_item"">
                            <img src=""img/blog/popular-post/post1.jpg"" alt=""post"">
                            <div class=""media-body"">
                                <a href=""blog-details.html"">
                                    <h3>Space The Final Frontier</h3>
                                </a>
                                <p>02 Hours ago</p>
                            </div>
                        </div>
                        <div class=""media post_item"">
                            <img src=""img/blog/popular-post/post2.jpg"" alt=""post"">
                            <div class=""media-body"">
                                <a href=""blog-details.html"">
                                    <h3>The Amazing Hubble</h3>
                                </a>
                                <p>02 Hours ago</p>
                            </div>
                        </div>
                        <div c");
            WriteLiteral(@"lass=""media post_item"">
                            <img src=""img/blog/popular-post/post3.jpg"" alt=""post"">
                            <div class=""media-body"">
                                <a href=""blog-details.html"">
                                    <h3>Astronomy Or Astrology</h3>
                                </a>
                                <p>03 Hours ago</p>
                            </div>
                        </div>
                        <div class=""media post_item"">
                            <img src=""img/blog/popular-post/post4.jpg"" alt=""post"">
                            <div class=""media-body"">
                                <a href=""blog-details.html"">
                                    <h3>Asteroids telescope</h3>
                                </a>
                                <p>01 Hours ago</p>
                            </div>
                        </div>
                        <div class=""br""></div>
                    </aside>
             ");
            WriteLiteral("       <aside class=\"single_sidebar_widget ads_widget\">\r\n                        <a href=\"#\"><img class=\"img-fluid\" src=\"img/blog/add.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 24092, "\"", 24098, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                        <div class=""br""></div>
                    </aside>
                    <aside class=""single_sidebar_widget post_category_widget"">
                        <h4 class=""widget_title"">Post Catgories</h4>
                        <ul class=""list cat-list"">
                            <li>
                                <a href=""#"" class=""d-flex justify-content-between"">
                                    <p>Technology</p>
                                    <p>37</p>
                                </a>
                            </li>
                            <li>
                                <a href=""#"" class=""d-flex justify-content-between"">
                                    <p>Lifestyle</p>
                                    <p>24</p>
                                </a>
                            </li>
                            <li>
                                <a href=""#"" class=""d-flex justify-content-between"">
                               ");
            WriteLiteral(@"     <p>Fashion</p>
                                    <p>59</p>
                                </a>
                            </li>
                            <li>
                                <a href=""#"" class=""d-flex justify-content-between"">
                                    <p>Art</p>
                                    <p>29</p>
                                </a>
                            </li>
                            <li>
                                <a href=""#"" class=""d-flex justify-content-between"">
                                    <p>Food</p>
                                    <p>15</p>
                                </a>
                            </li>
                            <li>
                                <a href=""#"" class=""d-flex justify-content-between"">
                                    <p>Architecture</p>
                                    <p>09</p>
                                </a>
                            </li>
            ");
            WriteLiteral(@"                <li>
                                <a href=""#"" class=""d-flex justify-content-between"">
                                    <p>Adventure</p>
                                    <p>44</p>
                                </a>
                            </li>
                        </ul>
                        <div class=""br""></div>
                    </aside>
                    <aside class=""single-sidebar-widget newsletter_widget"">
                        <h4 class=""widget_title"">Newsletter</h4>
                        <p>
                            Here, I focus on a range of items and features that we use in life without
                            giving them a second thought.
                        </p>
                        <div class=""form-group d-flex flex-row"">
                            <div class=""input-group"">
                                <div class=""input-group-prepend"">
                                    <div class=""input-group-text""><i class=""fa fa");
            WriteLiteral(@"-envelope"" aria-hidden=""true""></i></div>
                                </div>
                                <input type=""text"" class=""form-control"" id=""inlineFormInputGroup"" placeholder=""Enter email""
                                       onfocus=""this.placeholder = ''"" onblur=""this.placeholder = 'Enter email'"">
                            </div>
                            <a href=""#"" class=""bbtns"">Subcribe</a>
                        </div>
                        <p class=""text-bottom"">You can unsubscribe at any time</p>
                        <div class=""br""></div>
                    </aside>
                    <aside class=""single-sidebar-widget tag_cloud_widget"">
                        <h4 class=""widget_title"">Tag Clouds</h4>
                        <ul class=""list"">
                            <li><a href=""#"">Technology</a></li>
                            <li><a href=""#"">Fashion</a></li>
                            <li><a href=""#"">Architecture</a></li>
                         ");
            WriteLiteral(@"   <li><a href=""#"">Fashion</a></li>
                            <li><a href=""#"">Food</a></li>
                            <li><a href=""#"">Technology</a></li>
                            <li><a href=""#"">Lifestyle</a></li>
                            <li><a href=""#"">Art</a></li>
                            <li><a href=""#"">Adventure</a></li>
                            <li><a href=""#"">Food</a></li>
                            <li><a href=""#"">Lifestyle</a></li>
                            <li><a href=""#"">Adventure</a></li>
                        </ul>
                    </aside>
                </div>
            </div>
        </div>
    </div>
</section>
<!--================Blog Area =================-->
");
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