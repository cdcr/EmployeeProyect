#pragma checksum "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02fe88c8caa48a6e6fac80f806ca28238b5705c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Index.cshtml", typeof(AspNetCore.Views_Employee_Index))]
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
#line 1 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001\EMPLOYEE\EmployeeApp\EmployeeApp\Views\_ViewImports.cshtml"
using EmployeeApp;

#line default
#line hidden
#line 2 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001\EMPLOYEE\EmployeeApp\EmployeeApp\Views\_ViewImports.cshtml"
using EmployeeApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02fe88c8caa48a6e6fac80f806ca28238b5705c3", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f82655e463f87e91c1d4f9696068e4817f27c41", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeApp.Models.EmployeeModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/CreateEmployee"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Employee/CreateEmployee"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(97, 30, true);
            WriteLiteral("\r\n<h2>Employee List</h2>\r\n\r\n\r\n");
            EndContext();
#line 10 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
 using (Html.BeginForm("Index", "Employee"))
{

#line default
#line hidden
            BeginContext(176, 327, true);
            WriteLiteral(@"    <div>
        <div class=""row"">
            <div class=""form-group col-lg-6"">
                <input type=""text"" class=""form-control"" name=""Id"" id=""txtName"" placeholder=""Insert Employee ID"" />
                <button class=""btn btn-success"" type=""submit"">Get Employees</button>
                <p class=""text-warning"">");
            EndContext();
            BeginContext(504, 15, false);
#line 17 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
                                   Write(ViewBag.Warning);

#line default
#line hidden
            EndContext();
            BeginContext(519, 54, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 21 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
}

#line default
#line hidden
            BeginContext(576, 140, true);
            WriteLiteral("\r\n<table class=\"table table-striped table-bordered table-hover\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th scope=\"col\">");
            EndContext();
            BeginContext(717, 38, false);
#line 26 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(755, 35, true);
            WriteLiteral("</th>\r\n            <th scope=\"col\">");
            EndContext();
            BeginContext(791, 40, false);
#line 27 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(831, 35, true);
            WriteLiteral("</th>\r\n            <th scope=\"col\">");
            EndContext();
            BeginContext(867, 52, false);
#line 28 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.ContractTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(919, 35, true);
            WriteLiteral("</th>\r\n            <th scope=\"col\">");
            EndContext();
            BeginContext(955, 42, false);
#line 29 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.RoleId));

#line default
#line hidden
            EndContext();
            BeginContext(997, 35, true);
            WriteLiteral("</th>\r\n            <th scope=\"col\">");
            EndContext();
            BeginContext(1033, 44, false);
#line 30 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.RoleName));

#line default
#line hidden
            EndContext();
            BeginContext(1077, 35, true);
            WriteLiteral("</th>\r\n            <th scope=\"col\">");
            EndContext();
            BeginContext(1113, 51, false);
#line 31 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.RoleDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1164, 35, true);
            WriteLiteral("</th>\r\n            <th scope=\"col\">");
            EndContext();
            BeginContext(1200, 47, false);
#line 32 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.AnualSalary));

#line default
#line hidden
            EndContext();
            BeginContext(1247, 90, true);
            WriteLiteral("</th>\r\n            <th colspan=\"2\" scope=\"col\">Options</th>\r\n        </tr>\r\n    </thead>\r\n");
            EndContext();
#line 36 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
            BeginContext(1380, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1411, 7, false);
#line 40 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
           Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1418, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1442, 9, false);
#line 41 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1451, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1475, 21, false);
#line 42 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
           Write(item.ContractTypeName);

#line default
#line hidden
            EndContext();
            BeginContext(1496, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1520, 11, false);
#line 43 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
           Write(item.RoleId);

#line default
#line hidden
            EndContext();
            BeginContext(1531, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1555, 13, false);
#line 44 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
           Write(item.RoleName);

#line default
#line hidden
            EndContext();
            BeginContext(1568, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1592, 20, false);
#line 45 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
           Write(item.RoleDescription);

#line default
#line hidden
            EndContext();
            BeginContext(1612, 44, true);
            WriteLiteral("</td>\r\n            <td class=\"text-success\">");
            EndContext();
            BeginContext(1657, 41, false);
#line 46 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
                                Write(string.Format("{0:C}", @item.AnualSalary));

#line default
#line hidden
            EndContext();
            BeginContext(1698, 41, true);
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1739, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02fe88c8caa48a6e6fac80f806ca28238b5705c313891", async() => {
                BeginContext(1790, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1798, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1853, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02fe88c8caa48a6e6fac80f806ca28238b5705c315323", async() => {
                BeginContext(1903, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1913, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 54 "C:\Users\USUARIO\Documents\VERSIONES ESTABLES\EMPLOYEE-20220708T205533Z-001\EMPLOYEE\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1956, 95, true);
            WriteLiteral("</table>\r\n<div>\r\n    <div class=\"row\">\r\n        <div class=\"form-group col-lg-6\">\r\n            ");
            EndContext();
            BeginContext(2051, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02fe88c8caa48a6e6fac80f806ca28238b5705c317133", async() => {
                BeginContext(2111, 12, true);
                WriteLiteral("New Employee");
                EndContext();
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
            EndContext();
            BeginContext(2127, 40, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeApp.Models.EmployeeModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
