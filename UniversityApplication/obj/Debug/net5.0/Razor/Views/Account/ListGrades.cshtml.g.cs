#pragma checksum "C:\Users\tasso\Desktop\ΜΑΘΗΜΑΤΑ ΜΕΧΡΙ 4ο ΕΤΟΣ\ΣΥΓΧΡΟΝΑ ΘΕΜΑΤΑ ΤΕΧΝΟΛΟΓΙΑΣ ΛΟΓΙΣΜΙΚΟΥ - ΛΟΓΙΣΜΙΚΟ ΓΙΑ ΚΙΝΗΤΕΣ ΣΥΣΚΕΥΕΣ\Π19253-Π19134\UniversityApplication\Views\Account\ListGrades.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "061d6d79124f3b11537a2bbe56bf02780113764d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ListGrades), @"mvc.1.0.view", @"/Views/Account/ListGrades.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"061d6d79124f3b11537a2bbe56bf02780113764d", @"/Views/Account/ListGrades.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8821c6233fca62dbaba75f8c70a1cf9787cb9f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ListGrades : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyViewModel>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "061d6d79124f3b11537a2bbe56bf02780113764d3593", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "061d6d79124f3b11537a2bbe56bf02780113764d4563", async() => {
                WriteLiteral("\r\n\r\n\r\n    <div>\r\n        <h1 id=\"but1\">View List </h1>\r\n    </div> <br /> <br />\r\n");
#nullable restore
#line 15 "C:\Users\tasso\Desktop\ΜΑΘΗΜΑΤΑ ΜΕΧΡΙ 4ο ΕΤΟΣ\ΣΥΓΧΡΟΝΑ ΘΕΜΑΤΑ ΤΕΧΝΟΛΟΓΙΑΣ ΛΟΓΙΣΜΙΚΟΥ - ΛΟΓΙΣΜΙΚΟ ΓΙΑ ΚΙΝΗΤΕΣ ΣΥΣΚΕΥΕΣ\Π19253-Π19134\UniversityApplication\Views\Account\ListGrades.cshtml"
     if (Model.cours.Count() > 0)

    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <table class=\"table table-striped\" id=\"tab\">\r\n            <tr>\r\n\r\n                <th>Registration Number</th>\r\n                <th>Grade</th>\r\n            </tr>\r\n\r\n");
#nullable restore
#line 25 "C:\Users\tasso\Desktop\ΜΑΘΗΜΑΤΑ ΜΕΧΡΙ 4ο ΕΤΟΣ\ΣΥΓΧΡΟΝΑ ΘΕΜΑΤΑ ΤΕΧΝΟΛΟΓΙΑΣ ΛΟΓΙΣΜΙΚΟΥ - ΛΟΓΙΣΜΙΚΟ ΓΙΑ ΚΙΝΗΤΕΣ ΣΥΣΚΕΥΕΣ\Π19253-Π19134\UniversityApplication\Views\Account\ListGrades.cshtml"
             foreach (var row in Model.cours)

            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\tasso\Desktop\ΜΑΘΗΜΑΤΑ ΜΕΧΡΙ 4ο ΕΤΟΣ\ΣΥΓΧΡΟΝΑ ΘΕΜΑΤΑ ΤΕΧΝΟΛΟΓΙΑΣ ΛΟΓΙΣΜΙΚΟΥ - ΛΟΓΙΣΜΙΚΟ ΓΙΑ ΚΙΝΗΤΕΣ ΣΥΣΚΕΥΕΣ\Π19253-Π19134\UniversityApplication\Views\Account\ListGrades.cshtml"
                   Write(row.registrationnumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\tasso\Desktop\ΜΑΘΗΜΑΤΑ ΜΕΧΡΙ 4ο ΕΤΟΣ\ΣΥΓΧΡΟΝΑ ΘΕΜΑΤΑ ΤΕΧΝΟΛΟΓΙΑΣ ΛΟΓΙΣΜΙΚΟΥ - ΛΟΓΙΣΜΙΚΟ ΓΙΑ ΚΙΝΗΤΕΣ ΣΥΣΚΕΥΕΣ\Π19253-Π19134\UniversityApplication\Views\Account\ListGrades.cshtml"
                   Write(row.gradecoursestudent);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 33 "C:\Users\tasso\Desktop\ΜΑΘΗΜΑΤΑ ΜΕΧΡΙ 4ο ΕΤΟΣ\ΣΥΓΧΡΟΝΑ ΘΕΜΑΤΑ ΤΕΧΝΟΛΟΓΙΑΣ ΛΟΓΙΣΜΙΚΟΥ - ΛΟΓΙΣΜΙΚΟ ΓΙΑ ΚΙΝΗΤΕΣ ΣΥΣΚΕΥΕΣ\Π19253-Π19134\UniversityApplication\Views\Account\ListGrades.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n        </table> <br /> <br />\r\n");
#nullable restore
#line 38 "C:\Users\tasso\Desktop\ΜΑΘΗΜΑΤΑ ΜΕΧΡΙ 4ο ΕΤΟΣ\ΣΥΓΧΡΟΝΑ ΘΕΜΑΤΑ ΤΕΧΝΟΛΟΓΙΑΣ ΛΟΓΙΣΜΙΚΟΥ - ΛΟΓΙΣΜΙΚΟ ΓΙΑ ΚΙΝΗΤΕΣ ΣΥΣΚΕΥΕΣ\Π19253-Π19134\UniversityApplication\Views\Account\ListGrades.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("<label><i class=\"fa fa-user\" aria-hidden=\"true\"></i>This course doesn’t  exist! Please press the button “Go back!” to try again. </label>\r\n         <br /> <br />\r\n        <div>\r\n            <input type=\"submit\" value=\"Go Back!\"");
                BeginWriteAttribute("onclick", " onclick=\"", 881, "\"", 958, 2);
#nullable restore
#line 44 "C:\Users\tasso\Desktop\ΜΑΘΗΜΑΤΑ ΜΕΧΡΙ 4ο ΕΤΟΣ\ΣΥΓΧΡΟΝΑ ΘΕΜΑΤΑ ΤΕΧΝΟΛΟΓΙΑΣ ΛΟΓΙΣΜΙΚΟΥ - ΛΟΓΙΣΜΙΚΟ ΓΙΑ ΚΙΝΗΤΕΣ ΣΥΣΚΕΥΕΣ\Π19253-Π19134\UniversityApplication\Views\Account\ListGrades.cshtml"
WriteAttributeValue("", 891, "window.location.href='" + @Url.Action("List", "Account") + "'", 891, 66, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 957, ";", 957, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div> <br /> <br /> <br /> <br /> <br />\r\n");
#nullable restore
#line 46 "C:\Users\tasso\Desktop\ΜΑΘΗΜΑΤΑ ΜΕΧΡΙ 4ο ΕΤΟΣ\ΣΥΓΧΡΟΝΑ ΘΕΜΑΤΑ ΤΕΧΝΟΛΟΓΙΑΣ ΛΟΓΙΣΜΙΚΟΥ - ΛΟΓΙΣΜΙΚΟ ΓΙΑ ΚΙΝΗΤΕΣ ΣΥΣΚΕΥΕΣ\Π19253-Π19134\UniversityApplication\Views\Account\ListGrades.cshtml"



    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <div class=\"copy-wthree\">\r\n        <p>\r\n            Created by Anastasis Kalligeros and Georgios Papakostas\r\n            <span style=\"color:blue; \"> &#8471; 2023 </span>\r\n\r\n        </p>\r\n    </div>\r\n\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
