#pragma checksum "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Areas\Admin\Views\Courses\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9c0218b7dd22e06a56e3d0cb3c92817ac08dded"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Courses_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Courses/Detail.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Areas\Admin\Views\_ViewImports.cshtml"
using BackEndFinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Areas\Admin\Views\_ViewImports.cshtml"
using BackEndFinalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Areas\Admin\Views\_ViewImports.cshtml"
using BackEndFinalProject.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9c0218b7dd22e06a56e3d0cb3c92817ac08dded", @"/Areas/Admin/Views/Courses/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ac601a71bb7caec27c481c4a5d21715690b9fa9", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Courses_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Course>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("courses-details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary mt-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Areas\Admin\Views\Courses\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""courses-details-area blog-area pt-150 pb-140"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8"">
                <div class=""courses-details"">
                    <div class=""courses-details-img"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d9c0218b7dd22e06a56e3d0cb3c92817ac08dded5511", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 349, "~/assets/img/course/", 349, 20, true);
#nullable restore
#line 13 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Areas\Admin\Views\Courses\Detail.cshtml"
AddHtmlAttributeValue("", 369, Model.Image, 369, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"course-details-content\">\r\n                        <h2>");
#nullable restore
#line 16 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Areas\Admin\Views\Courses\Detail.cshtml"
                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <p>");
#nullable restore
#line 17 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Areas\Admin\Views\Courses\Detail.cshtml"
                      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <div class=\"course-details-left\">\r\n                            <div class=\"single-course-left\">\r\n                                <h3>about course</h3>\r\n                                <p>");
#nullable restore
#line 21 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Areas\Admin\Views\Courses\Detail.cshtml"
                              Write(Model.CourseDetail.CourseAbout);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"single-course-left\">\r\n                                <h3>how to apply</h3>\r\n                                <p>");
#nullable restore
#line 25 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Areas\Admin\Views\Courses\Detail.cshtml"
                              Write(Model.CourseDetail.HowToApply);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"single-course-left\">\r\n                                <h3>certification</h3>\r\n                                ");
#nullable restore
#line 29 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Areas\Admin\Views\Courses\Detail.cshtml"
                           Write(Html.Raw(Model.CourseDetail.Certification));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""course-details-right"">
                            <h3>COURSE FEATURES</h3>
                            <ul>
                                <li>starts <span>");
#nullable restore
#line 35 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Areas\Admin\Views\Courses\Detail.cshtml"
                                            Write(Model.CourseDetail.CourseStartDate.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 35 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Areas\Admin\Views\Courses\Detail.cshtml"
                                                                                    Write(Model.CourseDetail.CourseStartDate.ToString("MMMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 35 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Areas\Admin\Views\Courses\Detail.cshtml"
                                                                                                                                          Write(Model.CourseDetail.CourseStartDate.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                <li>duration <span>");
#nullable restore
#line 36 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Areas\Admin\Views\Courses\Detail.cshtml"
                                              Write(Model.CourseDetail.CourseDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" MONTH</span></li>\r\n                                <li>class duration <span>");
#nullable restore
#line 37 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Areas\Admin\Views\Courses\Detail.cshtml"
                                                    Write(Model.CourseDetail.ClassDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" hours</span></li>\r\n                                <li>skill level <span>");
#nullable restore
#line 38 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Areas\Admin\Views\Courses\Detail.cshtml"
                                                 Write(Model.CourseDetail.SkillLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                <li>language <span>");
#nullable restore
#line 39 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Areas\Admin\Views\Courses\Detail.cshtml"
                                              Write(Model.CourseDetail.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                <li>students <span>");
#nullable restore
#line 40 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Areas\Admin\Views\Courses\Detail.cshtml"
                                              Write(Model.CourseDetail.StudentsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                <li>assesments <span>");
#nullable restore
#line 41 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Areas\Admin\Views\Courses\Detail.cshtml"
                                                Write(Model.CourseDetail.Assessment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                            </ul>\r\n                            <h3 class=\"red\">course fee $");
#nullable restore
#line 43 "C:\Users\HP\Desktop\BackEnd_Course_Project\BackEndFinalProject\Areas\Admin\Views\Courses\Detail.cshtml"
                                                   Write(Model.CourseDetail.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9c0218b7dd22e06a56e3d0cb3c92817ac08dded13588", async() => {
                WriteLiteral("Go Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
