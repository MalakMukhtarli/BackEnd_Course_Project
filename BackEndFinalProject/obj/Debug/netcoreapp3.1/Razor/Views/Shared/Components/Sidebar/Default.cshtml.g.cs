#pragma checksum "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Views\Shared\Components\Sidebar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dc9958af70d08d2e39fc5dc5c15c758432588d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Sidebar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Sidebar/Default.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Views\_ViewImports.cshtml"
using BackEndFinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Views\_ViewImports.cshtml"
using BackEndFinalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Views\_ViewImports.cshtml"
using BackEndFinalProject.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dc9958af70d08d2e39fc5dc5c15c758432588d0", @"/Views/Shared/Components/Sidebar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ac601a71bb7caec27c481c4a5d21715690b9fa9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Sidebar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SidebarVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Select", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/blog/blog-img.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:95px!important; height:85px!important"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"col-md-4\">\r\n    <div class=\"blog-sidebar right\">\r\n        <div class=\"single-blog-widget mb-47\">\r\n            <h3>search</h3>\r\n            <div class=\"blog-search\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dc9958af70d08d2e39fc5dc5c15c758432588d06499", async() => {
                WriteLiteral("\r\n                    <input type=\"search\" placeholder=\"Search...\" name=\"search\" />\r\n                    <button type=\"submit\">\r\n                        <span><i class=\"fa fa-search\"></i></span>\r\n                    </button>\r\n                ");
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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"single-blog-widget mb-47\">\r\n            <h3>categories</h3>\r\n            <ul>\r\n");
#nullable restore
#line 18 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Views\Shared\Components\Sidebar\Default.cshtml"
                 foreach (Category category in Model.Categories)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dc9958af70d08d2e39fc5dc5c15c758432588d08633", async() => {
#nullable restore
#line 20 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Views\Shared\Components\Sidebar\Default.cshtml"
                                                                      Write(category.Name);

#line default
#line hidden
#nullable disable
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
#nullable restore
#line 20 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Views\Shared\Components\Sidebar\Default.cshtml"
                                                 WriteLiteral(category.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 21 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Views\Shared\Components\Sidebar\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n        <div class=\"single-blog-widget mb-47\">\r\n            <div class=\"single-blog-banner\">\r\n                <a href=\"blog-details.html\" id=\"blog\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1dc9958af70d08d2e39fc5dc5c15c758432588d011514", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                <h2>best<br> eductaion<br> theme</h2>\r\n            </div>\r\n        </div>\r\n        <div class=\"single-blog-widget mb-47\">\r\n            <h3>latest post</h3>\r\n");
#nullable restore
#line 32 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Views\Shared\Components\Sidebar\Default.cshtml"
             foreach (Blog blog in Model.Blogs)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"single-post mb-30\">\r\n                        <div class=\"single-post-img\">\r\n                            <a href=\"blog-details.html\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1dc9958af70d08d2e39fc5dc5c15c758432588d013318", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1523, "~/assets/img/blog/", 1523, 18, true);
#nullable restore
#line 37 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Views\Shared\Components\Sidebar\Default.cshtml"
AddHtmlAttributeValue("", 1541, blog.Image, 1541, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                <div class=""blog-hover"">
                                    <i class=""fa fa-link""></i>
                                </div>
                            </a>
                        </div>
                        <div class=""single-post-content"">
");
#nullable restore
#line 44 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Views\Shared\Components\Sidebar\Default.cshtml"
                             if (blog.Title.Length > 20)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h4><a href=\"blog-details.html\">");
#nullable restore
#line 46 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Views\Shared\Components\Sidebar\Default.cshtml"
                                                           Write(blog.Title.Substring(0, 20));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n");
#nullable restore
#line 47 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Views\Shared\Components\Sidebar\Default.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h4><a href=\"blog-details.html\">");
#nullable restore
#line 50 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Views\Shared\Components\Sidebar\Default.cshtml"
                                                           Write(blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n");
#nullable restore
#line 51 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Views\Shared\Components\Sidebar\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>By ");
#nullable restore
#line 52 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Views\Shared\Components\Sidebar\Default.cshtml"
                             Write(blog.ByName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  /  ");
#nullable restore
#line 52 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Views\Shared\Components\Sidebar\Default.cshtml"
                                              Write(blog.AddedTime.ToString("MMMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 52 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Views\Shared\Components\Sidebar\Default.cshtml"
                                                                               Write(blog.AddedTime.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 52 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Views\Shared\Components\Sidebar\Default.cshtml"
                                                                                                    Write(blog.AddedTime.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 55 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Views\Shared\Components\Sidebar\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <div class=""single-blog-widget"">
            <h3>tags</h3>
            <div class=""single-tag"">
                <a href=""blog-details.html"" class=""mr-10 mb-10"">course</a>
                <a href=""blog-details.html"" class=""mr-10 mb-10"">education</a>
                <a href=""blog-details.html"" class=""mb-10"">teachers</a>
                <a href=""blog-details.html"" class=""mr-10"">learning</a>
                <a href=""blog-details.html"" class=""mr-10"">university</a>
                <a href=""blog-details.html"">events</a>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SidebarVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
