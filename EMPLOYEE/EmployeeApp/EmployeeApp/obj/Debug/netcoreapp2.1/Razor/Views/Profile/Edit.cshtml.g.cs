#pragma checksum "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001 - copia\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Profile\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5b32a4fc36b643e39b8ed38c731c0cba8db4ed6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Edit), @"mvc.1.0.view", @"/Views/Profile/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profile/Edit.cshtml", typeof(AspNetCore.Views_Profile_Edit))]
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
#line 1 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001 - copia\EMPLOYEE\EmployeeApp\EmployeeApp\Views\_ViewImports.cshtml"
using EmployeeApp;

#line default
#line hidden
#line 2 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001 - copia\EMPLOYEE\EmployeeApp\EmployeeApp\Views\_ViewImports.cshtml"
using EmployeeApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5b32a4fc36b643e39b8ed38c731c0cba8db4ed6", @"/Views/Profile/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f82655e463f87e91c1d4f9696068e4817f27c41", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeApp.Models.ProfileModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001 - copia\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Profile\Edit.cshtml"
  

    ViewData["Title"] = "Edit Profiles";

#line default
#line hidden
            BeginContext(93, 38, true);
            WriteLiteral("<h2>Create Employee Profile</h2>\r\n\r\n\r\n");
            EndContext();
#line 10 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001 - copia\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Profile\Edit.cshtml"
 using (Html.BeginForm("Edit", "Profile", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(195, 78, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"form-group col-lg-6\">\r\n            ");
            EndContext();
            BeginContext(274, 33, false);
#line 14 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001 - copia\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Profile\Edit.cshtml"
       Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(307, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(493, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(506, 34, false);
#line 18 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001 - copia\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Profile\Edit.cshtml"
       Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(540, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(555, 73, false);
#line 19 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001 - copia\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Profile\Edit.cshtml"
       Write(Html.TextBoxFor(model => model.Name, "", new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(628, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(643, 41, false);
#line 20 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001 - copia\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Profile\Edit.cshtml"
       Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(684, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(699, 80, false);
#line 21 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001 - copia\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Profile\Edit.cshtml"
       Write(Html.TextBoxFor(model => model.Description, "", new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(779, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(794, 36, false);
#line 22 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001 - copia\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Profile\Edit.cshtml"
       Write(Html.LabelFor(model => model.Salary));

#line default
#line hidden
            EndContext();
            BeginContext(830, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(845, 75, false);
#line 23 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001 - copia\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Profile\Edit.cshtml"
       Write(Html.TextBoxFor(model => model.Salary, "", new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(920, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(935, 41, false);
#line 24 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001 - copia\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Profile\Edit.cshtml"
       Write(Html.LabelFor(model => model.DateCreated));

#line default
#line hidden
            EndContext();
            BeginContext(976, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(991, 80, false);
#line 25 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001 - copia\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Profile\Edit.cshtml"
       Write(Html.TextBoxFor(model => model.DateCreated, "", new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1086, 41, false);
#line 26 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001 - copia\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Profile\Edit.cshtml"
       Write(Html.LabelFor(model => model.DateUpdated));

#line default
#line hidden
            EndContext();
            BeginContext(1127, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1142, 80, false);
#line 27 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001 - copia\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Profile\Edit.cshtml"
       Write(Html.TextBoxFor(model => model.DateUpdated, "", new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1222, 149, true);
            WriteLiteral("\r\n            <div>\r\n                <input type=\"submit\" value=\"Update\" class=\"btn btn-success\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 33 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001 - copia\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Profile\Edit.cshtml"
}

#line default
#line hidden
            BeginContext(1374, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeApp.Models.ProfileModel> Html { get; private set; }
    }
}
#pragma warning restore 1591