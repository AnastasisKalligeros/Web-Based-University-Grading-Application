#pragma checksum "C:\Users\tasso\Desktop\ΜΑΘΗΜΑΤΑ ΜΕΧΡΙ 4ο ΕΤΟΣ\ΣΥΓΧΡΟΝΑ ΘΕΜΑΤΑ ΤΕΧΝΟΛΟΓΙΑΣ ΛΟΓΙΣΜΙΚΟΥ - ΛΟΓΙΣΜΙΚΟ ΓΙΑ ΚΙΝΗΤΕΣ ΣΥΣΚΕΥΕΣ\Π19253-Π19134\UniversityApplication\Views\Account\ErrorLogin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6970c184a71c0795fef009c5e7e1a95182824467"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ErrorLogin), @"mvc.1.0.view", @"/Views/Account/ErrorLogin.cshtml")]
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
#line 1 "C:\Users\tasso\Desktop\ΜΑΘΗΜΑΤΑ ΜΕΧΡΙ 4ο ΕΤΟΣ\ΣΥΓΧΡΟΝΑ ΘΕΜΑΤΑ ΤΕΧΝΟΛΟΓΙΑΣ ΛΟΓΙΣΜΙΚΟΥ - ΛΟΓΙΣΜΙΚΟ ΓΙΑ ΚΙΝΗΤΕΣ ΣΥΣΚΕΥΕΣ\Π19253-Π19134\UniversityApplication\Views\_ViewImports.cshtml"
using UniversityApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tasso\Desktop\ΜΑΘΗΜΑΤΑ ΜΕΧΡΙ 4ο ΕΤΟΣ\ΣΥΓΧΡΟΝΑ ΘΕΜΑΤΑ ΤΕΧΝΟΛΟΓΙΑΣ ΛΟΓΙΣΜΙΚΟΥ - ΛΟΓΙΣΜΙΚΟ ΓΙΑ ΚΙΝΗΤΕΣ ΣΥΣΚΕΥΕΣ\Π19253-Π19134\UniversityApplication\Views\_ViewImports.cshtml"
using UniversityApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6970c184a71c0795fef009c5e7e1a95182824467", @"/Views/Account/ErrorLogin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8821c6233fca62dbaba75f8c70a1cf9787cb9f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ErrorLogin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
#nullable restore
#line 1 "C:\Users\tasso\Desktop\ΜΑΘΗΜΑΤΑ ΜΕΧΡΙ 4ο ΕΤΟΣ\ΣΥΓΧΡΟΝΑ ΘΕΜΑΤΑ ΤΕΧΝΟΛΟΓΙΑΣ ΛΟΓΙΣΜΙΚΟΥ - ΛΟΓΙΣΜΙΚΟ ΓΙΑ ΚΙΝΗΤΕΣ ΣΥΣΚΕΥΕΣ\Π19253-Π19134\UniversityApplication\Views\Account\ErrorLogin.cshtml"
  
    ViewBag.Title = "ErrorLogin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Error Login</h2>\r\n<br />\r\n<br />\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6970c184a71c0795fef009c5e7e1a951828244673930", async() => {
                WriteLiteral(@"

    <div class=""agile-field-txt"">
        <label><i class=""fa fa-user"" aria-hidden=""true""></i> You used invalid username or password! Please press the button: ""Go back to Login!"" to try again! </label>
        <input type=""button"" value=""Go back to Login!""");
                BeginWriteAttribute("onclick", " onclick=\"", 354, "\"", 432, 2);
#nullable restore
#line 14 "C:\Users\tasso\Desktop\ΜΑΘΗΜΑΤΑ ΜΕΧΡΙ 4ο ΕΤΟΣ\ΣΥΓΧΡΟΝΑ ΘΕΜΑΤΑ ΤΕΧΝΟΛΟΓΙΑΣ ΛΟΓΙΣΜΙΚΟΥ - ΛΟΓΙΣΜΙΚΟ ΓΙΑ ΚΙΝΗΤΕΣ ΣΥΣΚΕΥΕΣ\Π19253-Π19134\UniversityApplication\Views\Account\ErrorLogin.cshtml"
WriteAttributeValue("", 364, "window.location.href='" + @Url.Action("Login", "Account") + "'", 364, 67, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 431, ";", 431, 1, true);
                EndWriteAttribute();
                WriteLiteral(@" >
    </div> <br /> <br />




    <div class=""agile-field-txt"">
        <label><i class=""fa fa-user"" aria-hidden=""true""></i> If you don't have an account press the button: ""Register"" to create one! </label>
        <input type=""button"" value=""Register""");
                BeginWriteAttribute("onclick", " onclick=\"", 695, "\"", 779, 2);
#nullable restore
#line 22 "C:\Users\tasso\Desktop\ΜΑΘΗΜΑΤΑ ΜΕΧΡΙ 4ο ΕΤΟΣ\ΣΥΓΧΡΟΝΑ ΘΕΜΑΤΑ ΤΕΧΝΟΛΟΓΙΑΣ ΛΟΓΙΣΜΙΚΟΥ - ΛΟΓΙΣΜΙΚΟ ΓΙΑ ΚΙΝΗΤΕΣ ΣΥΣΚΕΥΕΣ\Π19253-Π19134\UniversityApplication\Views\Account\ErrorLogin.cshtml"
WriteAttributeValue("", 705, "window.location.href='" + @Url.Action("AddRegister", "Account") + "'", 705, 73, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 778, ";", 778, 1, true);
                EndWriteAttribute();
                WriteLiteral(@" />

    </div>  <br /> <br />




    <div class=""agile-field-txt"">
        <label><i class=""fa fa-user"" aria-hidden=""true""></i> This username already exists! Please press the button: ""Go back to Register!"" to try again! </label>
        <input type=""button"" value=""Go back to Register!""");
                BeginWriteAttribute("onclick", " onclick=\"", 1077, "\"", 1161, 2);
#nullable restore
#line 31 "C:\Users\tasso\Desktop\ΜΑΘΗΜΑΤΑ ΜΕΧΡΙ 4ο ΕΤΟΣ\ΣΥΓΧΡΟΝΑ ΘΕΜΑΤΑ ΤΕΧΝΟΛΟΓΙΑΣ ΛΟΓΙΣΜΙΚΟΥ - ΛΟΓΙΣΜΙΚΟ ΓΙΑ ΚΙΝΗΤΕΣ ΣΥΣΚΕΥΕΣ\Π19253-Π19134\UniversityApplication\Views\Account\ErrorLogin.cshtml"
WriteAttributeValue("", 1087, "window.location.href='" + @Url.Action("AddRegister", "Account") + "'", 1087, 73, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1160, ";", 1160, 1, true);
                EndWriteAttribute();
                WriteLiteral(@" />

    </div>


    <br /> <br /> <br /> <br /> <br />

    <div class=""copy-wthree"">
        <p>
            Created by Anastasios Kalligeros and Georgios Papakwstas
            <span style=""color:blue; ""> &#8471; 2023 </span>

        </p>
    </div>
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
            WriteLiteral("\r\n");
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
