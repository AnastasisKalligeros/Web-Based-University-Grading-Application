#pragma checksum "C:\Users\tasso\Desktop\ΜΑΘΗΜΑΤΑ ΜΕΧΡΙ 4ο ΕΤΟΣ\ΣΥΓΧΡΟΝΑ ΘΕΜΑΤΑ ΤΕΧΝΟΛΟΓΙΑΣ ΛΟΓΙΣΜΙΚΟΥ - ΛΟΓΙΣΜΙΚΟ ΓΙΑ ΚΙΝΗΤΕΣ ΣΥΣΚΕΥΕΣ\Π19253-Π19134\UniversityApplication\Views\Account\ErrorUsernameAlreadyExists.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b954ac32090956f6aa8e9b805af0e07b137d21f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ErrorUsernameAlreadyExists), @"mvc.1.0.view", @"/Views/Account/ErrorUsernameAlreadyExists.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b954ac32090956f6aa8e9b805af0e07b137d21f8", @"/Views/Account/ErrorUsernameAlreadyExists.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8821c6233fca62dbaba75f8c70a1cf9787cb9f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ErrorUsernameAlreadyExists : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\tasso\Desktop\ΜΑΘΗΜΑΤΑ ΜΕΧΡΙ 4ο ΕΤΟΣ\ΣΥΓΧΡΟΝΑ ΘΕΜΑΤΑ ΤΕΧΝΟΛΟΓΙΑΣ ΛΟΓΙΣΜΙΚΟΥ - ΛΟΓΙΣΜΙΚΟ ΓΙΑ ΚΙΝΗΤΕΣ ΣΥΣΚΕΥΕΣ\Π19253-Π19134\UniversityApplication\Views\Account\ErrorUsernameAlreadyExists.cshtml"
  
    ViewBag.Title = "ErrorUsernameAlreadyExists";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2>Error!</h2>
<br />
<br />



<div class=""agile-field-txt"">
    <label><i class=""fa fa-user"" aria-hidden=""true""></i> This username already exists! Please press the button: ""Go back to Register!"" to try again! </label>
    <input type=""button"" value=""Go back to Register!""");
            BeginWriteAttribute("onclick", " onclick=\"", 342, "\"", 427, 2);
#nullable restore
#line 13 "C:\Users\tasso\Desktop\ΜΑΘΗΜΑΤΑ ΜΕΧΡΙ 4ο ΕΤΟΣ\ΣΥΓΧΡΟΝΑ ΘΕΜΑΤΑ ΤΕΧΝΟΛΟΓΙΑΣ ΛΟΓΙΣΜΙΚΟΥ - ΛΟΓΙΣΜΙΚΟ ΓΙΑ ΚΙΝΗΤΕΣ ΣΥΣΚΕΥΕΣ\Π19253-Π19134\UniversityApplication\Views\Account\ErrorUsernameAlreadyExists.cshtml"
WriteAttributeValue("", 352, "window.location.href='" + @Url.Action("Registration", "Account") + "'", 352, 74, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 426, ";", 426, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n</div>\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n\r\n<div class=\"copy-wthree\">\r\n    <p>\r\n        Created by Anastasios Kalligeros and Georgios Papakwstas\r\n        <span style=\"color:blue; \"> &#8471; 2023 </span>\r\n\r\n    </p>\r\n</div>");
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