#pragma checksum "D:\01 Sample\Exercise\ZeroProj\StudentManagement\StudentManagement\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ff9018ef33023ad86ac4e5c5a7b0340ae3c2e43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
#line 18 "D:\01 Sample\Exercise\ZeroProj\StudentManagement\StudentManagement\Views\Home\Details.cshtml"
using StudentManagement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ff9018ef33023ad86ac4e5c5a7b0340ae3c2e43", @"/Views/Home/Details.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentManagement.Models.Student>
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
            BeginContext(383, 7, true);
            WriteLiteral("\r\n\r\n \r\n");
            EndContext();
            BeginContext(423, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(507, 45, true);
            WriteLiteral("<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            EndContext();
            BeginContext(552, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ff9018ef33023ad86ac4e5c5a7b0340ae3c2e433345", async() => {
                BeginContext(558, 23, true);
                WriteLiteral("\r\n    <title></title>\r\n");
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
            BeginContext(588, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(590, 873, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ff9018ef33023ad86ac4e5c5a7b0340ae3c2e434550", async() => {
                BeginContext(596, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(916, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(1172, 9, true);
                WriteLiteral("    <h3> ");
                EndContext();
                BeginContext(1182, 17, false);
#line 52 "D:\01 Sample\Exercise\ZeroProj\StudentManagement\StudentManagement\Views\Home\Details.cshtml"
    Write(ViewBag.PageTitle);

#line default
#line hidden
                EndContext();
                BeginContext(1199, 18, true);
                WriteLiteral("</h3>\r\n    <div>\r\n");
                EndContext();
                BeginContext(1317, 11, true);
                WriteLiteral("        姓名：");
                EndContext();
                BeginContext(1329, 10, false);
#line 57 "D:\01 Sample\Exercise\ZeroProj\StudentManagement\StudentManagement\Views\Home\Details.cshtml"
      Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1339, 36, true);
                WriteLiteral("\r\n    </div>\r\n    <div>\r\n        邮箱：");
                EndContext();
                BeginContext(1376, 11, false);
#line 60 "D:\01 Sample\Exercise\ZeroProj\StudentManagement\StudentManagement\Views\Home\Details.cshtml"
      Write(Model.Email);

#line default
#line hidden
                EndContext();
                BeginContext(1387, 39, true);
                WriteLiteral("\r\n    </div>\r\n    <div>\r\n        班级名称： ");
                EndContext();
                BeginContext(1427, 15, false);
#line 63 "D:\01 Sample\Exercise\ZeroProj\StudentManagement\StudentManagement\Views\Home\Details.cshtml"
         Write(Model.ClassName);

#line default
#line hidden
                EndContext();
                BeginContext(1442, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
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
            BeginContext(1463, 11, true);
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentManagement.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
