#pragma checksum "C:\Users\Arina\Desktop\Laba45\Views\Shared\EditPrintList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "429640c1e89001f1fc3959879ccabd9cca3f303a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditPrintList), @"mvc.1.0.view", @"/Views/Shared/EditPrintList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"429640c1e89001f1fc3959879ccabd9cca3f303a", @"/Views/Shared/EditPrintList.cshtml")]
    public class Views_Shared_EditPrintList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Laba45.Models.Entity.Sick_List>>
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
#nullable restore
#line 2 "C:\Users\Arina\Desktop\Laba45\Views\Shared\EditPrintList.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "429640c1e89001f1fc3959879ccabd9cca3f303a2943", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>PrintLists</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "429640c1e89001f1fc3959879ccabd9cca3f303a4007", async() => {
                WriteLiteral(@"
    <h1 align=""center"">Больничные листы</h1>
    <table border=""1"" width=""100%"">
        <tr>
            <th>Фамилия пациента</th>
            <th>ID</th>
            <th>Место работы</th>
            <th>Дата открытия больничного</th>
            <th>Дата закрытия больничного</th>
            <th>Ссылка на изменение</th>
        </tr>
");
#nullable restore
#line 24 "C:\Users\Arina\Desktop\Laba45\Views\Shared\EditPrintList.cshtml"
          
            foreach (var Lists in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\Arina\Desktop\Laba45\Views\Shared\EditPrintList.cshtml"
                   Write(Lists.Patient.Surname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\Arina\Desktop\Laba45\Views\Shared\EditPrintList.cshtml"
                   Write(Lists.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\Arina\Desktop\Laba45\Views\Shared\EditPrintList.cshtml"
                   Write(Lists.PlaceWork);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\Arina\Desktop\Laba45\Views\Shared\EditPrintList.cshtml"
                   Write(Lists.StartDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\Arina\Desktop\Laba45\Views\Shared\EditPrintList.cshtml"
                   Write(Lists.FinishDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td><a");
                BeginWriteAttribute("href", " href=\"", 924, "\"", 959, 2);
                WriteAttributeValue("", 931, "/Hospital/EditList/", 931, 19, true);
#nullable restore
#line 33 "C:\Users\Arina\Desktop\Laba45\Views\Shared\EditPrintList.cshtml"
WriteAttributeValue("", 950, Lists.Id, 950, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Изменение б.листа</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 35 "C:\Users\Arina\Desktop\Laba45\Views\Shared\EditPrintList.cshtml"
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n    <div>\r\n        ");
#nullable restore
#line 39 "C:\Users\Arina\Desktop\Laba45\Views\Shared\EditPrintList.cshtml"
   Write(Html.ActionLink("Вернуться на главную страницу", "MainPage"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Laba45.Models.Entity.Sick_List>> Html { get; private set; }
    }
}
#pragma warning restore 1591