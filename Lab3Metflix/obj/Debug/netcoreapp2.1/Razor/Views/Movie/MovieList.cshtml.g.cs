#pragma checksum "C:\Users\Jace\Desktop\COMP306_Lab#3_Group6\Lab#3\Lab3Metflix\Views\Movie\MovieList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea9d8ae49a6c740906edeba66ce02511ad2d73cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_MovieList), @"mvc.1.0.view", @"/Views/Movie/MovieList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/MovieList.cshtml", typeof(AspNetCore.Views_Movie_MovieList))]
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
#line 1 "C:\Users\Jace\Desktop\COMP306_Lab#3_Group6\Lab#3\Lab3Metflix\Views\_ViewImports.cshtml"
using Lab3Metflix;

#line default
#line hidden
#line 2 "C:\Users\Jace\Desktop\COMP306_Lab#3_Group6\Lab#3\Lab3Metflix\Views\_ViewImports.cshtml"
using Lab3Metflix.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea9d8ae49a6c740906edeba66ce02511ad2d73cb", @"/Views/Movie/MovieList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d94a2474272bafe852bee9a5173da519b3c4f7b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_MovieList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieList>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateMovie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MovieDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Jace\Desktop\COMP306_Lab#3_Group6\Lab#3\Lab3Metflix\Views\Movie\MovieList.cshtml"
   ViewData["Title"] = "Movie List"; 

#line default
#line hidden
            BeginContext(56, 44, true);
            WriteLiteral("\n\n<div class=\"wrap-list\">\n\n    <h1>Welcome, ");
            EndContext();
            BeginContext(101, 20, false);
#line 7 "C:\Users\Jace\Desktop\COMP306_Lab#3_Group6\Lab#3\Lab3Metflix\Views\Movie\MovieList.cshtml"
            Write(Model.Users.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(121, 79, true);
            WriteLiteral("!</h1>\n    <p class=\"lead\">\n        <span class=\"btn-link-red btn-align-right\">");
            EndContext();
            BeginContext(200, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a99947d2f21426bab6a8bbc51ef1781", async() => {
                BeginContext(265, 12, true);
                WriteLiteral("Create Movie");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-email", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 9 "C:\Users\Jace\Desktop\COMP306_Lab#3_Group6\Lab#3\Lab3Metflix\Views\Movie\MovieList.cshtml"
                                                                                    WriteLiteral(Model.Users.Email);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["email"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-email", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["email"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(281, 246, true);
            WriteLiteral("</span>\n    </p>\n\n    <table class=\"table\">\n        <thead>\n            <tr>\n                <th>Poster</th>\n                <th>Title</th>\n                <th>Movie Detail</th>\n                \n            </tr>\n        </thead>\n        <tbody>\n");
            EndContext();
#line 22 "C:\Users\Jace\Desktop\COMP306_Lab#3_Group6\Lab#3\Lab3Metflix\Views\Movie\MovieList.cshtml"
             foreach (var item in Model.Movies)
            {

#line default
#line hidden
            BeginContext(589, 62, true);
            WriteLiteral("            <tr>\n                <td>\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 651, "\"", 715, 1);
#line 26 "C:\Users\Jace\Desktop\COMP306_Lab#3_Group6\Lab#3\Lab3Metflix\Views\Movie\MovieList.cshtml"
WriteAttributeValue("", 657, item.MovieImage.GetPreSignedURL(DateTime.Now.AddHours(1)), 657, 58, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(716, 139, true);
            WriteLiteral("\n                         width=\"80\"\n                         height=\"80\">\n\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(856, 15, false);
#line 32 "C:\Users\Jace\Desktop\COMP306_Lab#3_Group6\Lab#3\Lab3Metflix\Views\Movie\MovieList.cshtml"
               Write(item.MovieTitle);

#line default
#line hidden
            EndContext();
            BeginContext(871, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(935, 133, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db9bd66c274e4cf487586930d5dcf977", async() => {
                BeginContext(1057, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-email", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "C:\Users\Jace\Desktop\COMP306_Lab#3_Group6\Lab#3\Lab3Metflix\Views\Movie\MovieList.cshtml"
                                                     WriteLiteral(Model.Users.Email);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["email"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-email", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["email"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 36 "C:\Users\Jace\Desktop\COMP306_Lab#3_Group6\Lab#3\Lab3Metflix\Views\Movie\MovieList.cshtml"
                              WriteLiteral(item.MovieId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movieId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-movieId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["movieId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1068, 57, true);
            WriteLiteral("\n                </td>\n                \n            </tr>");
            EndContext();
#line 39 "C:\Users\Jace\Desktop\COMP306_Lab#3_Group6\Lab#3\Lab3Metflix\Views\Movie\MovieList.cshtml"
                 }

#line default
#line hidden
            BeginContext(1127, 36, true);
            WriteLiteral("        </tbody>\n    </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieList> Html { get; private set; }
    }
}
#pragma warning restore 1591
