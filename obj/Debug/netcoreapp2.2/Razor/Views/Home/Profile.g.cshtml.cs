#pragma checksum "C:\Users\Nasser\source\repos\MyWebSite\MyWebSite\Views\Home\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8eff11b74e4b82772e60bf49093535edb2b67b4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Profile), @"mvc.1.0.view", @"/Views/Home/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Profile.cshtml", typeof(AspNetCore.Views_Home_Profile))]
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
#line 1 "C:\Users\Nasser\source\repos\MyWebSite\MyWebSite\Views\_ViewImports.cshtml"
using MyWebSite;

#line default
#line hidden
#line 2 "C:\Users\Nasser\source\repos\MyWebSite\MyWebSite\Views\_ViewImports.cshtml"
using MyWebSite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eff11b74e4b82772e60bf49093535edb2b67b4f", @"/Views/Home/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0915b4a45873913d1dacfe45d55d4f713bad4fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 45, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\" dir=\"ltr\">\r\n");
            EndContext();
            BeginContext(45, 595, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8eff11b74e4b82772e60bf49093535edb2b67b4f3361", async() => {
                BeginContext(51, 582, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title></title>
    <link rel=""stylesheet"" href=""style.css"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.0/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery.ripples/0.5.3/jquery.ripples.min.js""></script>
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.7.2/css/all.css"">
    <link rel=""stylesheet"" href=""../css/animate.css"">
    <link rel=""stylesheet"" href=""../css/Profile.css"">

");
                EndContext();
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
            EndContext();
            BeginContext(640, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(642, 3658, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8eff11b74e4b82772e60bf49093535edb2b67b4f5149", async() => {
                BeginContext(648, 3645, true);
                WriteLiteral(@"
    <div class=""services-section"">
        <div class=""inner-width"">
            <div class=""title"">

                <h1 class=""section-title"">Profile</h1>
                <div class=""border""></div>
            </div>

            <div class=""middle slideInRight animated"">
                <div class=""sm-container"">
                    <i class=""show-btn fas fa-user""></i> <span style=""color:white;font-weight:bold;"">Socials</span>
                    <div class=""sm-menu"">
                        <a href=""https://www.facebook.com/profile.php?id=100007525897366""><i class=""fab fa-facebook-f""></i></a>
                        <a href=""https://www.instagram.com/hadi_nasser77/""><i class=""fab fa-instagram""></i></a>
                        <a href=""https://twitter.com/HadiNas96216691?lang=en""><i class=""fab fa-twitter""></i></a>
                    </div>
                </div>
            </div>

            <div class=""profile zoomIn animated"">
                <img src=""../images/me2.jpg"" class=""b");
                WriteLiteral(@"ox-img"" />
                <h1 class=""zoomIn animated"">HadiNasser</h1>
                <h3 class=""zoomIn animated"">Computer Science Specialist</h3>

                <p>You might not think that programmers are artists, but programming is an extremely creative profession. It's logic based creativity</p>
                <div class=""education"">


                    <div class=""title zoomIn animated"">
                        Education
                    </div>
                    <div class=""school zoomIn animated delay-1s"">
                        <div class=""schooltitle"">
                            <i class=""fas fa-school"" style=""font-size:30px;""></i>  Al-Nahda School
                        </div>
                        <div class=""date"">
                            <p>- from grade one -- to grade six</p>
                        </div>
                    </div>
                    <div class=""school zoomIn animated delay-2s"">
                        <div class=""schooltitle"">
          ");
                WriteLiteral(@"                  <img src=""../images/school1.png"" alt=""""> My New Collage
                        </div>
                        <div class=""date"">
                            <p>- from grade seven -- to grade nine</p>
                            <p>- Bachelor of Life Science</p>

                        </div>
                    </div>
                    <div class=""school zoomIn animated delay-3s"">
                        <div class=""schooltitle"">
                            <img src=""../images/school2.jpg"" alt="""" style=""height:60px;""> Hussein Maktabe High School
                        </div>
                        <div class=""date"">

                            <p>- from grade ten -- to grade eleven</p>

                        </div>
                    </div>
                    <div class=""school zoomIn animated delay-4s"">
                        <div class=""schooltitle"">
                            <img src=""../images/uni.png"" alt=""""> Lebanese University-Faculty of Sciences
   ");
                WriteLiteral(@"                     </div>
                        <div class=""date"">
                            <p>- Bachelor of Science in Computer Sciences</p>

                        </div>
                    </div>
                </div>
            </div>


        </div>
    </div>


    <script type=""text/javascript"">
      $("".services-section"").ripples({
        resolution:400,
        perturbance:0.003,
      });
    </script>
    <script>
      $("".show-btn"").click(function(){
        $("".sm-menu"").fadeToggle(""fast"");
      });
    </script>
");
                EndContext();
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
            EndContext();
            BeginContext(4300, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
